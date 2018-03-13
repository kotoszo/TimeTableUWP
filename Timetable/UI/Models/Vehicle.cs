using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public abstract class Vehicle
    {
        /// <summary>
        /// Returns alarm state for the chosen bus.
        /// </summary>
        public bool IsSet { get; set; }

        /// <summary>
        /// The time in military format e.g.: 1112.
        /// </summary>
        public int MilitaryTIme { get; protected set; }
    }
}
