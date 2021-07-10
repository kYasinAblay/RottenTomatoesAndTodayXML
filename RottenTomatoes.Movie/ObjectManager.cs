using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using RottenTomatoes.Movie.Model;

namespace RottenTomatoes.Movie
{
    public class ObjectManager<T> : IObjectManager<T>
    {
        private string Url = "https://www.rottentomatoes.com/api/private/v1.0/movies.json?q={0}&page_limit=50&page={1}";

        public Task<T> GetAll(string param,int page=1)
        {
            HttpClient client = new HttpClient();
            Uri uri = new Uri(string.Format(Url, string.IsNullOrEmpty(param)==true?"god":param,page));
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = Task.Run(() => client.GetAsync(uri)).Result;


            if (response.IsSuccessStatusCode)
            {
                var result = Task.Run(() => response.Content.ReadAsStringAsync()).Result;
                var s = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result);
                return Task.FromResult(s);
            }
            else
            {
                return Task.FromResult(default(T));
            }
        }


    }
}
