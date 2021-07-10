using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloVSSourceControl
{
    /// <summary>
    /// Represents a single vehicle
    /// with the number in stock
    /// </summary>
    class Vehicle
    {
        /// <summary>
        /// The make of the vehicle 
        /// ex. Honda
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// The model of the vehicle 
        /// ex. Prelude
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// The quantity of vehicles in stock
        /// </summary>
        public byte QuantityInStock { get; set; }
    }
}
