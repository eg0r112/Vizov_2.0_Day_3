using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;
using System.Threading;
using Microsoft.VisualBasic;
using System.Timers;
using TimerThreading = System.Threading.Timer;
using System.Globalization;

class Program
{
    //static string exePath = AppDomain.CurrentDomain.BaseDirectory;
    public string filePath;
    //private static Timer _timer;
    private static ITelegramBotClient client1;
    public static long id;
    public static string zadacham, date;
    static DateTime date1 = new DateTime();
    static DateTime date2 = DateTime.Now;
    static string d1, d2;
    static async Task Main()
    {
        var timer12 = new System.Timers.Timer(3000);
        timer12.Elapsed += (sender, e) => KD();
        timer12.AutoReset = false;
        timer12.Start();
        exePath = AppDomain.CurrentDomain.BaseDirectory;
        //_timer = new Timer(OnTimedEvent, null, 0, 30000);

        string filePath = (exePath + "users.txt");
        if (!File.Exists(filePath))
        {
            File.CreateText(filePath);
        }
        client1 = new TelegramBotClient("7447477979:AAEGPG7DBqnXBSTWoEH76FQUejLW3XZB8qI");
        client1.StartReceiving(Update, Error);
        Console.ReadLine();
    }
    static string exePath = AppDomain.CurrentDomain.BaseDirectory;
    public static int s, s1, s2, s3, s4,s5,s6, dat1H, dat1M, dat2H, dat2M;
    public static string date11, date12;
    public static void KD()
    {
        s4 = 0;
        s6 = 0;
        s5 = -1;
        s = 0;
        lines = File.ReadAllLines(exePath + "users.txt");
        foreach (string line in lines)
        {
            s5++;
                s++;
            if (line.Replace(" ", "\n") == "nachalo3312_p")
            {
                s6 = 0;
                //Console.WriteLine("айди");
                try
                {
                    id = long.Parse(lines[s]);
                }
                catch { }
            }
            if (line.Replace(" ", "\n") == "con3312_p" & s2 == 1)
            {
                s2 = 0;
                s1 = 0;
                var lines = File.ReadAllLines(exePath + "users.txt").ToList();
                lines[s5] = " ";
                // Удаляем пустые строки и строки, состоящие только из пробелов
                lines = lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToList();

                // Записываем оставшиеся строки обратно в файл
                File.WriteAllLines(exePath + "users.txt", lines);
                SendMessage();
                Console.WriteLine("EDDDDDDD");
                KD();
                break;
            }
            if (s2==1)
            {
                //Console.WriteLine("лайн");
                zadacham = zadacham + $"{line}\n";
                    try
                {
                    lines[s5 - 2] = " ";
                    lines[s5 - 1] = " ";
                    lines[s5] = " ";
                }
                catch { }
                File.WriteAllLines(exePath + "users.txt", lines);
            }
            if(s1==1)
            {
                //Console.WriteLine("проверка");
                if (!string.IsNullOrEmpty(line) && line.Length >= 5)
                {
                    try
                    {
                        date = lines[s5].Replace(" ", "\n").Substring(0, 5);
                    }
                    catch { }
                }
                Console.WriteLine($"{date} ДАТА");
                date11 = date.Substring(0, 2);
                date12 = date.Substring(date.Length - 2);
                Console.WriteLine($"{date11} {date12}");
                try
                {
                    dat1H = Convert.ToInt32(date11.Trim());
                    dat1M = Convert.ToInt32(date12.Trim());
                }
                catch { }
                dat1M = dat1M + (dat1H * 60);
                dat2M = date2.Minute;
                dat2H = date2.Hour;
                dat2M = dat2M + (dat2H * 60);
                if (dat1M <= dat2M)
                {
                    s2 = 1;
                }
                s4 = 1;
                s1 = 0;

            }
            if (line.Replace(" ", "\n") == "nap3312_p")
            {
                s6++;
                //Console.WriteLine("нач");
                s1 = 1;
            }
        }
        var timer12 = new System.Timers.Timer(30000);
        timer12.Elapsed += (sender, e) => KD();
        timer12.AutoReset = false;
        timer12.Start();
    }
    public static void SendMessage()
    {
        //id = 5143241640;
        SendMessage(id, zadacham);
    }
    private static async Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
    {

    }
    public static int oker = 0;
    public static int oker1 = 0;
    public static int oker2 = 0;
    public static int oker3 = 0;
    public static int oker4 = 0;
    public static int i;
    public static string vse;
    public static string[] lines;
    public static int vibor;
    private static async Task Update(ITelegramBotClient Botclient, Update update, CancellationToken token)
    {
        Program pro = new Program();
        var massange = update.Message;
        Console.WriteLine(massange.Chat.Id);
        if (massange.Text != null)
        {
            if (massange.Text.Replace(" ", "").Substring(0, 4) == "/add")
            {
                await Botclient.SendTextMessageAsync(massange.Chat.Id, "Строй планы дальше!");
                Console.WriteLine(massange.Text.Replace("/add ", ""));
                //Zapisi zap = new Zapisi(oker, massange.Text, massange.Text);
                i = -1;
                oker = 1;
                lines = File.ReadAllLines(exePath + "users.txt");
                foreach (string line in lines)
                {
                    i++;
                    if (line.Replace(" ", "\n") == "nachalo3312_p")
                    {
                        oker1 = 1;
                        oker1 = 1;
                        oker2 = 0;
                        oker = 1;
                    }
                    if (line.Replace(" ", "\n") == "conec3312_p" & oker2==1)
                    {
                        string filePath = (exePath + "users.txt");
                        string textToAppend = $"nap3312_p\n{massange.Text.Substring(massange.Text.Length - 5)}\n{oker}. {massange.Text.Substring(4)}\ncon3312_p";
                        lines[i] = $"{textToAppend}\nconec3312_p";
                        File.WriteAllLines(filePath, lines);
                        oker1 = 0;
                        oker2 = 0;
                        oker = 1;
                        break;
                    }
                    //if(oker2==1)
                    //{
                    //    if (line != "nap3312_p" & line != "con3312_p")
                    //    {
                    //        vse = vse + $"{line}\n";
                    //    }
                    //}
                    if (line.Replace(" ", "\n") == "con3312_p" & oker2==1)
                    {
                        oker++;
                    }
                    if (line.Replace(" ", "\n") == massange.Chat.Id.ToString() & oker1 == 1)
                    {
                        oker2 = 1;
                        oker3 = 1;
                    }
                }
                if (oker3 == 0)
                {
                    string filePath = (exePath + "users.txt");
                    string newLine = $"nachalo3312_p\n{massange.Chat.Id.ToString()}\nnap3312_p\n{massange.Text.Substring(massange.Text.Length - 5)}\n{oker}. {massange.Text.Substring(4)}\ncon3312_p\nconec3312_p";
                    File.AppendAllText(filePath, newLine + Environment.NewLine);
                }
                oker3 = 0;
                oker1 = 0;
                oker2 = 0;
                oker = 1;
                return;
            }
            if (massange.Text.Replace(" ", "").Substring(0, 5) == "/list")
            {
                await Botclient.SendTextMessageAsync(massange.Chat.Id, "Стремись к успеху!");
                vse = "Список ваших задач:\n";
                Console.WriteLine(massange.Text.Replace("/list ", ""));

                //Zapisi zap = new Zapisi(oker, massange.Text, massange.Text);

                //string filePath = (exePath + "users.txt");
                //string textToAppend = $"{oker} {massange.Text}";
                //File.AppendAllText(filePath, textToAppend + Environment.NewLine);
                lines = File.ReadAllLines(exePath + "users.txt");
                foreach (string line in lines)
                {
                    if (line.Replace(" ", "\n") == "nachalo3312_p")
                    {
                        Console.WriteLine("нашёл начало");
                        oker1 = 1;
                        oker2 = 0;
                    }
                    if (line.Replace(" ", "\n") == "conec3312_p" & oker2==1)
                    {
                        Console.WriteLine("нашёл конец");
                        oker1 = 0;
                        oker2 = 0;
                        await Botclient.SendTextMessageAsync(massange.Chat.Id, vse);
                        vse = null;
                        break;
                    }
                    if (oker2 == 1)
                    {
                        if (line.Replace(" ", "\n") != "nap3312_p" & line.Replace(" ", "\n") != "con3312_p")
                        {
                            Console.WriteLine("строка не равна тех строкам");
                            vse = vse + $"{line}\n";
                        }
                    }
                    if (line.Replace(" ", "\n") == massange.Chat.Id.ToString() & oker1 == 1)
                    {
                        Console.WriteLine("айди совпал");
                        oker2 = 1;
                        oker3 = 1;
                    }
                }
                if (oker3 == 0)
                {
                    await Botclient.SendTextMessageAsync(massange.Chat.Id, "К сожалению у вас нету ещё не 1 запланированного события. Вы можете добавить их с помошью команды /add (задача) ЧЧ:ММ");
                }
                oker3 = 0;
                oker1 = 0;
                oker2 = 0;
                oker = 1;
                return;
            }
            if (massange.Text.Replace(" ", "").Substring(0, 6) == "/start")
            {
                await Botclient.SendTextMessageAsync(massange.Chat.Id, "Приветствую вас в свём тестовом боте! Бот получился далеко не идеальным, поэтому при неработоспособности какой либо функции либо перезапустите бота либо обратитесь к другой функции и вернитесь к этой позже. На случай если список задач сломается создана команда /deleteAll - она очищает ваш список задач и вы можете составить его с нуля. Так же не рекомендую пользоваться командой /delete (номер задачи) так как она получилась немного сломанной. Также вы можете добавить задачи с помошью команды /add (задача) ЧЧ: ММ  . А увидеть список всех задач вам поможет команда /list  . По всем вопросам писать @Marix929");
            }
            if (massange.Text.Replace(" ", "").Substring(0, 7) == "/delete")
            {
                await Botclient.SendTextMessageAsync(massange.Chat.Id, "Ты стёр маленький кусочек своей жизни, молодец!");
                oker3 = 0;
                oker1 = 0;
                oker2 = 0;
                oker = 1;
                oker4 = 0;
                i = -1;
                lines = File.ReadAllLines(exePath + "users.txt");
                foreach (string line in lines)
                {
                    i++;
                    if (line.Replace(" ", "\n") == "nachalo3312_p")
                    {
                        oker1 = 1;
                        oker1 = 1;
                        oker2 = 0;
                        oker = 0;
                    }
                    if (line.Replace(" ", "\n") == massange.Chat.Id.ToString() & oker1 == 1)
                    {
                        oker2 = 1;
                        oker3 = 1;
                    }
                    if(line.Replace(" ", "\n") == "nap3312_p" || line.Replace(" ", "\n") == "conec3312_p")
                    {
                        oker++;
                    }
                    char lastChar = massange.Text[massange.Text.Length - 1];
                        oker4 = (int)char.GetNumericValue(lastChar);
                        Console.WriteLine(oker);
                    Console.WriteLine(oker4);
                    if(line.Replace(" ", "\n") == "con3312_p")
                    {
                        if (lines[i+1] != "conec3312_p"|| lines[i + 1] != "nap3312_p")
                        {
                            var linis = File.ReadAllLines(exePath + "users.txt");

                            // Проверяем, что индекс находится в допустимом диапазоне
                            if (i < 0 || i >= linis.Length)
                            {
                                Console.WriteLine("Ошибка: индекс строки вне диапазона.");
                                return;
                            }

                            // Удаляем строку по индексу
                            var updatedLines = new List<string>(linis);
                            updatedLines.RemoveAt(i);

                            // Записываем оставшиеся строки обратно в файл
                            File.WriteAllLines(exePath + "users.txt", updatedLines);
                        }
                    }
                    if (oker==oker4)
                    {
                        var linis = File.ReadAllLines(exePath + "users.txt");

                        // Проверяем, что индекс находится в допустимом диапазоне
                        if (i < 0 || i >= linis.Length)
                        {
                            Console.WriteLine("Ошибка: индекс строки вне диапазона.");
                            return;
                        }

                        // Удаляем строку по индексу
                        var updatedLines = new List<string>(linis);
                        updatedLines.RemoveAt(i);

                        // Записываем оставшиеся строки обратно в файл
                        File.WriteAllLines(exePath + "users.txt", updatedLines);
                    }
                }
            }
            if (massange.Text.Replace(" ", "").Substring(0, 10) == "/deleteAll")
            {
                await Botclient.SendTextMessageAsync(massange.Chat.Id, "Ты уничтожил несостоявшуюся историю...");
                lines = File.ReadAllLines(exePath + "users.txt");
                foreach (string line in lines)
                {
                    if (line.Replace(" ", "\n") == "nachalo3312_p")
                    {
                        oker1 = 1;
                        if (lines[oker1 + 1] == massange.Chat.Id.ToString())
                        {
                            oker2 = 1;
                        }
                    }
                    if (line.Replace(" ", "\n") == "conec3312_p")
                    {
                        var lis = File.ReadAllLines(exePath + "users.txt");

                        // Проверяем, что индекс находится в допустимом диапазоне
                        if (oker1-1 < 0 || oker1-1 >= lis.Length)
                        {
                            Console.WriteLine("Ошибка: индекс строки вне диапазона.");
                            return;
                        }

                        // Удаляем строку по индексу
                        var updatedLines1 = new List<string>(lis);
                        updatedLines1.RemoveAt(oker1-1);

                        // Записываем оставшиеся строки обратно в файл
                        File.WriteAllLines(exePath + "users.txt", updatedLines1);
                        oker2 = 0;
                        var linis = File.ReadAllLines(exePath + "users.txt");

                        // Проверяем, что индекс находится в допустимом диапазоне
                        if (oker1 < 0 || oker1 >= linis.Length)
                        {
                            Console.WriteLine("Ошибка: индекс строки вне диапазона.");
                            return;
                        }

                        // Удаляем строку по индексу
                        var updatedLines = new List<string>(linis);
                        updatedLines.RemoveAt(oker1);

                        // Записываем оставшиеся строки обратно в файл
                        File.WriteAllLines(exePath + "users.txt", updatedLines);
                    }
                    if (oker2 == 1)
                    {
                        var linis = File.ReadAllLines(exePath + "users.txt");

                        // Проверяем, что индекс находится в допустимом диапазоне
                        if (oker1 < 0 || oker1 >= linis.Length)
                        {
                            Console.WriteLine("Ошибка: индекс строки вне диапазона.");
                            return;
                        }

                        // Удаляем строку по индексу
                        var updatedLines = new List<string>(linis);
                        updatedLines.RemoveAt(oker1);

                        // Записываем оставшиеся строки обратно в файл
                        File.WriteAllLines(exePath + "users.txt", updatedLines);
                    }
                }      
        }
        }
    }
    private static async Task SendMessage(long id, string zadacha)
    {
        try
        {
            await client1.SendTextMessageAsync(id, zadacha);
            Console.WriteLine("Сообщение отправлено!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при отправке сообщения: {ex.Message}");
        }
    }
}