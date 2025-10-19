namespace Devinci
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			btnCopy = new Button();
			txtDecodedToken = new TextBox();
			txtToken = new TextBox();
			txtUrl = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			cmbClientApps = new ComboBox();
			cmbResourceApps = new ComboBox();
			btnGetToken = new Button();
			SuspendLayout();
			// 
			// btnCopy
			// 
			btnCopy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnCopy.Image = Properties.Resources.copy_16;
			btnCopy.Location = new Point(857, 207);
			btnCopy.Margin = new Padding(4, 5, 4, 5);
			btnCopy.Name = "btnCopy";
			btnCopy.Size = new Size(44, 50);
			btnCopy.TabIndex = 7;
			btnCopy.UseVisualStyleBackColor = true;
			btnCopy.Click += btnCopy_Click;
			// 
			// txtDecodedToken
			// 
			txtDecodedToken.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txtDecodedToken.BackColor = SystemColors.Window;
			txtDecodedToken.ForeColor = SystemColors.ActiveCaptionText;
			txtDecodedToken.Location = new Point(17, 280);
			txtDecodedToken.Margin = new Padding(4, 5, 4, 5);
			txtDecodedToken.Multiline = true;
			txtDecodedToken.Name = "txtDecodedToken";
			txtDecodedToken.ScrollBars = ScrollBars.Vertical;
			txtDecodedToken.Size = new Size(881, 477);
			txtDecodedToken.TabIndex = 9;
			// 
			// txtToken
			// 
			txtToken.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtToken.BackColor = Color.White;
			txtToken.ForeColor = SystemColors.ActiveCaptionText;
			txtToken.Location = new Point(93, 212);
			txtToken.Margin = new Padding(4, 5, 4, 5);
			txtToken.Name = "txtToken";
			txtToken.Size = new Size(756, 31);
			txtToken.TabIndex = 14;
			// 
			// txtUrl
			// 
			txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtUrl.BackColor = Color.White;
			txtUrl.BorderStyle = BorderStyle.FixedSingle;
			txtUrl.ForeColor = SystemColors.ActiveCaptionText;
			txtUrl.Location = new Point(57, 17);
			txtUrl.Margin = new Padding(4, 5, 4, 5);
			txtUrl.Name = "txtUrl";
			txtUrl.Size = new Size(841, 31);
			txtUrl.TabIndex = 18;
			txtUrl.Text = "fdsa";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 19);
			label1.Name = "label1";
			label1.Size = new Size(38, 25);
			label1.TabIndex = 19;
			label1.Text = "Url:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(15, 70);
			label2.Name = "label2";
			label2.Size = new Size(104, 25);
			label2.TabIndex = 20;
			label2.Text = " Client App:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(475, 68);
			label3.Name = "label3";
			label3.Size = new Size(43, 25);
			label3.TabIndex = 21;
			label3.Text = "API:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(24, 215);
			label4.Name = "label4";
			label4.Size = new Size(62, 25);
			label4.TabIndex = 22;
			label4.Text = "Token:";
			// 
			// cmbClientApps
			// 
			cmbClientApps.FormattingEnabled = true;
			cmbClientApps.Location = new Point(125, 65);
			cmbClientApps.Name = "cmbClientApps";
			cmbClientApps.Size = new Size(330, 33);
			cmbClientApps.TabIndex = 23;
			// 
			// cmbResourceApps
			// 
			cmbResourceApps.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			cmbResourceApps.FormattingEnabled = true;
			cmbResourceApps.Location = new Point(524, 65);
			cmbResourceApps.Name = "cmbResourceApps";
			cmbResourceApps.Size = new Size(374, 33);
			cmbResourceApps.TabIndex = 24;
			// 
			// btnGetToken
			// 
			btnGetToken.Location = new Point(373, 118);
			btnGetToken.Name = "btnGetToken";
			btnGetToken.Size = new Size(112, 72);
			btnGetToken.TabIndex = 25;
			btnGetToken.Text = "Get Token";
			btnGetToken.UseVisualStyleBackColor = true;
			btnGetToken.Click += btnGetToken_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Gainsboro;
			ClientSize = new Size(917, 782);
			Controls.Add(btnGetToken);
			Controls.Add(cmbResourceApps);
			Controls.Add(cmbClientApps);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtUrl);
			Controls.Add(txtToken);
			Controls.Add(txtDecodedToken);
			Controls.Add(btnCopy);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 5, 4, 5);
			Name = "Form1";
			Text = "Devinci";
			FormClosing += Form1_FormClosing;
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button btnSetPassword;
		private Button btnCopy;
		private TextBox txtDecodedToken;
		private TextBox txtToken;
		private TextBox txtUrl;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private ComboBox cmbClientApps;
		private ComboBox cmbResourceApps;
		private Button btnGetToken;
	}
}
