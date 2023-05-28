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

		internal List<model.Personnel> GetLesPersonnels()
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
	}
}
