using Plivo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace CallTheWhiteHouse
{
    class Program
    {
        private const string UserPhoneNumber = "1xxxxxxxxxx";
        private const string AuthId = "";
        private const string AuthToken = "";
        static int[] areacodes = { 201,
                                    202,
                                    203,
                                    204,
                                    205,
                                    206,
                                    207,
                                    208,
                                    209,
                                    210,
                                    212,
                                    213,
                                    214,
                                    215,
                                    216,
                                    217,
                                    218,
                                    219,
                                    220,
                                    223,
                                    224,
                                    225,
                                    226,
                                    228,
                                    229,
                                    231,
                                    234,
                                    236,
                                    239,
                                    240,
                                    242,
                                    246,
                                    248,
                                    249,
                                    250,
                                    251,
                                    252,
                                    253,
                                    254,
                                    256,
                                    260,
                                    262,
                                    264,
                                    267,
                                    268,
                                    269,
                                    270,
                                    272,
                                    276,
                                    279,
                                    281,
                                    284,
                                    289,
                                    301,
                                    302,
                                    303,
                                    304,
                                    305,
                                    306,
                                    307,
                                    308,
                                    309,
                                    310,
                                    312,
                                    313,
                                    314,
                                    315,
                                    316,
                                    317,
                                    318,
                                    319,
                                    320,
                                    321,
                                    323,
                                    325,
                                    330,
                                    331,
                                    332,
                                    334,
                                    336,
                                    337,
                                    339,
                                    340,
                                    343,
                                    345,
                                    346,
                                    347,
                                    351,
                                    352,
                                    360,
                                    361,
                                    364,
                                    365,
                                    367,
                                    380,
                                    385,
                                    386,
                                    401,
                                    402,
                                    403,
                                    404,
                                    405,
                                    406,
                                    407,
                                    408,
                                    409,
                                    410,
                                    412,
                                    413,
                                    414,
                                    415,
                                    416,
                                    417,
                                    418,
                                    419,
                                    423,
                                    424,
                                    425,
                                    430,
                                    431,
                                    432,
                                    434,
                                    435,
                                    437,
                                    438,
                                    440,
                                    441,
                                    442,
                                    443,
                                    445,
                                    450,
                                    456,
                                    458,
                                    463,
                                    469,
                                    470,
                                    473,
                                    475,
                                    478,
                                    479,
                                    480,
                                    484,
                                    500,
                                    501,
                                    502,
                                    503,
                                    504,
                                    505,
                                    506,
                                    507,
                                    508,
                                    509,
                                    510,
                                    512,
                                    513,
                                    514,
                                    515,
                                    516,
                                    517,
                                    518,
                                    519,
                                    520,
                                    530,
                                    531,
                                    533,
                                    534,
                                    539,
                                    540,
                                    541,
                                    544,
                                    548,
                                    551,
                                    559,
                                    561,
                                    562,
                                    563,
                                    564,
                                    566,
                                    567,
                                    570,
                                    571,
                                    573,
                                    574,
                                    575,
                                    577,
                                    579,
                                    580,
                                    581,
                                    585,
                                    586,
                                    587,
                                    600,
                                    601,
                                    602,
                                    603,
                                    604,
                                    605,
                                    606,
                                    607,
                                    608,
                                    609,
                                    610,
                                    612,
                                    613,
                                    614,
                                    615,
                                    616,
                                    617,
                                    618,
                                    619,
                                    620,
                                    623,
                                    626,
                                    628,
                                    629,
                                    630,
                                    631,
                                    636,
                                    639,
                                    640,
                                    641,
                                    646,
                                    647,
                                    649,
                                    650,
                                    651,
                                    657,
                                    658,
                                    660,
                                    661,
                                    662,
                                    664,
                                    667,
                                    669,
                                    670,
                                    671,
                                    678,
                                    680,
                                    681,
                                    682,
                                    684,
                                    700,
                                    701,
                                    702,
                                    703,
                                    704,
                                    705,
                                    706,
                                    707,
                                    708,
                                    709,
                                    710,
                                    712,
                                    713,
                                    714,
                                    715,
                                    716,
                                    717,
                                    718,
                                    719,
                                    720,
                                    721,
                                    724,
                                    725,
                                    726,
                                    727,
                                    731,
                                    732,
                                    734,
                                    737,
                                    740,
                                    743,
                                    747,
                                    754,
                                    757,
                                    758,
                                    760,
                                    762,
                                    763,
                                    765,
                                    767,
                                    769,
                                    770,
                                    772,
                                    773,
                                    774,
                                    775,
                                    778,
                                    779,
                                    780,
                                    781,
                                    782,
                                    784,
                                    785,
                                    786,
                                    787,
                                    900,
                                    901,
                                    902,
                                    903,
                                    904,
                                    905,
                                    906,
                                    907,
                                    908,
                                    909,
                                    910,
                                    911,
                                    912,
                                    913,
                                    914,
                                    915,
                                    916,
                                    917,
                                    918,
                                    919,
                                    920,
                                    925,
                                    928,
                                    929,
                                    930,
                                    931,
                                    934,
                                    936,
                                    937,
                                    938,
                                    939,
                                    940,
                                    941,
                                    947,
                                    949,
                                    951,
                                    952,
                                    954,
                                    956,
                                    959,
                                    970,
                                    971,
                                    972,
                                    973,
                                    978,
                                    979,
                                    980,
                                    984,
                                    985,
                                    986,
                                    989};

        static string memme = "";
        static void Main(string[] args)
        {

            var api = new PlivoApi(AuthId, AuthToken);
            Timer t = new Timer(60000);
            t.Elapsed += T_Elapsed;
            //t.Start();
            string input1 = "";
            do
            {
                Console.Write(Environment.NewLine + ">");
                input1 = Console.ReadLine();
                if (input1 == "x")
                {
                    break;
                }
                else if (input1 == "startt")
                {
                    t.Start();
                }
                else if (input1 == "stopt")
                {
                    t.Stop();
                }
                else if (input1 == "ti")
                {
                    Console.WriteLine("New timer Interval>");
                    Double i = 15;
                    if (Double.TryParse(Console.ReadLine(), out i))
                    {
                        t.Interval = i*1000;
                        Console.WriteLine("New Timer Set to {0} seconds.", t.Interval / 1000);
                    }
                }
                else if (input1 == "sm")
                {
                    try
                    {
                        var x = api.Conference.List();
                        var cn = x.Conferences[0];
                        foreach (var mem in api.Conference.Get(cn).Members)
                        {
                            Console.WriteLine(mem.MemberId); ;
                            memme = mem.MemberId;
                            api.Call.StartRecording(mem.CallUuid,1440);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                else if (input1 == "l")
                {
                    try
                    {
                        var x = api.Conference.List();
                        var cn = x.Conferences[0];
                        foreach (var mem in api.Conference.Get(cn).Members)
                        {
                            Console.WriteLine(mem.MemberId); ;
                        }
                    } catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
                else if (input1 == "m")
                {
                    var response = api.Call.Create(
                        to: new List<String> { UserPhoneNumber },
                        from: GetRandomTelNo(),
                        answerMethod: "GET",
                        answerUrl: "https://phlorunner.plivo.com/v1/account/MAYTE2YWY1OGVMZGVLYJ/phlo/8432e26d-18b2-4bac-b222-7fe445c7c418" // "https://phlorunner.plivo.com/v1/account/MAYTE2YWY1OGVMZGVLYJ/phlo/236a4eee-bc34-4b51-82ce-2e2195e69a41"
                    );
                    Console.WriteLine(response);
                }
                else if (input1 == "da")
                {
                    try
                    {
                        var x = api.Conference.List();
                        var cn = x.Conferences[0];
                        foreach (var mem in api.Conference.Get(cn).Members)
                        {
                            Console.WriteLine(mem.MemberId); ;
                            if (memme != mem.MemberId)
                            {
                                api.Conference.HangupMember(cn, mem.MemberId);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }

                }
                else if (input1 == "del")
                {
                    try
                    {
                        var x = api.Conference.List();
                        api.Conference.Delete(x.Conferences[0]);
                    }
                    catch { }
                }
                else
                {
                    var response = api.Call.Create(
                        to: new List<String> { "12024561414" },
                        from: GetRandomTelNo(),
                        answerMethod: "GET",
                        answerUrl: "https://phlorunner.plivo.com/v1/account/MAYTE2YWY1OGVMZGVLYJ/phlo/8432e26d-18b2-4bac-b222-7fe445c7c418" // "https://phlorunner.plivo.com/v1/account/MAYTE2YWY1OGVMZGVLYJ/phlo/236a4eee-bc34-4b51-82ce-2e2195e69a41"
                    );
                    Console.WriteLine(response);
                }
            } while (true);
        }

        private async static void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            CallHim();

        }

        static string memid = "";

        static Queue<String> Calls = new Queue<string>(10);
        static void CallHim()
        {
            var api = new PlivoApi(AuthId, AuthToken);

            try
            {
                string uuid = Calls.Peek();
                Console.WriteLine("Call Ended By: {0}",api.Call.Get(uuid).HangupSource);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            var response = api.Call.Create(
                to: new List<String> { "12024561414" },
                from: GetRandomTelNo(),
                answerMethod: "GET",
                answerUrl: "https://phlorunner.plivo.com/v1/account/MAYTE2YWY1OGVMZGVLYJ/phlo/236a4eee-bc34-4b51-82ce-2e2195e69a41"
            );
            memid = response.RequestUuid;
            Calls.Enqueue(response.RequestUuid);
            if (Calls.Count > 10) Calls.Dequeue();
            Console.WriteLine(response);
        }


        static Random rand = new Random();
        static string GetRandomTelNo()
        {
            StringBuilder telNo = new StringBuilder(12);
            int number;
            telNo = telNo.Append("1");
            number = areacodes[rand.Next(0, areacodes.Length-1)];
            telNo = telNo.Append(String.Format("{0:D3}", number));
            number = rand.Next(0, 743); // number between 0 (incl) and 743 (excl)
            telNo = telNo.Append(String.Format("{0:D3}", number));
            number = rand.Next(0, 10000); // number between 0 (incl) and 10000 (excl)
            telNo = telNo.Append(String.Format("{0:D4}", number));
            Console.WriteLine("Calling From: {0}", telNo.ToString());
            return telNo.ToString();
        }
    }
}
