using MediaTek86.model;
using System;
using System.Collections.Generic;

namespace MediaTek86.dal
{
	/// <summary>
	/// Classe concernant l'acces à la table absence de la bdd
	/// </summary>
	public class AccessAbsence
	{
		private readonly Access access = null;

		/// <summary>
		/// Constructeur de l'acces à la table absence
		/// </summary>
		public AccessAbsence()
		{
			access = Access.GetInstance();
		}

		/// <summary>
		/// Convertisseur de la ligne d'objets obtenu de la bdd en absence
		/// </summary>
		/// <param name="absence">La ligne issu de la bdd</param>
		/// <returns>L'absence créé grâce aux information de la bdd</returns>
		private Absence ConvertAbsence(object[] absence)
		{
			Service service = new Service(
				(int)absence[9],
				(string)absence[10]
			);
			Personnel personnel = new Personnel(
				(int)absence[4],
				service,
				(string)absence[5],
				(string)absence[6],
				(string)absence[7],
				(string)absence[8]
			);
			Motif motif = new Motif(
				(int)absence[2],
				(string)absence[3]
			);
			return new Absence(
				personnel,
				motif,
				(DateTime)absence[0],
				(DateTime)absence[1]
			);
		}

		/// <summary>
		/// Méthode permettant d'obtenir la liste des absences éxistantes dans la bdd
		/// </summary>
		/// <param name="personnel">Le personnel dont il faut récuperer les absences</param>
		/// <returns>la liste des absences</returns>
		public List<Absence> GetLesAbsences(Personnel personnel)
		{
			List<Absence> lesAbsences = new List<Absence>();
			if (access.Manager != null)
			{
				string req = "select a.datedebut, a.datefin, m.idmotif, m.libelle, p.idpersonnel, p.nom, p.prenom, p.tel, p.mail, s.idservice, s.nom " +
					"from absence a " +
					"join personnel p on a.idpersonnel = p.idpersonnel " +
					"join service s on p.idservice = s.idservice " +
					"join motif m on a.idmotif = m.idmotif " +
					"where p.idpersonnel = @id " +
					"order by a.datedebut;";
				Dictionary<string, object> parameters = new Dictionary<string, object>
				{
					{ "@id", personnel.Id }
				};
				try
				{
					List<object[]> records = access.Manager.ReqSelect(req, parameters);
					if (records != null)
					{
						lesAbsences = records.ConvertAll(new Converter<object[], Absence>(ConvertAbsence));
					}
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					Environment.Exit(0);
				}
			}
			return lesAbsences;
		}

		/// <summary>
		/// Méthode permettant d'ajouter une absence dans la bdd
		/// </summary>
		/// <param name="absence">l'absence à ajouter</param>
		/// <param name="idPersonnel">l'id du personnel concerné par l'absence</param>
		public void AddAbsence(Absence absence, int idPersonnel)
		{
			if (access.Manager != null)
			{
				string req = "insert into absence " +
					"(idpersonnel, datedebut, idmotif, datefin) " +
					"values (@idpersonnel, @datedebut, @idmotif, @datefin);";
				Dictionary<string, object> parameters = new Dictionary<string, object>
				{
					{ "@idpersonnel", idPersonnel },
					{ "@idmotif", absence.Motif.Id },
					{ "@datedebut", absence.DateDebut },
					{ "@datefin", absence.DateFin },
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
		/// Méthode permettant de modifier une absence dans la bdd
		/// </summary>
		/// <param name="absence">l'absence modifié</param>
		/// <param name="idPersonnelModif">l'id du personnel concerné par l'absence</param>
		/// <param name="idDateModif">la date de debut de l'absence à modifier</param>
		public void ModifAbsence(Absence absence, int idPersonnelModif, DateTime idDateModif)
		{
			if (access.Manager != null)
			{
				string req = "update absence " +
					"set datedebut = @datedebut, " +
					"idmotif = @idmotif, " +
					"datefin = @datefin " +
					"where absence.idpersonnel = @idpersonnel " +
					"and absence.datedebut = @datemodif;";
				Dictionary<string, object> parameters = new Dictionary<string, object>
				{
					{ "@idmotif", absence.Motif.Id },
					{ "@datedebut", absence.DateDebut.ToString("yyyy-MM-dd HH:mm:ss") },
					{ "@datefin", absence.DateFin.ToString("yyyy-MM-dd HH:mm:ss") },
					{ "@idpersonnel", idPersonnelModif },
					{ "@datemodif", idDateModif.ToString("yyyy-MM-dd HH:mm:ss") }
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
		/// Méthode permettant de supprimer une absence dans la bdd
		/// </summary>
		/// <param name="absence">l'absence à supprimer</param>
		public void DeleteAbsence(Absence absence)
		{
			if (access.Manager != null)
			{
				string req = "delete from absence a " +
					"where a.idpersonnel = @idpersonnel " +
					"and a.datedebut = @datedebut;";
				Dictionary<string, object> parameters = new Dictionary<string, object>
				{
					{ "@idpersonnel", absence.Personnel.Id },
					{ "@datedebut", absence.DateDebut.ToString("yyyy-MM-dd HH:mm:ss") }
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
	}
}
