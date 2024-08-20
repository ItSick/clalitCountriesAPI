namespace CountriesApi.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public int Flag { get; set; }
        public Currency[] Currencies {get; set;}
    }

    public class Currency {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Symbol {get; set;}
    }
}