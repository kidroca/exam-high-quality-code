namespace SchoolSystem.ConsoleApp.Core.Commands
{
    using System.Collections.Generic;
    using Core;

    internal class StudentListMarksCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            return Engine.students[int.Parse(parameters[0])].ListMarks();
        }
    }
}