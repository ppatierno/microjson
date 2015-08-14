using Cet.MicroJSON;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using System;
using System.Threading;

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
namespace MicroJSONNetMf43.Test
{
    public class Program
    {
        public static void Main()
        {
            {
                /**
                 * Basic test
                 **/

                var s = " [ 1, null, { \"obj\":null , \"tizio\":345 } , true   ] ";

                JToken jdom = JsonHelpers.Parse(s);

                var jarr = (JArray)jdom;
                jarr.Add(789);

                var jobj = (JObject)jarr[2];
                jobj["pinco"] = "pallino";
                double v = (double)jobj["tizio"];
                Debug.Print(v.ToString());

                jobj["q"] = null;
                //jobj.Add("q", 3.14159);   //should throw!

                string jtxt = JsonHelpers.Serialize(jdom);
                Debug.Print(jtxt);
            }

            // Uncomment following code if you have Netduino board and want to test performance

            //{
            //    /**
            //     * Performance test
            //     **/

            //    //read the test JSON string
            //    string jsrc = ReadFile2K();
            //    Debug.Print(jsrc.Length.ToString());

            //    //open the D0 and D1 ports to issue the flow state
            //    var p0 = new OutputPort(Pins.GPIO_PIN_D0, false);
            //    var p1 = new OutputPort(Pins.GPIO_PIN_D1, false);

            //    while (true)
            //    {

            //        //parsing
            //        p0.Write(true);
            //        JToken jdom = JsonHelpers.Parse(jsrc);
            //        p0.Write(false);

            //        //serializing
            //        //p1.Write(true);
            //        //string jtxt = JsonHelpers.Serialize(jdom);
            //        //p1.Write(false);

            //        Thread.Sleep(500);
            //    }
            //}
        }


        static string ReadFile500()
        {
            return @"{""StatusMsg"": ""OK"", ""Results"": {""Name"": ""France"", ""Capital"": {""DLST"": 1.0, ""TD"": 1.0, ""Flg"": 2, ""Name"": ""Paris"", ""GeoPt"": [48.52, 2.2]}, ""GeoRectangle"": {""West"": -5.14222288132, ""East"": 9.56155776978, ""North"": 51.0928115845, ""South"": 41.3715744019}, ""SeqID"": 74, ""GeoPt"": [46.0, 2.0], ""TelPref"": ""33"", ""CountryCodes"": {""tld"": ""fr"", ""iso3"": ""FRA"", ""iso2"": ""FR"", ""fips"": ""FR"", ""isoN"": 250}, ""CountryInfo"": ""http://www.geognos.com/geo/en/cc/fr.html""}, ""StatusCode"": 200}";
        }


        static string ReadFile2K()
        {
            return @"{
    ""ResultSet"": {
        ""totalResultsAvailable"": ""1827221"",
        ""totalResultsReturned"": 2,
        ""firstResultPosition"": 1,
        ""Result"": [
            {
                ""Title"": ""potato jpg"",
                ""Summary"": ""Kentang Si bungsu dari keluarga Solanum tuberosum L ini ternyata memiliki khasiat untuk mengurangi kerutan  jerawat  bintik hitam dan kemerahan pada kulit  Gunakan seminggu sekali sebagai"",
                ""Url"": ""http:\/\/www.mediaindonesia.com\/spaw\/uploads\/images\/potato.jpg"",
                ""ClickUrl"": ""http:\/\/www.mediaindonesia.com\/spaw\/uploads\/images\/potato.jpg"",
                ""RefererUrl"": ""http:\/\/www.mediaindonesia.com\/mediaperempuan\/index.php?ar_id=Nzkw"",
                ""FileSize"": 22630,
                ""FileFormat"": ""jpeg"",
                ""Height"": ""362"",
                ""Width"": ""532"",
                ""Thumbnail"": {
                    ""Url"": ""http:\/\/thm-a01.yimg.com\/nimage\/557094559c18f16a"",
                    ""Height"": ""98"",
                    ""Width"": ""145""
                }
            },
            {
                ""Title"": ""potato jpg"",
                ""Summary"": ""Introduction of puneri aloo This is a traditional potato preparation flavoured with curry leaves and peanuts and can be eaten on fasting day  Preparation time   10 min"",
                ""Url"": ""http:\/\/www.infovisual.info\/01\/photo\/potato.jpg"",
                ""ClickUrl"": ""http:\/\/www.infovisual.info\/01\/photo\/potato.jpg"",
                ""RefererUrl"": ""http:\/\/sundayfood.com\/puneri-aloo-indian-%20recipe"",
                ""FileSize"": 119398,
                ""FileFormat"": ""jpeg"",
                ""Height"": ""685"",
                ""Width"": ""1024"",
                ""Thumbnail"": {
                    ""Url"": ""http:\/\/thm-a01.yimg.com\/nimage\/7fa23212efe84b64"",
                    ""Height"": ""107"",
                    ""Width"": ""160""
                }
            }
        ]
    }
}
";
        }


