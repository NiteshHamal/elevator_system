using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    internal class GetElevatorModel
    {

        // Private fields for the class
        private int id;
        private string dateTime;
        private string action;

        // Default constructor
        public GetElevatorModel()
        {
            // Initialize the fields with default values
            id = 0;
            dateTime = "";
            action = "";
        }

        // Parameterized constructor with all fields
        public GetElevatorModel(int id, string dateTime, string action)
        {
            this.id = id;
            this.dateTime = dateTime;
            this.action = action;
        }

        // Getter and setter for 'id'
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // Getter and setter for 'dateTime'
        public string DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        // Getter and setter for 'action'
        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        // Custom ToString method to provide a string representation of the object
        public override string ToString()
        {
            return $"Id: {id}, DateTime: {dateTime}, Action: {action}";
        }
    }
}
