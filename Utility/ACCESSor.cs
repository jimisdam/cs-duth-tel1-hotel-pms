using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Data.OleDb;

namespace TachyDev.Utility;

internal class ACCESSor
{
    public static DataTable? LoadTable(string table)
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\TachyDev.accdb;";
        string query = $"SELECT * FROM {table}";

        using (OleDbConnection connection = new OleDbConnection(connectionString))
        {
            try
            {
                connection.Open();

                OleDbDataAdapter adapter = new(query, connection);
                DataTable dataTable = new();

                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nFrom: {table}");
                connection.Close();
            }
        }

        return null;
    }
}
