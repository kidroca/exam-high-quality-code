namespace SchoolSystem.ConsoleApp.Commands
{
    using System.Collections.Generic;

    internal class StudentListMarksCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            return Engine.students[int.Parse(parameters[0])].ListMarks();
        }
    }
}