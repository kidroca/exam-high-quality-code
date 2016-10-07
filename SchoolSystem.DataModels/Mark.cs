namespace SchoolSystem.DataModels
{
    public class Mark
    {
        public float value;
        public Subjct subject;

        public Mark(Subjct sbj, float va)
        {
            this.subject = sbj;
            this.value = va;
        }
    }
}
