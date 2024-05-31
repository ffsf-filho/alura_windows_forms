using System;
using System.Data;
using System.Data.SqlClient;

namespace CursoWindowsFormsBiblioteca.Databases
{
	public class LocalDBClass
	{
		public string stringConn;
		public SqlConnection connDB;

		public LocalDBClass()
		{
			try
			{
				stringConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\FranciscoFlorentino\Visual Studio 2022\alura_windows_forms\CursoWindowsFormsBiblioteca\Databases\Fichario.mdf"";Integrated Security=True";
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
			finally
			{
				Close();
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
			finally
			{
				Close();
			}

			return dt;
		}

		public void Close()
		{
			connDB.Close();
		}
	}
}
