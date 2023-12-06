namespace Project_Take_two.Models
{
    public class CurrentDateTimeProvider:IDateTimeProvider
    {
        public DateTime Actual()
        {
            return DateTime.Now;
        }

        
    }
}
