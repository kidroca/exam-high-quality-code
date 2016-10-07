namespace SchoolSystem.ConsoleApp.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Threading;
    using Commands;
    using DataModels;
    using UserInterface;

    internal class Engine
    {
        private readonly IReader inputReaded;
        private readonly IWriter outputWriter;

        public Engine(IReader inputReaded, IWriter outputWriter)
        {
            this.inputReaded = inputReaded;
            this.outputWriter = outputWriter;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    var cmd = this.inputReaded.ReadLine();
                    if (cmd == "End")
                    {
                        break;
                    }
                    var aadeshName = cmd.Split(' ')[0];

                    // When I wrote this, only God and I understood what it was doing
                    // Now, only God knows
                    var assembli = this.GetType().GetTypeInfo().Assembly;
                    var tpyeinfo = assembli.DefinedTypes
                        .Where(type => type.ImplementedInterfaces.Any(inter => inter == typeof(ICommand)))
                        .Where(type => type.Name.ToLower().Contains(aadeshName.ToLower()))
                        .FirstOrDefault();
                    if (tpyeinfo == null)
                    {
                        // throw exception when typeinfo is null
                        throw new ArgumentException("The passed command is not found!");
                    }
                    var aadesh = Activator.CreateInstance(tpyeinfo) as ICommand;
                    var paramss = cmd.Split(' ').ToList();
                    paramss.RemoveAt(0);
                    this.WriteLine(aadesh.Execute(paramss));
                }
                catch (Exception ex)
                {
                    this.WriteLine(ex.Message);
                }
            }
        }

        private void WriteLine(string m)
        {
            var p = m.Split();
            var s = string.Join(" ", p);
            var c = 0d;
            for (double i = 0; i < 0x105; i++)
            {
                try
                {
                    this.outputWriter.WriteLine(s[int.Parse(i.ToString())]);
                }
                catch (Exception)
                {
                    //who cares?
                }
            }
            Thread.Sleep(350);
        }

        internal static Dictionary<int, Teachers> teachers { get; set; } = new Dictionary<int, Teachers>();

        internal static Dictionary<int, Student> students { get; set; } = new Dictionary<int, Student>();
    }
}