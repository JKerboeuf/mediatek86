using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Personnel.bddmanager
{
	/// <summary>
	/// Classe technique Singleton pour gerer la connection à la base de donnée
	/// </summary>
	public class BddManager
	{
		private static BddManager instance = null;
		private readonly MySqlConnection connection;

		/// <summary>
		/// Constructeur privé ouvrant la connection avec la bdd
		/// </summary>
		/// <param name="connectString">chaine de connection avec la bdd</param>
		private BddManager(string connectString)
		{
			connection = new MySqlConnection(connectString);
			connection.Open();
		}

		/// <summary>
		/// Getter sur l'instance unique
		/// </summary>
		/// <param name="connectString">chaine de connection avec la bdd</param>
		/// <returns>L'instance unique permettant de se connecter à la bdd</returns>
		public static BddManager GetInstance(string connectString)
		{
			if (instance == null)
			{
				instance = new BddManager(connectString);
			}
			return instance;
		}

		/// <summary>
		/// Méthode exécutant une requete sans retour à la bdd
		/// </summary>
		/// <param name="req">la requete à exécuter</param>
		/// <param name="param">les paramètres de la requete</param>
		public void ReqUpdate(string req, Dictionary<string, object> param = null)
		{
			MySqlCommand command = new MySqlCommand(req, connection);
			if (!(param is null))
			{
				foreach (KeyValuePair<string, object> element in param)
				{
					command.Parameters.Add(new MySqlParameter(element.Key, element.Value));
				}
			}
			command.Prepare();
			command.ExecuteNonQuery();
		}

		/// <summary>
		/// Méthode exécutant une requete avec retour à la bdd
		/// </summary>
		/// <param name="req">la requete à exécuter</param>
		/// <param name="param">les paramètres de la requete</param>
		/// <returns>Une liste de tableau d'objets contenant le retour de la bdd</returns>
		public List<object[]> ReqSelect(string req, Dictionary<string, object> param = null)
		{
			List<object[]> records = new List<object[]>();
			MySqlDataReader cursor;
			int nbCols;

			MySqlCommand command = new MySqlCommand(req, connection);
			if (!(param is null))
			{
				foreach (KeyValuePair<string, object> element in param)
				{
					command.Parameters.Add(new MySqlParameter(element.Key, element.Value));
				}
			}
			command.Prepare();
			cursor = command.ExecuteReader();
			nbCols = cursor.FieldCount;
			while (cursor.Read())
			{
				object[] attributs = new object[nbCols];
				cursor.GetValues(attributs);
				records.Add(attributs);
			}
			cursor.Close();
			return records;
		}
	}
}
