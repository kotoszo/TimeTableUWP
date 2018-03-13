using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    public class Bus : Vehicle
    {
        private string departing;
        /// <summary>
        /// The time in string format.
        /// </summary>
        public string Departing
        {
            get { return departing; }
            set
            {
                departing = value;
                SetValue(value);
            }
        }
        private void SetValue(string value)
        {
            string str = "";
            foreach (var item in value)
            {
                if(char.IsDigit(item)) { str += (int)Char.GetNumericValue(item); }
            }
            int.TryParse(str, out int res);
            MilitaryTIme = res;
        }
        public string Arriving { get; set; }
        public string TravellingTime { get; set; }
        public override string ToString()
        {
            return string.Format("Indulás: {0} Érkezés: {1}\nMenetidő: {2}\n", Departing, Arriving, TravellingTime);
        }
    }
}
