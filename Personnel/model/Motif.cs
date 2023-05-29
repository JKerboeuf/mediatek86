namespace Personnel.model
{
	/// <summary>
	/// Classe concernant les motifs des absences
	/// </summary>
	public class Motif
	{
		/// <summary>
		/// Id du motif
		/// </summary>
		public int Id { get; set; }
		/// <summary>
		/// Libellé du motif
		/// </summary>
		public string Libelle { get; set; }

		/// <summary>
		/// Constructeur d'un motif
		/// </summary>
		/// <param name="id">Id du motif</param>
		/// <param name="libelle">Libellé du motif</param>
		public Motif(int id, string libelle)
		{
			Id = id;
			Libelle = libelle;
		}

		/// <summary>
		/// Renvoie le libellé d'un motif
		/// </summary>
		/// <returns>Une chaine de charactères contenant le libellé d'un motif</returns>
		public override string ToString()
		{
			return Libelle;
		}
	}
}
