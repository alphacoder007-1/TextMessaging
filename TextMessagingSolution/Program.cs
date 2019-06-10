using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace TextMessagingSolution
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string accountSid = "AC2804821ac2dd12849c23d887eccd0ed2";
            const string authToken = "7585c16d82698012385ab1c8b9d7746b";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Hello Text Message from Mahesh Shivaswamy",
                from: new Twilio.Types.PhoneNumber("+19728488535"),
                to: new Twilio.Types.PhoneNumber("+14693864803")
            );

            Console.WriteLine(message.Sid);
        }
    }
}
