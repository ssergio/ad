using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace Serpis.Ad
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string connectionString ="Server=localhost;" +
                               "Database=dbprueba;" +
                               "User Id=root; " +
                               "Password=sistemas";
                       
                       MySqlConnection mySqlConnection = new MySqlConnection (connectionString);
                       
                       mySqlConnection.Open();
                       
                       //Select * from categoria
                       MySqlCommand mysqlCommand = mySqlConnection.CreateCommand();
                       
                       mysqlCommand.CommandText = "Select * from articulo";
                       
                       MySqlDataReader mySqlDataReader = mysqlCommand.ExecuteReader();
			///////////////AÑADIMOS LOS METADATOS DE LA TABLA CATEGORIA
						
		//	Console.Write(mySqlDataReader.GetValue(0,mySqlDataReader.FieldCount));
	
           //          int valores = mySqlDataReader.GetValues;
					
	//				Console.WriteLine (mySqlDataReader.FieldCount);
	//				Console.WriteLine (mySqlDataReader.FieldCount);
			
			
			System.Console.WriteLine(string.Join ("  ", getColumnNames(mySqlDataReader)));
			////////////////////////////////////////////////////////////
					   mySqlDataReader.Close();
                       
                       mySqlConnection.Close();
                       
                       System.Console.WriteLine ("ok");
  
		}
	/*	private static IEnumerable<string> getColumnNames(MySqlDataReader mySqlDataReader) {
			int fieldCount = mySqlDataReader.FieldCount;
			string[] columnNames = new string [fieldCount];
			for (int index = 0; index < fieldCount; index++)
				columnNames[index]= mySqlDataReader.GetName (index);
			return columnNames;*/
		
		private static string[] getColumnNames(MySqlDataReader mySqlDataReader) {
			int fieldCount = mySqlDataReader.FieldCount;
			string[] columnNames = new string [fieldCount];
			for (int index = 0; index < fieldCount; index++)
				columnNames[index]= mySqlDataReader.GetName (index);
			return columnNames;
			
	}
	
	private static string[] getColumnNames2(MySqlDataReader mySqlDataReader){
			int fieldCount = mySqlDataReader.FieldCount;
			List<string> columnNames = new List<string>();
			for( int index=0; index < fieldCount; index++)
				columnNames.Add (mySqlDataReader.GetName(index) );
			return columnNames.ToArray();
	}
}
}