        static string ReadFile9K()
        {
            return @"
[
    {
        ""id"": 0,
        ""guid"": ""e4dd6c4b-9d29-4d57-b98a-aef195d7621e"",
        ""isActive"": false,
        ""balance"": ""$1,545.00"",
        ""picture"": ""http://placehold.it/32x32"",
        ""age"": 26,
        ""name"": ""Enid Sargent"",
        ""gender"": ""female"",
        ""company"": ""Miraclis"",
        ""email"": ""enidsargent@miraclis.com"",
        ""phone"": ""+1 (815) 543-3189"",
        ""address"": ""864 Plaza Street, Moscow, Rhode Island, 4400"",
        ""about"": ""Et est consequat voluptate cupidatat ad dolor nisi adipisicing aute. Fugiat magna aute Lorem dolore duis laboris laboris minim aliqua laborum voluptate qui reprehenderit irure. Officia pariatur qui labore irure. Et enim labore laborum elit deserunt id est laborum nulla magna est minim commodo. Tempor consectetur labore nisi sint. Elit mollit dolore consectetur esse. Culpa nostrud sint sit sit laborum velit aute anim irure nulla consequat.\r\n"",
        ""registered"": ""2002-11-02T22:07:57 -01:00"",
        ""latitude"": -64.291661,
        ""longitude"": 161.768607,
        ""tags"": [
            ""Lorem"",
            ""excepteur"",
            ""quis"",
            ""nisi"",
            ""consequat"",
            ""pariatur"",
            ""Lorem""
        ],
        ""friends"": [
            {
                ""id"": 0,
                ""name"": ""Lara Everett""
            },
            {
                ""id"": 1,
                ""name"": ""Alana Huff""
            },
            {
                ""id"": 2,
                ""name"": ""Lyons Lucas""
            }
        ],
        ""randomArrayItem"": ""apple""
    },
    {
        ""id"": 1,
        ""guid"": ""e293efd0-8e99-4387-b130-86725f1ae36a"",
        ""isActive"": false,
        ""balance"": ""$1,744.00"",
        ""picture"": ""http://placehold.it/32x32"",
        ""age"": 39,
        ""name"": ""Odom Patel"",
        ""gender"": ""male"",
        ""company"": ""Isostream"",
        ""email"": ""odompatel@isostream.com"",
        ""phone"": ""+1 (870) 436-2993"",
        ""address"": ""314 Fair Street, Finderne, Maine, 7344"",
        ""about"": ""Pariatur duis quis fugiat proident sint qui fugiat elit aliquip cillum culpa. Incididunt commodo officia velit cillum nulla proident et eu eiusmod magna. Tempor enim enim quis mollit laborum qui exercitation qui. Exercitation proident incididunt dolore aute laborum ex Lorem ea magna amet magna aliqua labore. Consequat dolore ea amet aute labore minim ad. Nulla laborum dolor ea ut.\r\n"",
        ""registered"": ""1993-10-31T22:44:59 -01:00"",
        ""latitude"": 67.965019,
        ""longitude"": -158.978775,
        ""tags"": [
            ""adipisicing"",
            ""dolore"",
            ""laboris"",
            ""est"",
            ""quis"",
            ""velit"",
            ""cillum""
        ],
        ""friends"": [
            {
                ""id"": 0,
                ""name"": ""Taylor Contreras""
            },
            {
                ""id"": 1,
                ""name"": ""Leona Barber""
            },
            {
                ""id"": 2,
                ""name"": ""Jarvis Logan""
            }
        ],
        ""randomArrayItem"": ""apple""
    },
    {
        ""id"": 2,
        ""guid"": ""cf9a8c5f-830c-41d7-aa96-cceaa6f2ef71"",
        ""isActive"": false,
        ""balance"": ""$2,287.00"",
        ""picture"": ""http://placehold.it/32x32"",
        ""age"": 24,
        ""name"": ""Kane Holman"",
        ""gender"": ""male"",
        ""company"": ""Zentury"",
        ""email"": ""kaneholman@zentury.com"",
        ""phone"": ""+1 (916) 599-2881"",
        ""address"": ""765 Lee Avenue, Keller, New Mexico, 515"",
        ""about"": ""Ut magna aute sint amet mollit ex do pariatur dolor. Deserunt deserunt esse voluptate deserunt adipisicing fugiat ullamco. Id aliqua anim consequat nulla laboris consequat minim nisi eiusmod. Laboris irure excepteur sint excepteur ipsum. Ea officia eiusmod nisi voluptate cupidatat laborum sint velit labore. Exercitation excepteur et commodo est Lorem anim reprehenderit.\r\n"",
        ""registered"": ""1991-09-24T12:45:49 -02:00"",
        ""latitude"": 41.437124,
        ""longitude"": 135.496317,
        ""tags"": [
            ""consequat"",
            ""incididunt"",
            ""eu"",
            ""minim"",
            ""ut"",
            ""labore"",
            ""esse""
        ],
        ""friends"": [
            {
                ""id"": 0,
                ""name"": ""Bolton Hamilton""
            },
            {
                ""id"": 1,
                ""name"": ""Lewis Welch""
            },
            {
                ""id"": 2,
                ""name"": ""Eve Patterson""
            }
        ],
        ""randomArrayItem"": ""lemon""
    },
    {
        ""id"": 3,
        ""guid"": ""e80dd21a-5fe1-4550-b898-f77453414c1e"",
        ""isActive"": false,
        ""balance"": ""$1,854.00"",
        ""picture"": ""http://placehold.it/32x32"",
        ""age"": 36,
        ""name"": ""Jordan Roth"",
        ""gender"": ""female"",
        ""company"": ""Elita"",
        ""email"": ""jordanroth@elita.com"",
        ""phone"": ""+1 (934) 418-2667"",
        ""address"": ""601 Cherry Street, Belfair, Texas, 100"",
        ""about"": ""Elit consequat magna velit culpa qui enim nostrud proident ad aliqua. Dolore deserunt cillum enim ut tempor. Anim ex et ea incididunt ullamco. Et do sint consectetur id culpa. Exercitation mollit eiusmod excepteur aliquip Lorem do ipsum nostrud ex exercitation amet nulla id est.\r\n"",
        ""registered"": ""1996-01-06T11:11:32 -01:00"",
        ""latitude"": -21.441892,
        ""longitude"": 110.727217,
        ""tags"": [
            ""sint"",
            ""anim"",
            ""cillum"",
            ""tempor"",
            ""laboris"",
            ""duis"",
            ""ipsum""
        ],
        ""friends"": [
            {
                ""id"": 0,
                ""name"": ""Russo Long""
            },
            {
                ""id"": 1,
                ""name"": ""Davidson Knight""
            },
            {
                ""id"": 2,
                ""name"": ""Callie Mathis""
            }
        ],
        ""randomArrayItem"": ""cherry""
    },
    {
        ""id"": 4,
        ""guid"": ""a5038f20-ddab-4405-93ca-6fc97f684409"",
        ""isActive"": false,
        ""balance"": ""$3,193.00"",
        ""picture"": ""http://placehold.it/32x32"",
        ""age"": 35,
        ""name"": ""Hillary Bowen"",
        ""gender"": ""female"",
        ""company"": ""Anixang"",
        ""email"": ""hillarybowen@anixang.com"",
        ""phone"": ""+1 (823) 576-3424"",
        ""address"": ""897 Seabring Street, Saranap, Delaware, 1039"",
        ""about"": ""Laborum exercitation excepteur ad nulla enim Lorem non veniam exercitation incididunt tempor. Labore sunt nostrud eu consequat mollit consectetur. Id do nulla excepteur ea occaecat laborum labore Lorem mollit eiusmod est. Non amet anim esse irure qui dolore id laboris officia ad consectetur aliquip. Tempor pariatur eiusmod qui esse quis aute tempor veniam voluptate magna eiusmod nulla sit ex. Qui consectetur incididunt ex esse id et excepteur amet incididunt dolore ipsum. Irure eu adipisicing excepteur deserunt labore mollit cillum exercitation.\r\n"",
        ""registered"": ""1994-09-15T07:05:43 -02:00"",
        ""latitude"": -64.750002,
        ""longitude"": -72.316754,
        ""tags"": [
            ""quis"",
            ""et"",
            ""tempor"",
            ""ex"",
            ""eiusmod"",
            ""ut"",
            ""minim""
        ],
        ""friends"": [
            {
                ""id"": 0,
                ""name"": ""Stein Perry""
            },
            {
                ""id"": 1,
                ""name"": ""Tina Hendrix""
            },
            {
                ""id"": 2,
                ""name"": ""Sharpe Caldwell""
            }
        ],
        ""randomArrayItem"": ""apple""
    },
    {
        ""id"": 5,
        ""guid"": ""7d90007d-60d9-425c-a0b5-0cfc5a1a3ece"",
        ""isActive"": true,
        ""balance"": ""$3,233.00"",
        ""picture"": ""http://placehold.it/32x32"",
        ""age"": 27,
        ""name"": ""Mueller Adkins"",
        ""gender"": ""male"",
        ""company"": ""Enjola"",
        ""email"": ""muelleradkins@enjola.com"",
        ""phone"": ""+1 (993) 509-3947"",
        ""address"": ""479 Wilson Avenue, Winchester, Colorado, 4296"",
        ""about"": ""Dolor culpa id id dolore. Voluptate consequat cupidatat excepteur ex adipisicing sint. Ipsum laboris ea ad occaecat ad.\r\n"",
        ""registered"": ""1999-06-21T18:52:52 -02:00"",
        ""latitude"": -0.631034,
        ""longitude"": -2.618075,
        ""tags"": [
            ""magna"",
            ""qui"",
            ""aliquip"",
            ""consequat"",
            ""occaecat"",
            ""ex"",
            ""culpa""
        ],
        ""friends"": [
            {
                ""id"": 0,
                ""name"": ""Conway Brady""
            },
            {
                ""id"": 1,
                ""name"": ""Deena Sharp""
            },
            {
                ""id"": 2,
                ""name"": ""Phoebe Fleming""
            }
        ],
        ""randomArrayItem"": ""apple""
    }
]";
        }

    }
}
