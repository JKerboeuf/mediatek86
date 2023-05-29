using Personnel.model;
using System;
using System.Collections.Generic;

namespace Personnel.dal
{
	public class AccessAbsence
	{
		private readonly Access access = null;

		public AccessAbsence()
		{
			access = Access.GetInstance();
		}

		private Absence ConvertAbsence(object[] absence)
		{
			Service service = new Service(
				(int)absence[9],
				(string)absence[10]
			);
			model.Personnel personnel = new model.Personnel(
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

		public List<Absence> GetLesAbsences(model.Personnel personnel)
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

		public void AddAbsence(Absence absence)
		{
			if (access.Manager != null)
			{

			}
		}

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
