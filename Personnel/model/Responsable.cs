namespace Personnel.model
{
	/// <summary>
	/// Classe concernant le responable
	/// </summary>
	public class Responsable
	{
		/// <summary>
		/// Le login du responsable
		/// </summary>
		public string Login { get; set; }
		/// <summary>
		/// Le mot de passe du responsable
		/// </summary>
		public string Pwd { get; set; }

		/// <summary>
		/// Constructeur du responsable
		/// </summary>
		/// <param name="login">Le login du responsable</param>
		/// <param name="pwd">Le mot de passe du responsable</param>
		public Responsable(string login, string pwd)
		{
			Login = login;
			Pwd = pwd;
		}
	}
}
