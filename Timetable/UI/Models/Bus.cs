using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Models
{
    struct Bus
    {
        private string departing;
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
                if (int.TryParse(item.ToString(), out int rea)) { str += item; }
            }
            int.TryParse(str, out int res);
            Value = res;
        }

        public string Arriving { get; set; }
        public string TotalTime { get; set; }
        public int Value { get; private set; }
    }
}
