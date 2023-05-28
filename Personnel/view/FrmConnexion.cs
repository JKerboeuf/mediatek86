using Personnel.control;
using System;
using System.Windows.Forms;

namespace Personnel.view
{
	public partial class FrmConnexion : Form
	{
		private readonly FrmConnexionController controller;

		public FrmConnexion()
		{
			InitializeComponent();
			controller = new FrmConnexionController();
		}

		private void BtnConnect_Click(object sender, EventArgs e)
		{
			string login = txtIdentifiant.Text;
			string mdp = txtMdp.Text;
			if (login != string.Empty && mdp != string.Empty)
			{
				if (controller.ControleAuthentification(login, mdp))
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
