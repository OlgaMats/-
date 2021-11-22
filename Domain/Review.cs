namespace Art_exhibition.Domain
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string Visitor { get; set; }
        public string Exhibit { get; set; }
        public int Evaluation { get; set; }
        public string Review_Text { get; set; }
    }
}