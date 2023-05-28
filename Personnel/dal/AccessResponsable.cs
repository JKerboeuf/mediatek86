using System.Collections.Generic;
using System;

namespace Personnel.dal
{
	public class AccessResponsable
	{
		private readonly Access access = null;

		public AccessResponsable()
		{
			access = Access.GetInstance();
		}

		public bool ControleAuthentification(string login, string mdp)
		{
			if (access.Manager != null)
			{
				string req = "select * from responsable r " +
					"where r.login = @login and r.pwd = SHA2(@mdp, 256)";
				Dictionary<string, object> parameters = new Dictionary<string, object>
				{
					{ "@login", login },
					{ "@mdp", mdp }
				};
				try
				{
					List<object[]> records = access.Manager.ReqSelect(req, parameters);
					if (records != null)
					{
						return (records.Count > 0);
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					Environment.Exit(0);
				}
			}
			return false;
		}
	}
}
