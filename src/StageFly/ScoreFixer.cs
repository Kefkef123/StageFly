using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace StageFly
{
    public class ScoreFixer
    {
        public async Task<Player> SetScore(long score, int playerId, string city)
        {
            var code = CalculateCode(score);

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_apiEndPoint);

                var result = await client.GetAsync(String.Format("/gamePlayed/?playerId={0}&score={1}&city={2}&code={3}", playerId, score, city, code));
                var content = await result.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Player>(content, _serializerSettings);
            }
        }

        public async Task<IEnumerable<Player>> GetTopPlayers(string city)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_apiEndPoint);

                var result = await client.GetAsync(String.Format("/gamePlayed/getRanking/?city={0}", city));
                var content = await result.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<IEnumerable<Player>>(content, _serializerSettings);
            }
        }

        public async Task<IEnumerable<CityObject>> GetCities()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_apiEndPoint);

                var result = await client.GetAsync("/cities");
                var content = await result.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<IEnumerable<CityObject>>(content);
            }
        }

        private static long CalculateCode(long score)
        {
            return (score*13) + 295;
        }

        private readonly string _apiEndPoint = "http://api.dancetourgos.nl";

        private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        };
    }
}