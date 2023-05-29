using Personnel.bddmanager;
using System;

namespace Personnel.dal
{
	/// <summary>
	/// Classe Singleton gérant l'acces à la bdd
	/// </summary>
	public class Access
	{
		private static Access instance = null;
		private static readonly string connectString = "server=localhost;user id=MediaTek86admin;Password=MediaTek86admin;database=mediatek86;SslMode=none";
		/// <summary>
		/// Instance du BddManager
		/// </summary>
		public BddManager Manager { get; }

		/// <summary>
		/// Constructeur privé récupérant l'instance du BddManager
		/// </summary>
		private Access()
		{
			try
			{
				Manager = BddManager.GetInstance(connectString);
			}
			catch
			{
				Environment.Exit(0);
			}
		}

		/// <summary>
		/// Getter sur l'instance de l'acces
		/// </summary>
		/// <returns></returns>
		public static Access GetInstance()
		{
			if (instance == null)
			{
				instance = new Access();
			}
			return instance;
		}
	}
}
