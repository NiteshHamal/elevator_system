using Elevator.Model;
using Elevator.My_Classes;
using LanguageExt;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controller
{
    internal class ElevatorController:myDatabase
    {

        public bool Insert(ElevatorModel elevator)
        {
            bool result = false;
            string sql = "INSERT INTO elevator (dateTime, action) VALUES (Now(), @action)";
            try
            {
                MySqlConnection conn = Connect();
                MySqlCommand command = new MySqlCommand(sql, conn);

                // Include parameters in the command
                command.Parameters.AddWithValue("@action", elevator.Action);

                // Make a DataAdapter
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataSet dataSet = new DataSet();
                    // Fill the DataSet with the INSERT query result.
                    adapter.Fill(dataSet);

                    // Apply the modifications to the database.
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                    adapter.Update(dataSet);
                }

                Close(conn);
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }




        public ArrayList getElevatorData()
        {
            ArrayList elevatorarray = new ArrayList();
            try
            {
                string sql = "SELECT * FROM elevator order by id desc";
                MySqlConnection conn = Connect();
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    GetElevatorModel elevator = new GetElevatorModel();
                    elevator.Id = reader.GetInt32("id");
                    elevator.DateTime = reader.GetString("dateTime");
                    elevator.Action = reader.GetString("action");
                    elevatorarray.Add(elevator);
                }
                Close(conn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            return elevatorarray;
        }


        public bool clearAllData()
        {
            string sql = "truncate table elevator"; // DELETE query to clear the table
            bool result = false;

            try
            {
                MySqlConnection conn = Connect();
                MySqlCommand command = new MySqlCommand(sql, conn);

                // Create a DataAdapter
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataSet dataSet = new DataSet();

                    // Fill the DataSet with the result of the DELETE query
                    adapter.Fill(dataSet);

                    // Apply the changes to the database
                    MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                    adapter.Update(dataSet);
                }

                Close(conn);
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                result = false;
            }

            return result;
        }
    }
}
