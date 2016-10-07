namespace SchoolSystem.ConsoleApp
{
    using System.Collections.Generic;

    interface ICommand
    {
        string Execute(IList<string> parameters);
    }
}
