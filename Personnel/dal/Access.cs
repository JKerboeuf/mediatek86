using Personnel.bddmanager;
using System;

namespace Personnel.dal
{
	public class Access
	{
		private static Access instance = null;
		private static readonly string connectString = "server=localhost;user id=MediaTek86admin;Password=MediaTek86admin;database=mediatek86;SslMode=none";
		public BddManager Manager { get; }

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
