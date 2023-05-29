using Personnel.dal;
using Personnel.model;
using System;
using System.Collections.Generic;

namespace Personnel.control
{
	/// <summary>
	/// Classe du controlleur de la fenetre principal
	/// </summary>
	public class FrmPersonnelController
	{
		private readonly AccessAbsence accessAbsence;
		private readonly AccessPersonnel accessPersonnel;
		private readonly AccessService accessService;
		private readonly AccessMotif accessMotif;

		/// <summary>
		/// Constructeur du controlleur
		/// </summary>
		public FrmPersonnelController()
		{
			accessAbsence = new AccessAbsence();
			accessPersonnel = new AccessPersonnel();
			accessService = new AccessService();
			accessMotif = new AccessMotif();
		}

		/// <summary>
		/// Méthode permettant d'obtenir la liste des motifs éxistant dans la bdd
		/// </summary>
		/// <returns>la liste des motifs</returns>
		public List<Motif> GetLesMotifs()
		{
			return accessMotif.GetLesMotifs();
		}

		/// <summary>
		/// Méthode permettant d'obtenir la liste des services éxistant dans la bdd
		/// </summary>
		/// <returns>la liste des services</returns>
		public List<Service> GetLesServices()
		{
			return accessService.GetLesServices();
		}

		/// <summary>
		/// Méthode permettant d'obtenir la liste des personnels éxistant dans la bdd
		/// </summary>
		/// <returns>la liste des personnels</returns>
		public List<model.Personnel> GetLesPersonnels()
		{
			return accessPersonnel.GetLesPersonnels();
		}

		/// <summary>
		/// Méthode permettant d'obtenir la liste des absences éxistantes dans la bdd
		/// </summary>
		/// <returns>la liste des absences</returns>
		public List<Absence> GetLesAbsences(model.Personnel personnel)
		{
			return accessAbsence.GetLesAbsences(personnel);
		}

		/// <summary>
		/// Méthode permettant d'ajouter un personnel dans la bdd
		/// </summary>
		/// <param name="personnel">le personnel à ajouter</param>
		public void AddPersonnel(model.Personnel personnel)
		{
			accessPersonnel.AddPersonnel(personnel);
		}

		/// <summary>
		/// Méthode permettant d'ajouter une absence dans la bdd
		/// </summary>
		/// <param name="absence">l'absence à ajouter</param>
		/// <param name="idPersonnel">l'id du personnel concerné par l'absence</param>
		public void AddAbsence(Absence absence, int idPersonnel)
		{
			accessAbsence.AddAbsence(absence, idPersonnel);
		}

		/// <summary>
		/// Méthode permettant de modifier un personnel dans la bdd
		/// </summary>
		/// <param name="personnel">le personnel modifié</param>
		/// <param name="idPersonnelModif">l'id du personnel à modifier</param>
		public void ModifPersonnel(model.Personnel personnel, int idPersonnelModif)
		{
			accessPersonnel.ModifPersonnel(personnel, idPersonnelModif);
		}

		/// <summary>
		/// Méthode permettant de modifier une absence dans la bdd
		/// </summary>
		/// <param name="absence">l'absence modifié</param>
		/// <param name="idPersonnelModif">l'id du personnel concerné par l'absence</param>
		/// <param name="idDateModif">la date de debut de l'absence à modifier</param>
		public void ModifAbsence(Absence absence, int idPersonnelModif, DateTime idDateModif)
		{
			accessAbsence.ModifAbsence(absence, idPersonnelModif, idDateModif);
		}

		/// <summary>
		/// Méthode permettant de supprimer un personnel de la bdd
		/// </summary>
		/// <param name="personnel">le personnel à supprimer</param>
		public void DeletePersonnel(model.Personnel personnel)
		{
			accessPersonnel.DeletePersonnel(personnel);
		}

		/// <summary>
		/// Méthode permettant de supprimer une absence dans la bdd
		/// </summary>
		/// <param name="absence">l'absence à supprimer</param>
		public void DeleteAbsence(Absence absence)
		{
			accessAbsence.DeleteAbsence(absence);
		}
	}
}
