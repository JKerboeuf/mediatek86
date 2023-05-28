using Personnel.model;
using System;
using System.Collections.Generic;

namespace Personnel.dal
{
	public class AccessPersonnel
	{
		private readonly Access access = null;

		public AccessPersonnel()
		{
			access = Access.GetInstance();
		}

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

		public void AddPersonnel(model.Personnel personnel)
		{
			// Method intentionally left empty.
		}

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
