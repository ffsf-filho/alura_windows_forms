using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CursoWindowsFormsBiblioteca.Databases
{
	public class SQLServerClass
	{
		public string stringConn;
		public SqlConnection connDB;

		public SQLServerClass()
		{
			try
			{
				//stringConn = @"Data Source=localhost,1438;Initial Catalog=ByteBank;Persist Security Info=True;User ID=sa;Password=ssExpress1823;TrustServerCertificate=True";
				stringConn = ConfigurationManager.ConnectionStrings["ByteBank"].ConnectionString;
				connDB = new SqlConnection(stringConn);
				connDB.Open();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public string SqlCommand(string SQL)
		{
			try
			{
				SqlCommand myCommand = new SqlCommand(SQL, connDB);
				myCommand.CommandTimeout = 0;
				SqlDataReader myReader = myCommand.ExecuteReader();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			return "";
		}

		public DataTable SQLQuery(string SQL)
		{
			DataTable dt = new DataTable();

			try
			{
				SqlCommand myCommand = new SqlCommand(SQL, connDB);
				myCommand.CommandTimeout = 0;
				SqlDataReader myReader = myCommand.ExecuteReader();
				dt.Load(myReader);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}

			return dt;
		}

		public void Close()
		{
			connDB.Close();
		}
	}
}
