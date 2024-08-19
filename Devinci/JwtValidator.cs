using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace Devinci
{
	public class JwtValidator
	{
		private static async Task<string> GetCognitoPublicKeys(string region, string userPoolId)
		{
			string jwksUrl = $"https://cognito-idp.{region}.amazonaws.com/{userPoolId}/.well-known/jwks.json";
			using (HttpClient client = new HttpClient())
			{
				return await client.GetStringAsync(jwksUrl);
			}
		}

		public static async Task<JwtSecurityToken> ValidateTokenAsync(string token, string region, string userPoolId, string clientId)
		{
			// Fetch the public keys
			string jwks = await GetCognitoPublicKeys(region, userPoolId);
			var keys = new JsonWebKeySet(jwks).GetSigningKeys();

			// Token validation parameters
			var tokenValidationParameters = new TokenValidationParameters
			{
				ValidateIssuer = true,
				ValidateAudience = false,
				ValidateLifetime = true,
				ValidateIssuerSigningKey = true,
				ValidIssuer = $"https://cognito-idp.{region}.amazonaws.com/{userPoolId}",
				ValidAudience = clientId,
				IssuerSigningKeys = keys
			};

			// Validate the token
			SecurityToken validatedToken;
			JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
			try
			{
				tokenHandler.ValidateToken(token, tokenValidationParameters, out validatedToken);
				return (JwtSecurityToken)validatedToken;
			}
			catch (SecurityTokenExpiredException)
			{
				Console.WriteLine("Token has expired");
				return null;
			}
			catch (SecurityTokenException)
			{
				Console.WriteLine("Invalid token");
				return null;
			}
		}
	}
}