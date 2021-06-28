using System;
using System.Collections;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Trivia4NET;
using Trivia4NET.Entities;


namespace SideBot {
  class Program {
    static ITelegramBotClient botClient;
    static async Task Main() {
    botClient = new TelegramBotClient(Secrets.BotKey);
            //Instantiates and populates a shuffled deck of cards.
            

            //deck.PrintDeck();
            deck.PickOneCard();


            var me = botClient.GetMeAsync().Result;
    Console.WriteLine(
        $"Hello, World! I am user {me.Id} and my name is {me.FirstName}."
      );

            //             Message pollMessage = await botClient.SendPollAsync(
            //     chatId: "-574750167",
            //     question: "Did you ever hear the tragedy of Darth Plagueis The Wise?",
            //     options: new []
            //     {
            //         "Yes for the hundredth time!",
            //         "No, who`s that?"
            //     }
            // );

            // Dice dice = await botClient2.SendDiceAsync(

            //   allowSendingWithoutReply: true
            // );



      botClient.OnMessage += Bot_OnMessage;
      botClient.StartReceiving();

      Console.WriteLine("Press any key to exit");
      Console.Read();

      botClient.StopReceiving();
    }

  /*  http://jservice.io/popular
      jeopardy api */

    static async void Bot_OnMessage(object sender, MessageEventArgs e) 
    {
      if (e.Message.Text == "/hitme")
      {
        Console.WriteLine($"Beginning blackjack.");
        await botClient.SendTextMessageAsync(
          chatId: e.Message.Chat,
          text:   "You said:\n" + e.Message.Text
        );
      }
    }
  }
}