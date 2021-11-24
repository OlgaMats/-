namespace Art_exhibition.Repository
{
    public static class Storage
    {
        public static AuthorStorage AuthorStorage { get;  } = new AuthorStorage();
        public static VisitorStorage VisitorStorage { get;  } = new VisitorStorage();
        public static AdminStorage AdminStorage { get;  } = new AdminStorage();
        public static StaffStorage StaffStorage { get;  } = new StaffStorage();
        public static ExhibitStorage ExhibitStorage { get; } = new ExhibitStorage();
        public static QuestionStorage QuestionStorage { get; } = new QuestionStorage();
        public static RequisiteStorage RequisiteStorage { get; } = new RequisiteStorage();
        public static ReviewStorage ReviewStorage { get; } = new ReviewStorage();
        public static TicketStorage TicketStorage { get; } = new TicketStorage();
    }
}