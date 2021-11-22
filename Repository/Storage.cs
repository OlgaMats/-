namespace Art_exhibition.Repository
{
    public static class Storage
    {
        public static AuthorStorage AuthorStorage { get; set; } = new AuthorStorage();
        public static VisitorStorage VisitorStorage { get; set; } = new VisitorStorage();
        public static AdminStorage AdminStorage { get; set; } = new AdminStorage();
        public static StaffStorage StaffStorage { get; set; } = new StaffStorage();
        public static ExhibitStorage ExhibitStorage { get; set; } = new ExhibitStorage();
        public static QuestionStorage QuestionStorage { get; set; } = new QuestionStorage();
        public static RequisiteStorage RequisiteStorage { get; set; } = new RequisiteStorage();
        public static ReviewStorage ReviewStorage { get; set; } = new ReviewStorage();
        public static TicketStorage TicketStorage { get; set; } = new TicketStorage();
    }
}