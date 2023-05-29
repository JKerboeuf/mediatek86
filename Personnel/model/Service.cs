namespace Personnel.model
{
	/// <summary>
	/// Classe concernant les services
	/// </summary>
	public class Service
	{
		/// <summary>
		/// Id du service
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Nom du service
		/// </summary>
		public string Nom { get; set; }

		/// <summary>
		/// Constructeur d'un service
		/// </summary>
		/// <param name="id">Id du service</param>
		/// <param name="nom">Nom du service</param>
		public Service(int id, string nom)
		{
			Id = id;
			Nom = nom;
		}

		/// <summary>
		/// Renvoie le nom d'un service
		/// </summary>
		/// <returns>Une chaine de charactères contenant le nom d'un service</returns>
		public override string ToString()
		{
			return Nom;
		}
	}
}
