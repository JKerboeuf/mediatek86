using Personnel.model;
using System.Collections.Generic;
using System;

namespace Personnel.dal
{
	public class AccessMotif
	{
		private readonly Access access = null;

		public AccessMotif()
		{
			access = Access.GetInstance();
		}

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

		private Motif ConvertService(object[] motif)
		{
			return new Motif((int)motif[0], (string)motif[1]);
		}
	}
}
