namespace WebAppAPIClient.Models.Decorator
{
    public class Film : Flight
    {
        protected static string _description = "with film ";

        private Flight Flight = null;

        public Film(Flight flight)
        {
            this.Flight = flight;
        }

        public override string GetDescription()
        {
            return this.Flight.GetDescription() + _description;
        }
    }
}
