using MediaTek86.model;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
	/// <summary>
	/// Classe concernant l'acces à la table motif de la bdd
	/// </summary>
	public class AccessMotif
	{
		private readonly Access access = null;

		/// <summary>
		/// Constructeur de l'acces à la table motif
		/// </summary>
		public AccessMotif()
		{
			access = Access.GetInstance();
		}

		/// <summary>
		/// Méthode permettant d'obtenir la liste des motifs éxistant dans la bdd
		/// </summary>
		/// <returns>la liste des motifs</returns>
		public List<Motif> GetLesMotifs()
		{
			List<Motif> lesMotifs = new List<Motif>();
			if (access.Manager != null)
			{
				string req = "select * from motif order by libelle;";
				try
				{
					List<object[]> records = access.Manager.ReqSelect(req);
					if (records != null)
					{
						lesMotifs = records.ConvertAll(new Converter<object[], Motif>(ConvertService));
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					Environment.Exit(0);
				}
			}
			return lesMotifs;
		}

		/// <summary>
		/// Convertisseur de la ligne d'objets obtenu de la bdd en motif
		/// </summary>
		/// <param name="motif">La ligne issu de la bdd</param>
		/// <returns>Le motif créé grâce aux information de la bdd</returns>
		private Motif ConvertService(object[] motif)
		{
			return new Motif((int)motif[0], (string)motif[1]);
		}
	}
}
