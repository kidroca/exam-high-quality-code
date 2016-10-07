namespace SchoolSystem.ConsoleApp
{
    // I am not sure if we need this, but too scared to delete.
    internal class BusinessLogicService
    {
        public void Execute(ConsoleReaderProvider padhana)
        {
            var injan = new Engine(padhana);
            injan.BrumBrum();
        }
    }
}
