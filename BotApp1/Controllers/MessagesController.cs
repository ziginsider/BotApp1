using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.Bot.Connector;
using Newtonsoft.Json;
using BotApp1.OpenWeatherMap;
using BotApp1.Generator;
using System.Text;

namespace BotApp1
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        public async Task<HttpResponseMessage> Post([FromBody]Activity activity)
        {
            if (activity.Type == ActivityTypes.Message)
            {
                ConnectorClient connector = new ConnectorClient(new Uri(activity.ServiceUrl));
                // calculate something for us to return
                //int length = (activity.Text ?? string.Empty).Length;

                var replyText = await Reply(activity.Text);

                // return our reply to the user
                Activity reply = activity.CreateReply(replyText);
                await connector.Conversations.ReplyToActivityAsync(reply);
            }
            else
            {
                HandleSystemMessage(activity);
            }
            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }



        string NextTo(string[] str, string pat)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == pat) return str[i + 1];
            }
            return "";
        }

        bool IsPresent(string[] str, string pat)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == pat) return true;
            }
            return false;
        }
        enum Measurement { Temp = 1, Humidity = 2, Pressure = 4, None = 0 };

        WeatherClient OWM = new WeatherClient("42ec5c3a4c118c7f417109879bf7d9d9");
        private async Task<string> Reply(string msg)
        {
            string city = "Minsk";
            int when = 0;
            string whens = "today";
            string layl = ""; //фраза на подарки
            Measurement mes = Measurement.None;
            RandomClass rand = new RandomClass();
            var a = msg.ToLower().Split(' ');
            if (IsPresent(a, "help"))
            {
                return @"This is a simple weather bot.
                        Example of commands include:
                          temperature today
                          temperature in Moscow
                          humidity tomorrow";
            }
            if (IsPresent(a, "temperature")) mes |= Measurement.Temp;
            if (IsPresent(a, "humidity")) mes |= Measurement.Humidity;
            if (IsPresent(a, "pressure")) mes |= Measurement.Pressure;
            if (IsPresent(a, "today")) { when = 0; whens = "today"; }
            if (IsPresent(a, "tomorrow")) { when = 1; whens = "tomorrow"; }
            if (NextTo(a, "in") != "") city = NextTo(a, "in");
            var res = await OWM.Forecast(city);
            var r = res[when];

            if (IsPresent(a, "микола") || IsPresent(a, "миколу") || IsPresent(a, "миколу?") || IsPresent(a, "микола?"))
            {
                layl += "Так, я ведаю Мiколу. Але, пачакайце... ёсць яшчэ Ыкола. Гэта не адзiн и той жа чалавек?";
            }
           



            #region Gabe
            int choise = rand.GetIntNumber(100);

            
            if (NextTo(a, "падарыць") == "оле" || NextTo(a, "падарыць") == "оле?")
            {
                if (choise < 50) //именительный падеж
                {
                    layl += rand.GetResultOlyaGabe_1();
                }
                if (choise >= 50) //винительный падеж
                {
                    layl += rand.GetResultOlyaGabe_2();
                }
            }
            #endregion

            StringBuilder sb = new StringBuilder();
            if ((mes & Measurement.Temp) > 0)
            {
                sb.Append($"The temperature on {r.Date} in {city} is {r.Temp}\r\n");
            }
            if ((mes & Measurement.Pressure) > 0)
            {
                sb.Append($"The pressure on {r.Date} in {city} is {r.Pressure}\r\n");
            }
            if ((mes & Measurement.Humidity) > 0)
            {
                sb.Append($"Humidity on {r.Date} in {city} is {r.Humidity}\r\n");
            }

            if (!String.IsNullOrEmpty(layl))
            {
                sb.Append("\r\n" + layl + "\r\n");
            }

            if (sb.Length == 0) return "I do not understand";
            else return sb.ToString();
        }

        private Activity HandleSystemMessage(Activity message)
        {
            if (message.Type == ActivityTypes.DeleteUserData)
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == ActivityTypes.ConversationUpdate)
            {
                // Handle conversation state changes, like members being added and removed
                // Use Activity.MembersAdded and Activity.MembersRemoved and Activity.Action for info
                // Not available in all channels
            }
            else if (message.Type == ActivityTypes.ContactRelationUpdate)
            {
                // Handle add/remove from contact lists
                // Activity.From + Activity.Action represent what happened
            }
            else if (message.Type == ActivityTypes.Typing)
            {
                // Handle knowing tha the user is typing
            }
            else if (message.Type == ActivityTypes.Ping)
            {
            }

            return null;
        }
    }
}