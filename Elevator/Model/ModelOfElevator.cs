using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    internal class ElevatorModel
    {
        // Private fields for the class
        private string action;

        // Default constructor
        public ElevatorModel()
        {
            // Initialize the fields with default values
            action = "";
        }

        // Parameterized constructor
        public ElevatorModel(string action)
        {
            this.action = action;
        }


        // Getter and setter for 'action'
        public string Action
        {
            get { return action; } // Getter method for 'action'
            set { action = value; } // Setter method for 'action'
        }

        // Custom ToString method to provide a string representation of the object
        public override string ToString()
        {
            return $"Action: {action}";
        }


    }
}
