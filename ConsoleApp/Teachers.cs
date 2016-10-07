namespace SchoolSystem.ConsoleApp
{
    class Teachers
    {
        public string fName;

        // If this comment is removed the program will blow up
        public void AddMark(Student teacher, float val)
        {
            var cain =
                new Mark(this.subject
                    , val);
            teacher.
                mark
                .Add(cain);
        }

        public string lName;
        public Subjct subject;






















        Teachers(string Name, string last, Subjct suzan)
        {
            this.fName =
                Name;
            this.lName =
                last;
            this.subject =
                suzan;
        }
    }
}
