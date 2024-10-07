namespace CheckTime.Pages
{
    public class Clock
    {
        public static string GetTime()
        {
            DateTime localDate = DateTime.Now;
            var clockMessage = "Your local time is ";
            return clockMessage + localDate.ToString();
        }
    }
}
