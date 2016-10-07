namespace SchoolSystem.ConsoleApp.Commands
{
    using System.Collections.Generic;

    internal interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
