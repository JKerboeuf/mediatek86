using Personnel.dal;
using Personnel.model;

namespace Personnel.control
{
	/// <summary>
	/// Classe du controller de la fenetre de connexion
	/// </summary>
	public class FrmConnexionController
	{
		/// <summary>
		/// Instance du controlleur
		/// </summary>
		private readonly AccessResponsable accessResponsable;

		/// <summary>
		/// Constructeur du controlleur
		/// </summary>
		public FrmConnexionController()
		{
			accessResponsable = new AccessResponsable();
		}

		/// <summary>
		/// Vérifie si les identifiants entrés sont bien ceux du responsable
		/// </summary>
		/// <param name="responsable">le responsable à tester</param>
		/// <returns>vrai si les identifiants sont correctes, sinon faux</returns>
		public bool ControleAuthentification(Responsable responsable)
		{
			return accessResponsable.ControleAuthentification(responsable);
		}
	}
}
