namespace MistressObedience.Services
{
    public class DevotionService : IDevotionService
    {
        public string GetDevotionMessage(int devotionLevel)
        {
            if (devotionLevel < 5)
                return "Your devotion is weak. You must try harder.";
            if (devotionLevel < 8)
                return "Your devotion is acceptable, but there is room for improvement.";
            return "Your devotion is absolute. You exist only to serve.";
        }
    }
}
