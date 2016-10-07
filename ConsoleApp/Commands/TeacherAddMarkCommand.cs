namespace SchoolSystem.ConsoleApp.Commands
{
    using System.Collections.Generic;

    internal class TeacherAddMarkCommand : ICommand
    {
        public string Execute(IList<string> prms)
        {
            var teecherid = int.Parse(prms[0]);
            var studentid = int.Parse(prms[1]);
            // Please work
            var student = Engine.students[teecherid];
            var adhyaapak = Engine.teachers[studentid];
            adhyaapak.AddMark(student, float.Parse(prms[2]));
            return $"Teacher {adhyaapak.fName} {adhyaapak.lName} added mark {float.Parse(prms[2])} to student {student.fNeim} {student.lNeim} in {adhyaapak.subject}.";
        }
    }
}
