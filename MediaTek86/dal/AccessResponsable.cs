using MediaTek86.model;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
	/// <summary>
	/// Classe concernant l'acces à la table responsable de la bdd
	/// </summary>
	public class AccessResponsable
	{
		private readonly Access access = null;

		/// <summary>
		/// Constructeur de l'acces à la table responsable
		/// </summary>
		public AccessResponsable()
		{
			access = Access.GetInstance();
		}

		/// <summary>
		/// Vérifie si les identifiants entrés sont bien ceux du responsable
		/// </summary>
		/// <param name="responsable">le responsable à tester</param>
		/// <returns>vrai si les identifiants sont correctes, sinon faux</returns>
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
