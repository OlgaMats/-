namespace Art_exhibition.Domain
{
    public class Exhibit
    {
        public int ExhibitId { get; set; }
        public string Name { get; set; }
        public int Hall { get; set; }
        public int Year { get; set; }
        public CountryCreation Country { get; set; }
        public Style Style { get; set; }
        public float Size { get; set; }
        public Material Material { get; set; }
        public Author Author { get; set; }
    }
}