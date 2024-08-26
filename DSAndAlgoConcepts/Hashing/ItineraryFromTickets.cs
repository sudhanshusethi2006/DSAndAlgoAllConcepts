namespace DSAndAlgoConcepts.Hashing
{
    internal class ItineraryFromTickets
    {
        //static void Main(string[] args)
        //{
        //    GenerateBestItinerary();
        //}

        private static void GenerateBestItinerary()
        {
            var tickets = new Dictionary<string, string>();
            tickets.Add("Chennai", "Bengaluru");
            tickets.Add("Mumbai", "Delhi");
            tickets.Add("Goa", "Chennai");
            tickets.Add("Delhi", "Goa");

            var startCity = GetStart(tickets);
            Console.Write(startCity);
            foreach (var city in tickets.Keys)
            {
                Console.Write("->" + tickets[startCity]);
                startCity = tickets[startCity];
            }
        }

        public static string GetStart(Dictionary<string, string> tickets)
        {
            var test = tickets.Keys.Except(tickets.Values).ToList();
            return test[0];
        }
    }

}
