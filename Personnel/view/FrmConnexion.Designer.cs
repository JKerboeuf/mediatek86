namespace Personnel.view
{
	partial class FrmConnexion
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtIdentifiant = new System.Windows.Forms.TextBox();
			this.txtMdp = new System.Windows.Forms.TextBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtIdentifiant
			// 
			this.txtIdentifiant.Location = new System.Drawing.Point(15, 25);
			this.txtIdentifiant.Name = "txtIdentifiant";
			this.txtIdentifiant.Size = new System.Drawing.Size(174, 20);
			this.txtIdentifiant.TabIndex = 0;
			// 
			// txtMdp
			// 
			this.txtMdp.Location = new System.Drawing.Point(15, 64);
			this.txtMdp.Name = "txtMdp";
			this.txtMdp.Size = new System.Drawing.Size(174, 20);
			this.txtMdp.TabIndex = 1;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(15, 90);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(174, 23);
			this.btnConnect.TabIndex = 2;
			this.btnConnect.Text = "Se connecter";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Identifiant";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mot de passe";
			// 
			// FrmConnexion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(206, 124);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.txtMdp);
			this.Controls.Add(this.txtIdentifiant);
			this.Name = "FrmConnexion";
			this.Text = "Connexion";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtIdentifiant;
		private System.Windows.Forms.TextBox txtMdp;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}