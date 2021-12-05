namespace Art_exhibition.Repository
{
    public static class Storage
    {
        public static readonly AuthorStorage AuthorStorage = new();
        public static readonly VisitorStorage VisitorStorage = new();
        public static readonly AdminStorage AdminStorage = new();
        public static readonly StaffStorage StaffStorage = new();
        public static readonly ExhibitStorage ExhibitStorage = new();
        public static readonly QuestionStorage QuestionStorage = new();
        public static readonly RequisiteStorage RequisiteStorage = new();
        public static readonly ReviewStorage ReviewStorage = new();
        public static readonly TicketStorage TicketStorage = new();
    }
}