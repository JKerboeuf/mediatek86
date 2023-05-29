using Org.BouncyCastle.Utilities.Collections;
using Personnel.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms.Design;

namespace Personnel.dal
{
	/// <summary>
	/// Classe concernant l'acces à la table personnel de la bdd
	/// </summary>
	public class AccessPersonnel
	{
		private readonly Access access = null;

		/// <summary>
		/// Constructeur de l'acces à la table personnel
		/// </summary>
		public AccessPersonnel()
		{
			access = Access.GetInstance();
		}

		/// <summary>
		/// Convertisseur de la ligne d'objets obtenu de la bdd en personnel
		/// </summary>
		/// <param name="personnel">La ligne issu de la bdd</param>
		/// <returns>Le personnel créé grâce aux information de la bdd</returns>
		private model.Personnel ConvertPersonnel(object[] personnel)
		{
			Service service = new Service(
				(int)personnel[5],
				(string)personnel[6]
			);
			return new model.Personnel(
				(int)personnel[0],
				service,
				(string)personnel[1],
				(string)personnel[2],
				(string)personnel[3],
				(string)personnel[4]
			);
		}

		/// <summary>
		/// Méthode permettant d'obtenir la liste des personnels éxistant dans la bdd
		/// </summary>
		/// <returns>la liste des personnels</returns>
		public List<model.Personnel> GetLesPersonnels()
		{
			List<model.Personnel> lesPersonnels = new List<model.Personnel>();
			if (access.Manager != null)
			{
				string req = "select p.idpersonnel, p.nom, p.prenom, p.tel, p.mail, s.idservice, s.nom " +
					"from personnel p join service s on (p.idservice = s.idservice) " +
					"order by p.nom, p.prenom;";
				try
				{
					List<object[]> records = access.Manager.ReqSelect(req);
					if (records != null)
					{
						lesPersonnels = records.ConvertAll(new Converter<object[], model.Personnel>(ConvertPersonnel));
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					Environment.Exit(0);
				}
			}
			return lesPersonnels;
		}

		/// <summary>
		/// Méthode permettant d'ajouter un personnel dans la bdd
		/// </summary>
		/// <param name="personnel">le personnel à ajouter</param>
		public void AddPersonnel(model.Personnel personnel)
		{
			if (access.Manager != null)
			{
				string req = "insert into personnel " +
					"(idpersonnel, idservice, nom, prenom, tel, mail) " +
					"VALUES (NULL, @idservice, @nom, @prenom, @tel, @mail);";
				Dictionary<string, object> parameters = new Dictionary<string, object>
				{
					{ "@idservice", personnel.Service.Id },
					{ "@nom", personnel.Nom },
					{ "@prenom", personnel.Prenom },
					{ "@tel", personnel.Tel },
					{ "@mail", personnel.Mail }
				};
				try
				{
					access.Manager.ReqUpdate(req, parameters);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					Environment.Exit(0);
				}
			}
		}

		/// <summary>
		/// Méthode permettant de modifier un personnel dans la bdd
		/// </summary>
		/// <param name="personnel">le personnel modifié</param>
		/// <param name="idPersonnelModif">l'id du personnel à modifier</param>
		public void ModifPersonnel(model.Personnel personnel, int idPersonnelModif)
		{
			if (access.Manager != null)
			{
				string req = "update personnel " +
					"set idservice = @idservice, " +
					"nom = @nom, " +
					"prenom = @prenom, " +
					"tel = @tel, " +
					"mail = @mail " +
					"where personnel.idpersonnel = @idpersonnel;";
				Dictionary<string, object> parameters = new Dictionary<string, object>
				{
					{ "@idpersonnel", idPersonnelModif },
					{ "@idservice", personnel.Service.Id },
					{ "@nom", personnel.Nom },
					{ "@prenom", personnel.Prenom },
					{ "@tel", personnel.Tel },
					{ "@mail", personnel.Mail }
				};
				try
				{
					access.Manager.ReqUpdate(req, parameters);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					Environment.Exit(0);
				}
			}
		}

		/// <summary>
		/// Méthode permettant de supprimer un personnel de la bdd
		/// </summary>
		/// <param name="personnel">le personnel à supprimer</param>
		public void DeletePersonnel(model.Personnel personnel)
		{
			if (access.Manager != null)
			{
				string reqPers = "delete from personnel p " +
					"where p.idpersonnel = @idpersonnel;";
				string reqAbs = "delete from absence a " +
					"where a.idpersonnel = @idpersonnel;";
				Dictionary<string, object> parameters = new Dictionary<string, object>
				{
					{ "@idpersonnel", personnel.Id }
				};
				try
				{
					access.Manager.ReqUpdate(reqAbs, parameters);
					access.Manager.ReqUpdate(reqPers, parameters);
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					Environment.Exit(0);
				}
			}
		}
	}
}
