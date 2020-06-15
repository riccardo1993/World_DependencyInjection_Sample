
namespace World.DataAccesLayer
{
    public class Country
    {
        public Country(string IsoCode)
        {
            //TODO get country by ISO CODE   
        }

        public Country()
        { }

        public string IsoCode { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public string Region { get; set; }
        public decimal SurfaceArea { get; set; }
        public int IndepYear { get; set; }
        public int Population { get; set; }
        public decimal LifeExpectancy { get; set; }
        public decimal GNP { get; set; }
        public decimal GNPOld { get; set; }
        public string LocalName { get; set; }
        public string GovernmentForm { get; set; }
        public string HeadOfState { get; set; }
        public int Capital { get; set; }
        public string TwoLetterIsoCode { get; set; }
    }
}
