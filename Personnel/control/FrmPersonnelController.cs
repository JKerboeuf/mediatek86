﻿using Personnel.dal;
using Personnel.model;
using System;
using System.Collections.Generic;

namespace Personnel.control
{
	public class FrmPersonnelController
	{
		private readonly AccessAbsence accessAbsence;
		private readonly AccessPersonnel accessPersonnel;
		private readonly AccessService accessService;
		private readonly AccessMotif accessMotif;

		public FrmPersonnelController()
		{
			accessAbsence = new AccessAbsence();
			accessPersonnel = new AccessPersonnel();
			accessService = new AccessService();
			accessMotif = new AccessMotif();
		}

		public List<Motif> GetLesMotifs()
		{
			return accessMotif.GetLesMotifs();
		}

		public List<Service> GetLesServices()
		{
			return accessService.GetLesServices();
		}

		public List<model.Personnel> GetLesPersonnels()
		{
			return accessPersonnel.GetLesPersonnels();
		}

		public List<Absence> GetLesAbsences(model.Personnel personnel)
		{
			return accessAbsence.GetLesAbsences(personnel);
		}

		public void AddPersonnel(model.Personnel personnel)
		{
			accessPersonnel.AddPersonnel(personnel);
		}

		internal void AddAbsence(Absence absence)
		{
			accessAbsence.AddAbsence(absence);
		}

		public void DeletePersonnel(model.Personnel personnel)
		{
			accessPersonnel.DeletePersonnel(personnel);
		}

		internal void DeleteAbsence(Absence absence)
		{
			accessAbsence.DeleteAbsence(absence);
		}
	}
}
