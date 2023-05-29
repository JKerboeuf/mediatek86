namespace MediaTek86.view
{
	partial class FrmPersonnel
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonnel));
			this.grbPersonnel = new System.Windows.Forms.GroupBox();
			this.lsbPersonnel = new System.Windows.Forms.ListBox();
			this.btnPersoAjout = new System.Windows.Forms.Button();
			this.btnPersoSuppr = new System.Windows.Forms.Button();
			this.grbPersoModif = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbServices = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtPrenom = new System.Windows.Forms.TextBox();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.btnPersoEnreg = new System.Windows.Forms.Button();
			this.btnPersoAnnuler = new System.Windows.Forms.Button();
			this.grbAbsence = new System.Windows.Forms.GroupBox();
			this.lsbAbsence = new System.Windows.Forms.ListBox();
			this.btnAbsAjout = new System.Windows.Forms.Button();
			this.btnAbsSuppr = new System.Windows.Forms.Button();
			this.grbAbsModif = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbMotifs = new System.Windows.Forms.ComboBox();
			this.dtpDateFin = new System.Windows.Forms.DateTimePicker();
			this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
			this.btnAbsEnreg = new System.Windows.Forms.Button();
			this.btnAbsAnnuler = new System.Windows.Forms.Button();
			this.grbPersonnel.SuspendLayout();
			this.grbPersoModif.SuspendLayout();
			this.grbAbsence.SuspendLayout();
			this.grbAbsModif.SuspendLayout();
			this.SuspendLayout();
			// 
			// grbPersonnel
			// 
			this.grbPersonnel.Controls.Add(this.lsbPersonnel);
			this.grbPersonnel.Controls.Add(this.btnPersoAjout);
			this.grbPersonnel.Controls.Add(this.btnPersoSuppr);
			this.grbPersonnel.Location = new System.Drawing.Point(12, 12);
			this.grbPersonnel.Name = "grbPersonnel";
			this.grbPersonnel.Size = new System.Drawing.Size(249, 318);
			this.grbPersonnel.TabIndex = 0;
			this.grbPersonnel.TabStop = false;
			this.grbPersonnel.Text = "Personnel";
			// 
			// lsbPersonnel
			// 
			this.lsbPersonnel.FormattingEnabled = true;
			this.lsbPersonnel.Location = new System.Drawing.Point(6, 19);
			this.lsbPersonnel.Name = "lsbPersonnel";
			this.lsbPersonnel.Size = new System.Drawing.Size(237, 264);
			this.lsbPersonnel.TabIndex = 2;
			this.lsbPersonnel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LsbPersonnel_MouseDoubleClick);
			// 
			// btnPersoAjout
			// 
			this.btnPersoAjout.Location = new System.Drawing.Point(158, 289);
			this.btnPersoAjout.Name = "btnPersoAjout";
			this.btnPersoAjout.Size = new System.Drawing.Size(85, 23);
			this.btnPersoAjout.TabIndex = 1;
			this.btnPersoAjout.Text = "Ajouter";
			this.btnPersoAjout.UseVisualStyleBackColor = true;
			this.btnPersoAjout.Click += new System.EventHandler(this.BtnPersoAjout_Click);
			// 
			// btnPersoSuppr
			// 
			this.btnPersoSuppr.Location = new System.Drawing.Point(6, 289);
			this.btnPersoSuppr.Name = "btnPersoSuppr";
			this.btnPersoSuppr.Size = new System.Drawing.Size(85, 23);
			this.btnPersoSuppr.TabIndex = 0;
			this.btnPersoSuppr.Text = "Supprimer";
			this.btnPersoSuppr.UseVisualStyleBackColor = true;
			this.btnPersoSuppr.Click += new System.EventHandler(this.BtnPersoSuppr_Click);
			// 
			// grbPersoModif
			// 
			this.grbPersoModif.Controls.Add(this.label5);
			this.grbPersoModif.Controls.Add(this.cmbServices);
			this.grbPersoModif.Controls.Add(this.label4);
			this.grbPersoModif.Controls.Add(this.label3);
			this.grbPersoModif.Controls.Add(this.label2);
			this.grbPersoModif.Controls.Add(this.label1);
			this.grbPersoModif.Controls.Add(this.txtMail);
			this.grbPersoModif.Controls.Add(this.txtTel);
			this.grbPersoModif.Controls.Add(this.txtPrenom);
			this.grbPersoModif.Controls.Add(this.txtNom);
			this.grbPersoModif.Controls.Add(this.btnPersoEnreg);
			this.grbPersoModif.Controls.Add(this.btnPersoAnnuler);
			this.grbPersoModif.Enabled = false;
			this.grbPersoModif.Location = new System.Drawing.Point(267, 12);
			this.grbPersoModif.Name = "grbPersoModif";
			this.grbPersoModif.Size = new System.Drawing.Size(263, 181);
			this.grbPersoModif.TabIndex = 1;
			this.grbPersoModif.TabStop = false;
			this.grbPersoModif.Text = "Modifications Personnel";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 126);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 13;
			this.label5.Text = "Service";
			// 
			// cmbServices
			// 
			this.cmbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbServices.FormattingEnabled = true;
			this.cmbServices.Location = new System.Drawing.Point(79, 123);
			this.cmbServices.Name = "cmbServices";
			this.cmbServices.Size = new System.Drawing.Size(176, 21);
			this.cmbServices.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Adresse Mail";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Telephone";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Prenom";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Nom";
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(79, 97);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(176, 20);
			this.txtMail.TabIndex = 7;
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(79, 71);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(176, 20);
			this.txtTel.TabIndex = 6;
			// 
			// txtPrenom
			// 
			this.txtPrenom.Location = new System.Drawing.Point(79, 45);
			this.txtPrenom.Name = "txtPrenom";
			this.txtPrenom.Size = new System.Drawing.Size(176, 20);
			this.txtPrenom.TabIndex = 5;
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(79, 19);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(176, 20);
			this.txtNom.TabIndex = 4;
			// 
			// btnPersoEnreg
			// 
			this.btnPersoEnreg.Location = new System.Drawing.Point(170, 152);
			this.btnPersoEnreg.Name = "btnPersoEnreg";
			this.btnPersoEnreg.Size = new System.Drawing.Size(85, 23);
			this.btnPersoEnreg.TabIndex = 3;
			this.btnPersoEnreg.Text = "Enregistrer";
			this.btnPersoEnreg.UseVisualStyleBackColor = true;
			this.btnPersoEnreg.Click += new System.EventHandler(this.BtnPersoEnreg_Click);
			// 
			// btnPersoAnnuler
			// 
			this.btnPersoAnnuler.Location = new System.Drawing.Point(79, 152);
			this.btnPersoAnnuler.Name = "btnPersoAnnuler";
			this.btnPersoAnnuler.Size = new System.Drawing.Size(85, 23);
			this.btnPersoAnnuler.TabIndex = 2;
			this.btnPersoAnnuler.Text = "Annuler";
			this.btnPersoAnnuler.UseVisualStyleBackColor = true;
			this.btnPersoAnnuler.Click += new System.EventHandler(this.BtnPersoAnnuler_Click);
			// 
			// grbAbsence
			// 
			this.grbAbsence.Controls.Add(this.lsbAbsence);
			this.grbAbsence.Controls.Add(this.btnAbsAjout);
			this.grbAbsence.Controls.Add(this.btnAbsSuppr);
			this.grbAbsence.Location = new System.Drawing.Point(536, 12);
			this.grbAbsence.Name = "grbAbsence";
			this.grbAbsence.Size = new System.Drawing.Size(249, 318);
			this.grbAbsence.TabIndex = 2;
			this.grbAbsence.TabStop = false;
			this.grbAbsence.Text = "Absence";
			// 
			// lsbAbsence
			// 
			this.lsbAbsence.FormattingEnabled = true;
			this.lsbAbsence.Location = new System.Drawing.Point(6, 19);
			this.lsbAbsence.Name = "lsbAbsence";
			this.lsbAbsence.Size = new System.Drawing.Size(237, 264);
			this.lsbAbsence.TabIndex = 4;
			this.lsbAbsence.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LsbAbsence_MouseDoubleClick);
			// 
			// btnAbsAjout
			// 
			this.btnAbsAjout.Location = new System.Drawing.Point(158, 289);
			this.btnAbsAjout.Name = "btnAbsAjout";
			this.btnAbsAjout.Size = new System.Drawing.Size(85, 23);
			this.btnAbsAjout.TabIndex = 3;
			this.btnAbsAjout.Text = "Ajouter";
			this.btnAbsAjout.UseVisualStyleBackColor = true;
			this.btnAbsAjout.Click += new System.EventHandler(this.BtnAbsAjout_Click);
			// 
			// btnAbsSuppr
			// 
			this.btnAbsSuppr.Location = new System.Drawing.Point(6, 289);
			this.btnAbsSuppr.Name = "btnAbsSuppr";
			this.btnAbsSuppr.Size = new System.Drawing.Size(85, 23);
			this.btnAbsSuppr.TabIndex = 2;
			this.btnAbsSuppr.Text = "Supprimer";
			this.btnAbsSuppr.UseVisualStyleBackColor = true;
			this.btnAbsSuppr.Click += new System.EventHandler(this.BtnAbsSuppr_Click);
			// 
			// grbAbsModif
			// 
			this.grbAbsModif.Controls.Add(this.label8);
			this.grbAbsModif.Controls.Add(this.label7);
			this.grbAbsModif.Controls.Add(this.label6);
			this.grbAbsModif.Controls.Add(this.cmbMotifs);
			this.grbAbsModif.Controls.Add(this.dtpDateFin);
			this.grbAbsModif.Controls.Add(this.dtpDateDebut);
			this.grbAbsModif.Controls.Add(this.btnAbsEnreg);
			this.grbAbsModif.Controls.Add(this.btnAbsAnnuler);
			this.grbAbsModif.Enabled = false;
			this.grbAbsModif.Location = new System.Drawing.Point(267, 199);
			this.grbAbsModif.Name = "grbAbsModif";
			this.grbAbsModif.Size = new System.Drawing.Size(263, 131);
			this.grbAbsModif.TabIndex = 3;
			this.grbAbsModif.TabStop = false;
			this.grbAbsModif.Text = "Modifications Absence";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 74);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Motif";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 51);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "Date Fin";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 25);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Date Debut";
			// 
			// cmbMotifs
			// 
			this.cmbMotifs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMotifs.FormattingEnabled = true;
			this.cmbMotifs.Location = new System.Drawing.Point(79, 71);
			this.cmbMotifs.Name = "cmbMotifs";
			this.cmbMotifs.Size = new System.Drawing.Size(176, 21);
			this.cmbMotifs.TabIndex = 7;
			// 
			// dtpDateFin
			// 
			this.dtpDateFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDateFin.Location = new System.Drawing.Point(79, 45);
			this.dtpDateFin.Name = "dtpDateFin";
			this.dtpDateFin.Size = new System.Drawing.Size(176, 20);
			this.dtpDateFin.TabIndex = 6;
			// 
			// dtpDateDebut
			// 
			this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDateDebut.Location = new System.Drawing.Point(79, 19);
			this.dtpDateDebut.Name = "dtpDateDebut";
			this.dtpDateDebut.Size = new System.Drawing.Size(176, 20);
			this.dtpDateDebut.TabIndex = 5;
			// 
			// btnAbsEnreg
			// 
			this.btnAbsEnreg.Location = new System.Drawing.Point(170, 98);
			this.btnAbsEnreg.Name = "btnAbsEnreg";
			this.btnAbsEnreg.Size = new System.Drawing.Size(85, 23);
			this.btnAbsEnreg.TabIndex = 4;
			this.btnAbsEnreg.Text = "Enregistrer";
			this.btnAbsEnreg.UseVisualStyleBackColor = true;
			this.btnAbsEnreg.Click += new System.EventHandler(this.BtnAbsEnreg_Click);
			// 
			// btnAbsAnnuler
			// 
			this.btnAbsAnnuler.Location = new System.Drawing.Point(79, 98);
			this.btnAbsAnnuler.Name = "btnAbsAnnuler";
			this.btnAbsAnnuler.Size = new System.Drawing.Size(85, 23);
			this.btnAbsAnnuler.TabIndex = 3;
			this.btnAbsAnnuler.Text = "Annuler";
			this.btnAbsAnnuler.UseVisualStyleBackColor = true;
			this.btnAbsAnnuler.Click += new System.EventHandler(this.BtnAbsAnnuler_Click);
			// 
			// FrmPersonnel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 338);
			this.Controls.Add(this.grbAbsModif);
			this.Controls.Add(this.grbAbsence);
			this.Controls.Add(this.grbPersoModif);
			this.Controls.Add(this.grbPersonnel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmPersonnel";
			this.Text = "Personnel";
			this.grbPersonnel.ResumeLayout(false);
			this.grbPersoModif.ResumeLayout(false);
			this.grbPersoModif.PerformLayout();
			this.grbAbsence.ResumeLayout(false);
			this.grbAbsModif.ResumeLayout(false);
			this.grbAbsModif.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grbPersonnel;
		private System.Windows.Forms.GroupBox grbPersoModif;
		private System.Windows.Forms.GroupBox grbAbsence;
		private System.Windows.Forms.GroupBox grbAbsModif;
		private System.Windows.Forms.Button btnPersoAjout;
		private System.Windows.Forms.Button btnPersoSuppr;
		private System.Windows.Forms.Button btnAbsAjout;
		private System.Windows.Forms.Button btnAbsSuppr;
		private System.Windows.Forms.Button btnPersoAnnuler;
		private System.Windows.Forms.Button btnPersoEnreg;
		private System.Windows.Forms.Button btnAbsEnreg;
		private System.Windows.Forms.Button btnAbsAnnuler;
		private System.Windows.Forms.ListBox lsbPersonnel;
		private System.Windows.Forms.ListBox lsbAbsence;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbServices;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMail;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.TextBox txtPrenom;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbMotifs;
		private System.Windows.Forms.DateTimePicker dtpDateFin;
		private System.Windows.Forms.DateTimePicker dtpDateDebut;
	}
}

