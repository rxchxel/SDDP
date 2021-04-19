using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ApiLibrary
{
    public class SpellProcessor
    {
        public static async Task<SpellModel> LoadSpellInformation(string spell)
        {
            string url = "https://www.dnd5eapi.co/api/spells";
            url = url + "/" + spell;
            HttpClient client = new HttpClient();
            using (HttpResponseMessage response = await client.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };
                    
                    var spellmodel = JsonConvert.DeserializeObject<SpellModel>(result, settings);

                    return spellmodel;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public static async Task<Spells> LoadAllSpellsInformation()
        {

            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore
            };
            string url = "https://www.dnd5eapi.co/api/spells";
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var spells = JsonConvert.DeserializeObject<Spells>(responseBody, settings);
            return spells;

            /*
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var test = new HttpRequestMessage(HttpMethod.Get, url);
                var response = await client.SendAsync(test);
                if (response.IsSuccessStatusCode)
                {
                    var settings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore,
                        MissingMemberHandling = MissingMemberHandling.Ignore
                    };
                    var result = await response.Content.ReadAsStringAsync();
                    var spells = JsonConvert.DeserializeObject<Spells>(result, settings);
                    return spells;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }            */

        }
    }
}
