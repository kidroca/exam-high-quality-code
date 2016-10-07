namespace SchoolSystem.ConsoleApp.Core.Commands
{
    using System.Collections.Generic;

    internal interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
