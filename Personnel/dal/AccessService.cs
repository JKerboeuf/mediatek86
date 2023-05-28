using Personnel.model;
using System;
using System.Collections.Generic;

namespace Personnel.dal
{
	public class AccessService
	{
		private readonly Access access = null;

		public AccessService()
		{
			access = Access.GetInstance();
		}

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

		private Service ConvertService(object[] service)
		{
			return new Service((int)service[0], (string)service[1]);
		}
	}
}
