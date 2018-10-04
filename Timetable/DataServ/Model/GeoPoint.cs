namespace DataServ.Model
{
    public class GeoPoint
    {
        public string Type { get; set; }

        public double[] Coordinates { get; set; }

        public override string ToString()
        {
            return $"{Type} {string.Join("-", Coordinates)}";
        }
    }
}