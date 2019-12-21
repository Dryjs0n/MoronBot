using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Discord;
using Discord.Commands;

namespace MoronBot.Core.Commands
{
    public class HelloWorld : ModuleBase<SocketCommandContext>
    {
        [Command("hello"), Alias("siema", "elo", "cześć", "czesc", "dzień dobry"), Summary("Hello world command")]
        public async Task Powitanie()
        {
            await Context.Channel.SendMessageAsync("Witam!");
        }
        [Command("savril"), Alias("savril"), Summary("savril")]
        public async Task Savril()
        {
            await Context.Channel.SendMessageAsync("Super zabawa");
        }
        [Command("kucharz"), Alias("szef", "adam", "Szef", "Adam"), Summary("b")]
        public async Task Adam()
        {
            Random ran = new Random();
            string[] adam = new string[7];
            adam[0] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\adam\\zolnierrz.jpg";
            adam[1] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\adam\\adam.jpeg";
            adam[2] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\adam\\1.jpg";
            adam[3] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\adam\\2.jpg";
            adam[4] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\adam\\3.jpg";
            adam[5] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\adam\\4.jpg";
            adam[6] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\adam\\5.jpg";
            await Context.Channel.SendFileAsync(adam[ran.Next(0,7)]);
        }
        [Command("adam all"), Alias("szef all", "adam all", "Szef all", "Adam all"), Summary("adam all")]
        public async Task AdamAll()
        {
            string[] adam = new string[7];
            adam[0] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\adam\\zolnierrz.jpg";
            adam[1] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\adam\\adam.jpeg";
            adam[2] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\adam\\1.jpg";
            adam[3] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\adam\\2.jpg";
            adam[4] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\adam\\3.jpg";
            adam[5] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\adam\\4.jpg";
            adam[6] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\adam\\5.jpg";
            for (int i = 0; i < adam.Length; i++)
            {
                await Context.Channel.SendFileAsync(adam[i]);
            }
        }
        [Command("virtus.pro"), Alias("bogowie", "virtus.pro", "VP", "vp", "Virtus.pro"), Summary("vp")]
        public async Task VP()
        {
            Random ran = new Random();
            string[] vp = new string[5];
            vp[0] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\vp\\byali.png";
            vp[1] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\vp\\neo.png";
            vp[2] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\vp\\pasha.png";
            vp[3] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\vp\\snaxvp.png";
            vp[4] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\vp\\taz.png";
            await Context.Channel.SendFileAsync(vp[ran.Next(0,5)]);
        }
        [Command("virtus.pro all"), Alias("vp all", "virtus.pro all", "VP all", "vp all", "Virtus.pro all", "bogowie all"), Summary("vp all")]
        public async Task VPall()
        {
            string[] vp = new string[5];
            vp[0] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\vp\\byali.png";
            vp[1] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\vp\\neo.png";
            vp[2] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\vp\\pasha.png";
            vp[3] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\vp\\snaxvp.png";
            vp[4] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\vp\\taz.png";
            for (int i = 0; i < vp.Length; i++)
            {
                await Context.Channel.SendFileAsync(vp[i]);
            }
        }
        [Command("Marcin"), Alias("Marcin", "marcin"), Summary("marcin")]
        public async Task Marcin()
        {
            Random ran = new Random();
            string[] marcin = new string[17];
            marcin[0] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\1.jpg";
            marcin[1] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\2.jpg";
            marcin[2] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\3.png";
            marcin[3] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\4.jpg";
            marcin[4] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\5.jpg";
            marcin[5] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\6.jpg";
            marcin[6] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\7.jpg";
            marcin[7] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\8.jpg";
            marcin[8] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\9.jpg";
            marcin[9] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\10.jpg";
            marcin[10] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\11.png";
            marcin[11] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\12.jpg";
            marcin[12] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\13.jpg";
            marcin[13] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\14.jpg";
            marcin[14] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\15.jpg";
            marcin[15] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\16.jpg";
            marcin[16] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\17.jpg";
            await Context.Channel.SendFileAsync(marcin[ran.Next(0,17)]);
        }
        [Command("Marcin all"), Alias("Marcin all", "marcin all"), Summary("marcin all")]
        public async Task MarcinAll()
        {
            string[] marcin = new string[17];
            marcin[0] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\1.jpg";
            marcin[1] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\2.jpg";
            marcin[2] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\3.png";
            marcin[3] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\4.jpg";
            marcin[4] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\5.jpg";
            marcin[5] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\6.jpg";
            marcin[6] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\7.jpg";
            marcin[7] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\8.jpg";
            marcin[8] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\9.jpg";
            marcin[9] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\10.jpg";
            marcin[10] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\11.png";
            marcin[11] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\12.jpg";
            marcin[12] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\13.jpg";
            marcin[13] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\14.jpg";
            marcin[14] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\15.jpg";
            marcin[15] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\16.jpg";
            marcin[16] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\marcin\\17.jpg";
            for (int i = 0; i < marcin.Length; i++)
            {
            await Context.Channel.SendFileAsync(marcin[i]);
            }
        }
        [Command("dzoki"), Alias("dzoki", "jocky"), Summary("jocky")]
        public async Task Dzoki()
        {
            Random ran = new Random();
            string[] dzoki = new string[2];
            dzoki[0] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\dzoki\\1.png";
            dzoki[1] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\dzoki\\2.png";
            await Context.Channel.SendFileAsync(dzoki[ran.Next(0,2)]);
        }
        [Command("dzoki all"), Alias("dzoki all", "jocky all"), Summary("jocky all")]
        public async Task DzokiAll()
        { 
            string[] dzoki = new string[2];
            dzoki[0] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\dzoki\\1.png";
            dzoki[1] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\dzoki\\2.png";
            for (int i = 0; i < dzoki.Length; i++)
            {
                await Context.Channel.SendFileAsync(dzoki[i]);
            }
        }
        [Command("filip"), Alias("filip", "Filip", "Jezus","Bóg"), Summary("Filip")]
        public async Task Filip()
        {
            string[] filip = new string[3];
            filip[0] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\filip\\1.jpg";
            filip[1] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\filip\\2.jpg";
            filip[2] = "C:\\Users\\fdryj\\source\\repos\\MoronBot\\MoronBot\\Core\\Data\\filip\\3.jpg";
            for (int i = 0; i < filip.Length; i++)
            {
                await Context.Channel.SendFileAsync(filip[i]);
            }
        }
    }
}
