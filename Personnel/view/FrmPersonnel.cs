using Personnel.control;
using Personnel.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Personnel.view
{
	public partial class FrmPersonnel : Form
	{
		private readonly FrmPersonnelController controller;
		private readonly BindingSource bdgPersonnels = new BindingSource();
		private readonly BindingSource bdgAbsences = new BindingSource();
		private readonly BindingSource bdgServices = new BindingSource();
		private readonly BindingSource bdgMotifs = new BindingSource();

		public FrmPersonnel()
		{
			InitializeComponent();
			controller = new FrmPersonnelController();
			RemplirListeServices();
			RemplirListeMotifs();
			RemplirListePersonnels();
		}

		private void RemplirListePersonnels()
		{
			List<model.Personnel> lesPersonnels = controller.GetLesPersonnels();
			bdgPersonnels.DataSource = lesPersonnels;
			lsbPersonnel.DataSource = bdgPersonnels;
		}

		private void RemplirListeMotifs()
		{
			List<Motif> lesMotifs = controller.GetLesMotifs();
			bdgMotifs.DataSource = lesMotifs;
			cmbMotifs.DataSource = bdgMotifs;
		}

		private void RemplirListeServices()
		{
			List<Service> lesServices = controller.GetLesServices();
			bdgServices.DataSource = lesServices;
			cmbServices.DataSource = bdgServices;
		}

		private void RemplirListeAbsences(model.Personnel personnel)
		{
			List<Absence> lesAbsences = controller.GetLesAbsences(personnel);
			bdgAbsences.DataSource = lesAbsences;
			lsbAbsence.DataSource = bdgAbsences;
		}

		private void RemplirModifPersonnel(model.Personnel personnel)
		{
			txtNom.Text = personnel.Nom;
			txtPrenom.Text = personnel.Prenom;
			txtTel.Text = personnel.Tel;
			txtMail.Text = personnel.Mail;
			cmbServices.SelectedIndex = cmbServices.FindStringExact(personnel.Service.ToString());
			grbPersoModif.Enabled = true;
		}

		private void RemplirModifAbsence(Absence absence)
		{
			dtpDateDebut.Value = absence.DateDebut;
			dtpDateFin.Value = absence.DateFin;
			cmbMotifs.SelectedIndex = cmbMotifs.FindStringExact(absence.Motif.ToString());
			grbAbsModif.Enabled = true;
		}

		private void LsbPersonnel_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (lsbPersonnel.SelectedIndex >= 0)
			{
				model.Personnel personnel = controller.GetLesPersonnels()[lsbPersonnel.SelectedIndex];
				RemplirListeAbsences(personnel);
				RemplirModifPersonnel(personnel);
			}
		}

		private void BtnPersoSuppr_Click(object sender, EventArgs e)
		{
			// Method intentionally left empty.
		}

		private void BtnPersoAjout_Click(object sender, EventArgs e)
		{
			// Method intentionally left empty.
		}

		private void BtnPersoAnnuler_Click(object sender, EventArgs e)
		{
			grbPersoModif.Enabled = false;
			txtNom.Text = string.Empty;
			txtPrenom.Text = string.Empty;
			txtTel.Text = string.Empty;
			txtMail.Text = string.Empty;
			cmbServices.SelectedIndex = 0;
		}

		private void BtnPersoEnreg_Click(object sender, EventArgs e)
		{
			// Method intentionally left empty.
		}

		private void LsbAbsence_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (lsbAbsence.SelectedIndex >= 0)
			{
				model.Personnel personnel = controller.GetLesPersonnels()[lsbPersonnel.SelectedIndex];
				Absence absence = controller.GetLesAbsences(personnel)[lsbAbsence.SelectedIndex];
				RemplirModifAbsence(absence);
			}
		}

		private void BtnAbsSuppr_Click(object sender, EventArgs e)
		{
			// Method intentionally left empty.
		}

		private void BtnAbsAjout_Click(object sender, EventArgs e)
		{
			// Method intentionally left empty.
		}

		private void BtnAbsAnnuler_Click(object sender, EventArgs e)
		{
			grbAbsModif.Enabled = false;
			dtpDateDebut.Value = DateTime.Now;
			dtpDateFin.Value = DateTime.Now;
			cmbMotifs.SelectedIndex = 0;
		}

		private void BtnAbsEnreg_Click(object sender, EventArgs e)
		{
			// Method intentionally left empty.
		}
	}
}
