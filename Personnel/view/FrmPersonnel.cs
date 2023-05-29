using Personnel.control;
using Personnel.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Personnel.view
{
	/// <summary>
	/// Class de la fenetre principale
	/// </summary>
	public partial class FrmPersonnel : Form
	{
		private readonly FrmPersonnelController controller;
		private readonly BindingSource bdgPersonnels = new BindingSource();
		private readonly BindingSource bdgAbsences = new BindingSource();
		private readonly BindingSource bdgServices = new BindingSource();
		private readonly BindingSource bdgMotifs = new BindingSource();

		/// <summary>
		/// Constructeur de la fenetre principale
		/// </summary>
		public FrmPersonnel()
		{
			InitializeComponent();
			controller = new FrmPersonnelController();
			RemplirListeServices();
			RemplirListeMotifs();
			RemplirListePersonnels();
		}

		/// <summary>
		/// Rempli la ComboBox des motifs d'absence avec ceux disponibles dans la bdd
		/// </summary>
		private void RemplirListeMotifs()
		{
			List<Motif> lesMotifs = controller.GetLesMotifs();
			bdgMotifs.DataSource = lesMotifs;
			cmbMotifs.DataSource = bdgMotifs;
		}

		/// <summary>
		/// Rempli la ComboBox des services avec ceux disponibles dans la bdd
		/// </summary>
		private void RemplirListeServices()
		{
			List<Service> lesServices = controller.GetLesServices();
			bdgServices.DataSource = lesServices;
			cmbServices.DataSource = bdgServices;
		}

		/// <summary>
		/// Rempli la ListBox des personnels
		/// </summary>
		private void RemplirListePersonnels()
		{
			List<model.Personnel> lesPersonnels = controller.GetLesPersonnels();
			bdgPersonnels.DataSource = lesPersonnels;
			lsbPersonnel.DataSource = bdgPersonnels;
			grbPersonnel.Enabled = true;
		}

		/// <summary>
		/// Rempli la ListBox des absences
		/// </summary>
		/// <param name="personnel">le personnel dont il faut récuperer les absences</param>
		private void RemplirListeAbsences(model.Personnel personnel)
		{
			List<Absence> lesAbsences = controller.GetLesAbsences(personnel);
			bdgAbsences.DataSource = lesAbsences;
			lsbAbsence.DataSource = bdgAbsences;
			grbAbsence.Enabled = true;
			grbPersonnel.Enabled = true;
		}

		/// <summary>
		/// Rempli les informations d'un personnel dans la partie modification de personnel de la fenetre
		/// </summary>
		/// <param name="personnel">le personnel dont il faut afficher les informations</param>
		private void RemplirModifPersonnel(model.Personnel personnel)
		{
			ViderModifAbsence();
			txtNom.Text = personnel.Nom;
			txtPrenom.Text = personnel.Prenom;
			txtTel.Text = personnel.Tel;
			txtMail.Text = personnel.Mail;
			cmbServices.SelectedIndex = cmbServices.FindStringExact(personnel.Service.ToString());
			grbPersoModif.Enabled = true;
		}

		/// <summary>
		/// Remplis les informations d'une absence dans la partie modification d'absence de la fenetre
		/// </summary>
		/// <param name="absence">l'absence dont il faut afficher les informations</param>
		private void RemplirModifAbsence(Absence absence)
		{
			dtpDateDebut.Value = absence.DateDebut;
			dtpDateFin.Value = absence.DateFin;
			cmbMotifs.SelectedIndex = cmbMotifs.FindStringExact(absence.Motif.ToString());
			grbAbsModif.Enabled = true;
		}

		/// <summary>
		/// Vide les informations de la partie modification de personnel
		/// </summary>
		private void ViderModifPersonnel()
		{
			grbPersoModif.Enabled = false;
			txtNom.Text = string.Empty;
			txtPrenom.Text = string.Empty;
			txtTel.Text = string.Empty;
			txtMail.Text = string.Empty;
			cmbServices.SelectedIndex = 0;
		}

		/// <summary>
		/// Vide les informations de la partie modification d'absence
		/// </summary>
		private void ViderModifAbsence()
		{
			grbAbsModif.Enabled = false;
			dtpDateDebut.Value = DateTime.Now;
			dtpDateFin.Value = DateTime.Now;
			cmbMotifs.SelectedIndex = 0;
		}

		/// <summary>
		/// Verifie si les informations de la partie modification de personnel sont correctes
		/// </summary>
		/// <returns></returns>
		private bool CheckModifPerso()
		{
			if (txtNom.Text != string.Empty && txtPrenom.Text != string.Empty &&
				txtTel.Text != string.Empty && txtMail.Text != string.Empty &&
				cmbServices.SelectedIndex >= 0)
			{
				return true;
			}
			else
			{
				MessageBox.Show("Vous devez remplir tous les champs avant de pouvoir enregistrer !", "Champs incomplets", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		/// <summary>
		/// Verifie si les informations de la partie modification d'absence sont correctes
		/// </summary>
		/// <returns></returns>
		private bool CheckModifAbs()
		{
			if (dtpDateDebut.Value <= dtpDateFin.Value)
			{
				return true;
			}
			else
			{
				MessageBox.Show("La date de début ne peut pas être postérieure à la date de fin !", "Dates incorrectes", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		/// <summary>
		/// Méthode évenementielle sur le double clique dans la liste de personnel
		/// Récupère les informations du personnel sélectionné
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LsbPersonnel_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (lsbPersonnel.SelectedIndex >= 0)
			{
				model.Personnel personnel = controller.GetLesPersonnels()[lsbPersonnel.SelectedIndex];
				RemplirListeAbsences(personnel);
				RemplirModifPersonnel(personnel);
			}
		}

		/// <summary>
		/// Méthode évenementielle sur le clique du bouton de suppression de personnel
		/// Supprime le personnel sélectionné
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnPersoSuppr_Click(object sender, EventArgs e)
		{
			if (lsbPersonnel.SelectedIndex >= 0 &&
				MessageBox.Show("Voulez-vous vraiment supprimer ce personnel ?", "Supprimer un personnel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				model.Personnel personnel = controller.GetLesPersonnels()[lsbPersonnel.SelectedIndex];
				controller.DeletePersonnel(personnel);
				RemplirListePersonnels();
				personnel = controller.GetLesPersonnels()[lsbPersonnel.SelectedIndex];
				RemplirListeAbsences(personnel);
			}
		}

		/// <summary>
		/// Méthode évenementielle sur le clique du bouton d'ajout de personnel
		/// Ajoute un nouveau personnel
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnPersoAjout_Click(object sender, EventArgs e)
		{
			ViderModifPersonnel();
			ViderModifAbsence();
			grbPersoModif.Enabled = true;
			grbPersonnel.Enabled = false;
			grbAbsence.Enabled = false;
		}

		/// <summary>
		/// Méthode évenementielle sur le clique du bouton d'annulation de personnel
		/// Annule en vidant les information de la partie de modification de personnel
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnPersoAnnuler_Click(object sender, EventArgs e)
		{
			ViderModifPersonnel();
			grbPersonnel.Enabled = true;
		}

		/// <summary>
		/// Méthode évenementielle sur le clique du bouton d'enregistrement de personnel
		/// Enregistre les modifications du personnel
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnPersoEnreg_Click(object sender, EventArgs e)
		{
			if (CheckModifPerso())
			{
				Service service = controller.GetLesServices()[cmbServices.FindStringExact(cmbServices.Text)];
				model.Personnel newPersonnel = new model.Personnel(-1, service, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text);
				if (grbPersonnel.Enabled)
				{
					model.Personnel personnel = controller.GetLesPersonnels()[lsbPersonnel.SelectedIndex];
					newPersonnel.Id = personnel.Id;
					controller.ModifPersonnel(newPersonnel, personnel.Id);
				}
				else
				{
					controller.AddPersonnel(newPersonnel);
				}
				RemplirListePersonnels();
			}
		}

		/// <summary>
		/// Méthode évenementielle sur le double clique dans la liste des absences
		/// Récupère les informations de l'absence sélectionné
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LsbAbsence_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (lsbAbsence.SelectedIndex >= 0)
			{
				model.Personnel personnel = controller.GetLesPersonnels()[lsbPersonnel.SelectedIndex];
				Absence absence = controller.GetLesAbsences(personnel)[lsbAbsence.SelectedIndex];
				RemplirModifAbsence(absence);
			}
		}

		/// <summary>
		/// Méthode évenementielle sur le clique du bouton de suppression d'absence
		/// Supprime l'absence sélectionné
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAbsSuppr_Click(object sender, EventArgs e)
		{
			if (lsbAbsence.SelectedIndex >= 0 &&
				MessageBox.Show("Voulez-vous vraiment supprimer cette absence ?", "Supprimer une absence", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				model.Personnel personnel = controller.GetLesPersonnels()[lsbPersonnel.SelectedIndex];
				Absence absence = controller.GetLesAbsences(personnel)[lsbAbsence.SelectedIndex];
				controller.DeleteAbsence(absence);
				RemplirListeAbsences(personnel);
			}
		}

		/// <summary>
		/// Méthode évenementielle sur le clique du bouton d'ajout d'absence
		/// Ajoute une nouvelle absence
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAbsAjout_Click(object sender, EventArgs e)
		{
			ViderModifAbsence();
			grbAbsModif.Enabled = true;
			grbPersoModif.Enabled = false;
			grbPersonnel.Enabled = false;
			grbAbsence.Enabled = false;
		}

		/// <summary>
		/// Méthode évenementielle sur le clique du bouton d'annulation d'absence
		/// Annule en vidant les information de la partie de modification d'absence
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAbsAnnuler_Click(object sender, EventArgs e)
		{
			ViderModifAbsence();
			grbAbsence.Enabled = true;
			grbPersonnel.Enabled = true;
		}

		/// <summary>
		/// Méthode évenementielle sur le clique du bouton d'enregistrement d'absence
		/// Enregistre les modifications de l'absence
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAbsEnreg_Click(object sender, EventArgs e)
		{
			if (CheckModifAbs())
			{
				model.Personnel personnel = controller.GetLesPersonnels()[lsbPersonnel.SelectedIndex];
				Motif motif = controller.GetLesMotifs()[cmbMotifs.FindStringExact(cmbMotifs.Text)];
				Absence newAbsence = new Absence(personnel, motif, dtpDateDebut.Value, dtpDateFin.Value);
				if (grbPersonnel.Enabled)
				{
					Absence absence = controller.GetLesAbsences(personnel)[lsbAbsence.SelectedIndex];
					controller.ModifAbsence(newAbsence, personnel.Id, absence.DateDebut);
				}
				else
				{
					controller.AddAbsence(newAbsence, personnel.Id);
				}
				RemplirListeAbsences(personnel);
			}
		}
	}
}
