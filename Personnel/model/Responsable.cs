﻿namespace Personnel.model
{
	public class Responsable
	{
		public string Login { get; set; }
		public string Pwd { get; set; }

		public Responsable(string login, string pwd)
		{
			Login = login;
			Pwd = pwd;
		}
    }
}
