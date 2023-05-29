namespace Personnel.model
{
	/// <summary>
	/// Classe concernant un personnel
	/// </summary>
	public class Personnel
	{
		/// <summary>
		/// Id du personnel
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Service du personnel
		/// </summary>
		public Service Service { get; set; }
		/// <summary>
		/// Nom du personnel
		/// </summary>
		public string Nom { get; set; }
		/// <summary>
		/// Prenom du personnel
		/// </summary>
		public string Prenom { get; set; }
		/// <summary>
		/// Numero de telephone du personnel
		/// </summary>
		public string Tel { get; set; }
		/// <summary>
		/// Adressse mail du personnel
		/// </summary>
		public string Mail { get; set; }

		/// <summary>
		/// Constructeur d'un personnel
		/// </summary>
		/// <param name="id">Id du personnel</param>
		/// <param name="service">Service du personnel</param>
		/// <param name="nom">Nom du personnel</param>
		/// <param name="prenom">Prenom du personnel</param>
		/// <param name="tel">Numero de telephone du personnel</param>
		/// <param name="mail">Adressse mail du personnel</param>
		public Personnel(int id, Service service, string nom, string prenom, string tel, string mail)
		{
			Id = id;
			Service = service;
			Nom = nom;
			Prenom = prenom;
			Tel = tel;
			Mail = mail;
		}

		/// <summary>
		/// Afficher les détails d'un personnel de façon lisible
		/// </summary>
		/// <returns>Une chaine de charactères contenant l'éssentiel d'un personnel</returns>
		public override string ToString()
		{
			return Nom + " " + Prenom + " (" + Service.ToString() + ")";
		}
	}
}
