using System.Collections.Generic;
using System;
using Personnel.model;

namespace Personnel.dal
{
	public class AccessResponsable
	{
		private readonly Access access = null;

		public AccessResponsable()
		{
			access = Access.GetInstance();
		}

		public bool ControleAuthentification(Responsable responsable)
		{
			if (access.Manager != null)
			{
				string req = "select * from responsable r " +
					"where r.login = @login and r.pwd = SHA2(@mdp, 256)";
				Dictionary<string, object> parameters = new Dictionary<string, object>
				{
					{ "@login", responsable.Login },
					{ "@mdp", responsable.Pwd }
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
