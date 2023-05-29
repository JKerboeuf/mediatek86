using MediaTek86.model;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
	/// <summary>
	/// Classe concernant l'acces à la table service de la bdd
	/// </summary>
	public class AccessService
	{
		private readonly Access access = null;

		/// <summary>
		/// Constructeur de l'acces à la table service
		/// </summary>
		public AccessService()
		{
			access = Access.GetInstance();
		}

		/// <summary>
		/// Méthode permettant d'obtenir la liste des services éxistant dans la bdd
		/// </summary>
		/// <returns>la liste des services</returns>
		public List<Service> GetLesServices()
		{
			List<Service> lesServices = new List<Service>();
			if (access.Manager != null)
			{
				string req = "select * from service order by nom;";
				try
				{
					List<object[]> records = access.Manager.ReqSelect(req);
					if (records != null)
					{
						lesServices = records.ConvertAll(new Converter<object[], Service>(ConvertService));
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					Environment.Exit(0);
				}
			}
			return lesServices;
		}

		/// <summary>
		/// Convertisseur de la ligne d'objets obtenu de la bdd en service
		/// </summary>
		/// <param name="service">La ligne issu de la bdd</param>
		/// <returns>Le service créé grâce aux information de la bdd</returns>
		private Service ConvertService(object[] service)
		{
			return new Service((int)service[0], (string)service[1]);
		}
	}
}
