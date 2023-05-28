using Personnel.dal;
using Personnel.model;

namespace Personnel.control
{
	public class FrmConnexionController
	{
		private readonly AccessResponsable accessResponsable;

		public FrmConnexionController()
		{
			accessResponsable = new AccessResponsable();
		}

		public bool ControleAuthentification(Responsable responsable)
		{
			return accessResponsable.ControleAuthentification(responsable);
		}
	}
}
