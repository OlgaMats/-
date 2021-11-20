namespace Art_exhibition.Domain
{
    public class Exhibit
    {
        public string Name { get; set; }
        public int Hall { get; set; }
        public int Year { get; set; }
        public int Country { get; set; }
        public int Style { get; set; }
        public float Size { get; set; }
        public int Material { get; set; }
        public Author Author { get; set; }
    }
}