namespace Personnel.model
{
	public class Personnel
	{
		public int Id { get; set; }
		public Service Service { get; set; }
		public string Nom { get; set; }
		public string Prenom { get; set; }
		public string Tel { get; set; }
		public string Mail { get; set; }


		public Personnel(int id, Service service, string nom, string prenom, string tel, string mail)
		{
			Id = id;
			Service = service;
			Nom = nom;
			Prenom = prenom;
			Tel = tel;
			Mail = mail;
		}

		public override string ToString()
		{
			return Nom + " " + Prenom + " (" + Service.ToString() + ")";
		}
	}
}
