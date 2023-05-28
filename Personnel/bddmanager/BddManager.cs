using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Personnel.bddmanager
{
	public class BddManager
	{
		private static BddManager instance = null;
		private readonly MySqlConnection connection;

		private BddManager(string connectString)
		{
			connection = new MySqlConnection(connectString);
			connection.Open();
		}

		public static BddManager GetInstance(string connectString)
		{
			if (instance == null)
			{
				instance = new BddManager(connectString);
			}
			return instance;
		}

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
