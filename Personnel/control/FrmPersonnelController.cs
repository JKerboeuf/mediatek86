using Personnel.dal;

namespace Personnel.control
{
	public class FrmPersonnelController
	{
		private readonly AccessAbsence accessAbsence;
		private readonly AccessPersonnel accessPersonnel;

		public FrmPersonnelController()
		{
			accessAbsence = new AccessAbsence();
			accessPersonnel = new AccessPersonnel();
		}
	}
}
