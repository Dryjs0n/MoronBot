using Discord;
using Discord.WebSocket;
using Discord.Commands;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace MoronBot
{
    class Program
    {
        private DiscordSocketClient Client;
        private CommandService Commands;
        static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();
        public async Task MainAsync()
        {
            Client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Debug 
            });
            Commands = new CommandService(new CommandServiceConfig
            {
                CaseSensitiveCommands = true,
                DefaultRunMode = RunMode.Async,
                LogLevel = LogSeverity.Debug
            });
            Client.MessageReceived += Client_MessageReceived;
            await Commands.AddModulesAsync(Assembly.GetEntryAssembly());
            Client.Ready += Client_Ready;
            Client.Log += Client_Log;
            string Token = System.IO.File.ReadAllText(@"C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\Token\\Token.txt");
            await Client.LoginAsync(TokenType.Bot, Token);
            await Client.StartAsync();
            await Task.Delay(-1);
        }
        private async Task Client_Log(LogMessage Message)
        {
            Console.WriteLine($"{DateTime.Now} at {Message.Source}] {Message.Message}");
        }
        private async Task Client_Ready()
        {
            await Client.SetGameAsync("Gram w co mam", "https://www.google.com/", StreamType.NotStreaming);
        }
        private async Task Client_MessageReceived(SocketMessage MessageParam)
        {
            //Configure the commands
            var Message = MessageParam as SocketUserMessage;
            var Context = new SocketCommandContext(Client, Message);
            if(Context.Message == null || Context.Message.Content == "") return;
            if (Context.User.IsBot) return;
            int ArgPos = 0;
            if (!(Message.HasStringPrefix("m ", ref ArgPos) || Message.HasMentionPrefix(Client.CurrentUser, ref ArgPos))) return;
            var Result = await Commands.ExecuteAsync(Context, ArgPos);
            if (!Result.IsSuccess)
            {
                Console.WriteLine($"{DateTime.Now} at Commands] Something went wrong with executing a command. Text: {Context.Message.Content} | Error: {Result.ErrorReason}");
            }
        }
    }
}
