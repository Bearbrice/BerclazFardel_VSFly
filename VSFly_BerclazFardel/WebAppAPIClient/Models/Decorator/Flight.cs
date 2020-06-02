namespace WebAppAPIClient.Models.Decorator
{
    public class Flight
    {
        protected string Description = "You have successfully booked this flight ";

        public virtual string GetDescription()
        {
            return Description;
        }

    }

}
