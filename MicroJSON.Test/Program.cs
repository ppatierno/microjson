using Cet.MicroJSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Copyright 2014 by Mario Vernari, Cet Electronics
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace MicroJSON.Test
{
    class Program
    {
        static void Main(string[] args)
        {
#if true
            var s = @"{
    ""firstName"": ""John"",
    ""lastName"": ""Smith"",
    ""age"": 25,
    ""address"": {
        ""streetAddress"": ""21 2nd Street"",
        ""city"": ""New York"",
        ""state"": ""NY"",
        ""postalCode"": 10021
    },
    ""phoneNumbers"": [
        {
            ""type"": ""home"",
            ""number"": ""212 555-1234""
        },
        {
            ""type"": ""fax"",
            ""number"": ""646 555-4567""
        }
    ]
}
";
            var jdom = (JObject)JsonHelpers.Parse(s);

            Console.WriteLine((int)jdom["age"]);    //displays 25

            //add a new phone entry
            var jentry = new JObject();
            jentry["type"] = "mobile";
            jentry["number"] = "+39-123-456-7890";

            var jphones = (JArray)jdom["phoneNumbers"];
            jphones.Add(jentry);

#elif true
            var s = System.IO.File.ReadAllText(@"..\..\test1.json");
            JToken jdom = JsonHelpers.Parse(s);

#else
            var s = " [ 1, null, { \"obj\":null , \"tizio\":345 } , true   ] ";

            JToken jdom = JsonHelpers.Parse(s);

            var jarr = (JArray)jdom;
            jarr.Add(789);

            var jobj = (JObject)jarr[2];
            jobj["pinco"] = "pallino";
            double v = (double)jobj["tizio"];
            Console.WriteLine(v);

            jobj["q"] = null;
            //jobj.Add("q", 3.14159);   //should throw!
#endif

            string jtxt = JsonHelpers.Serialize(jdom);
            Console.WriteLine(jtxt);

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

    }
}
