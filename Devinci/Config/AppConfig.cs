
namespace Devinci.Config
{
	public class AppConfig
	{
		public string B2CTenantName { get; set; }
		public string TokenRequestUrl { get; set; }
		public List<ClientApp> ClientApps { get; set; }
		public List<ResourceApp> ResourceApps { get; set; }
	}

	public class ClientApp
	{
		public string Id { get; set; }
		public string ClientId { get; set; }
		public string ClientSecret { get; set; }

		public override string ToString()
		{
			return Id;
		}
	}

	public class ResourceApp
	{
		public string Id { get; set; }
		public string ClientId { get; set; }
		public string AppIdUri { get; set; }

		public override string ToString()
		{
			return Id;
		}
	}
}
