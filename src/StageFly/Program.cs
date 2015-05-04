using System;
using System.Collections.Generic;
using System.Net.Http;

namespace StageFly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[StageFly]Enter Command:");
            var command = Console.ReadLine().ToLower();

            switch (command)
            {
                case "gettop":
                    var players = GetTop();
                    Console.WriteLine(DisplayTop(players));
                    break;
                default:
                    Console.WriteLine("Command not recognised");
                    break;
            }
        }

        private static string DisplayTop(IEnumerable<Player> players)
        {
            var text = "TOP 25:\n";

            foreach (var player in players)
            {
                text += String.Format("{0}. {1} (playerId: {2})\n", player.Rank, player.Name, player.PlayerId);
            }

            return text;
        }

        private static IEnumerable<Player> GetTop()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_apiEndPoint);
            }

            throw new NotImplementedException();
        }

        public static int CalculatePoints(int score)
        {
            return (score * 13) + 295;
        }

        private const string _apiEndPoint = "http://api.dancetourgos.nl";
    }
}