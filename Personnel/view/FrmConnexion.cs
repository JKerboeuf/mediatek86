using Personnel.control;
using Personnel.model;
using System;
using System.Windows.Forms;

namespace Personnel.view
{
	/// <summary>
	/// Classe de la fenetre de connection
	/// </summary>
	public partial class FrmConnexion : Form
	{
		private readonly FrmConnexionController controller;

		/// <summary>
		/// constructeur de la fenetre de connection
		/// </summary>
		public FrmConnexion()
		{
			InitializeComponent();
			controller = new FrmConnexionController();
		}

		/// <summary>
		/// Méthode évenementielle sur le clic du bouton permettant de se connecter
		/// Enclenche la vérification des identifiants pour la connection
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnConnect_Click(object sender, EventArgs e)
		{
			string login = txtIdentifiant.Text;
			string mdp = txtMdp.Text;
			if (login != string.Empty && mdp != string.Empty)
			{
				Responsable responsable = new Responsable(login, mdp);
				if (controller.ControleAuthentification(responsable))
				{
					new FrmPersonnel().ShowDialog();
				}
				else
				{
					MessageBox.Show("Utilisateur incorrecte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Tous les champs doivent être remplies", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
