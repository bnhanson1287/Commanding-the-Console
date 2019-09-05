using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http; // for HttpClient
using static System.Console; // allows me to directly call the static methods on the console class, without classname qualifier

namespace Repo
{
    class Program
    {
        const string API_BASE = "https://gitignore.io/api/";
        const string API_LINES = API_BASE + "list?format=lines";
        static void Main(string[] args)
        {
            //Use he HttpClient to grab content from a website
            var client = new HttpClient();
            var templateNames = client.GetAsync(API_LINES).GetAwaiter().GetResult();

            WriteLine(templateNames);
        }

    }
}
