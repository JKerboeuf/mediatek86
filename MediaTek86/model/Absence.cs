using System;

namespace MediaTek86.model
{
	/// <summary>
	/// Classe concernant une absence d'un personnel
	/// </summary>
	public class Absence
	{
		/// <summary>
		/// Le personnel dont est issu l'absence
		/// </summary>
		public Personnel Personnel { get; set; }
		/// <summary>
		/// Le motif de l'absence
		/// </summary>
		public Motif Motif { get; set; }
		/// <summary>
		/// La date de debut de l'absence
		/// </summary>
		public DateTime DateDebut { get; set; }
		/// <summary>
		/// La date de fin de l'absence
		/// </summary>
		public DateTime DateFin { get; set; }

		/// <summary>
		/// Contructeur d'une absence
		/// </summary>
		/// <param name="personnel">Le personnel dont est issu l'absence</param>
		/// <param name="motif">Le motif de l'absence</param>
		/// <param name="dateDebut">La date de debut de l'absence</param>
		/// <param name="dateFin">La date de fin de l'absence</param>
		public Absence(Personnel personnel, Motif motif, DateTime dateDebut, DateTime dateFin)
		{
			Personnel = personnel;
			Motif = motif;
			DateDebut = dateDebut;
			DateFin = dateFin;
		}

		/// <summary>
		/// Afficher les détails d'une absence de façon lisible
		/// </summary>
		/// <returns>Une chaine de charactères contenant l'éssentiel d'une absence</returns>
		public override string ToString()
		{
			return DateDebut.ToString("d") + " - " + DateFin.ToString("d") + " (" + Motif.ToString() + ")";
		}
	}
}
