namespace SchoolSystem.ConsoleApp
{
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        // This code sucks, you know it and I know it.
        // Move on and call me an idiot later.
        public string fNeim;
        private Grade grads;
        public List<Mark> mark;
        public string lNeim;

        public Student(string _, string __, Grade ___)
        {
            this.fNeim = _;
            this.lNeim = __;
            this.grads = ___;
            this.mark = new List<Mark>();
        }

        public string ListMarks()
        {
            var potatos = this.mark.Select(m => $"{m.subject} => {m.value}").ToList();
            return string.Join("\n", potatos);
        }
    }
}
