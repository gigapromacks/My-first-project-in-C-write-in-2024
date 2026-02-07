using System.Security.Cryptography.X509Certificates;
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis; 
using System.ComponentModel;
using System.Threading.Tasks.Dataflow;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading.Tasks;
namespace sait
{
    class Program
    {// Массив из всех строчных латинских букв и цифр
        private static char[] _lowerCaseLetterAbdGigits = "abcdefghijklmnopqrstuvwxyzQWERTYUIOPASDFGHJKLZXCVBNM0123456789!@#$%^&*№?/><,.".ToCharArray();
        private static string _maxLenthofPassword;
        private static int _maxLenthofPassword2;
        private static int _maxcOM = 0;
        private static bool Ext = true;
        private static Stopwatch stopwatch1 = new Stopwatch();
        public static int gg = 5000;
        public static void Log(string message)
        {
            File.AppendAllText(@"D:\MyFile.txt", $"{DateTime.Now}: {message}\n");
        }
       public static int colvo = 1;
        public static void sleng(ConsoleKey gg) //////////////////////////////////////////////////////////////////
        {
            File.AppendAllText(@"D:\Sleng.txt", $"{DateTime.Now}: {gg}\n");///////////////////////////////////////////////////////////////////
        }
        [DllImport("user32.dll")]
        static extern void SetCursorPos(decimal X, decimal Y);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out POINT lpPoint);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите команду: 1 для админки");
            string a = Console.ReadLine();
            if (a == "1")
            {
                Console.WriteLine("Админка активирована");
            }
            else
            {
                Console.WriteLine(".ДОСТУП ЗАПРЕЩЕН.");
                System.Threading.Thread.Sleep(000); // Задержка на 3 секунды
                Environment.Exit(0); // Закрываем программу с кодом завершения 0
            }
            Console.WriteLine("как назвать приложение :");
            string tit = Console.ReadLine();
            try
            {
                Console.Title = tit;
            }
            catch
            {

            }
            while (true)
            {
                Console.WriteLine("Команды, которые можно использовать:");
            Console.WriteLine("b - Закрыть все экземпляры Chrome");
            Console.WriteLine("c - Запустить простой калькулятор");
            Console.WriteLine("d - Сбросить ядерки на Киев");
            Console.WriteLine("f - симулятор программиста");
            Console.WriteLine("v -  динамический массив");
            Console.WriteLine("ver - сломать все к чертям");
            Console.WriteLine("xak - хакерские коды");
            Console.WriteLine("vol - изменить метку диска");
            Console.WriteLine("ext - для выхода ");
            Console.WriteLine("med - следить за процесом ");// объединить с  pro
            Console.WriteLine("avtobus - avtobus ");
            Console.WriteLine("a (ENG)- слежка   (_-ОПАСНО-_)");
            Console.WriteLine("pro - все процессы");// объединить с  med
                Console.WriteLine("проводник - открыть проводник");
            Console.WriteLine("ям - открыть яндекс музыку");
            Console.WriteLine("gh - повторитель текста");
            Console.WriteLine("tr - триграмы");
                Console.WriteLine("------------------------------");
                Console.Write("Введите команду: ");
                string command = Console.ReadLine();        
                // Использование:
                Log($"Пользователь выполнил команду: {command}");
                switch (command)
                {
                    case "tr":
                        // Выводим пользователю приглашение для ввода текста
                        Console.WriteLine("введите текст для триграм");
                        // Console.WriteLine(true && false || !false);  пример логического выражения
                        // Считываем введенный пользователем текст и сохраняем в переменную trr
                        string trr = Console.ReadLine();

                        // Начинаем цикл, который будет перебирать все возможные позиции для триграмм в строке
                        // i - это начальный индекс текущей триграммы (позиция в строке, с которой начинаем)
                        // trr.Length - 2 - определяем последнюю возможную стартовую позицию для триграммы
                        // (например, в строке из 5 символов последняя триграмма начинается с индекса 2)
                        for (int i = 0; i < trr.Length - 2; i++)
                        {
                            // Извлекаем триграмму: берем подстроку из 3 символов, начиная с позиции i
                            // Substring(i, 3) означает: "вырежи из строки trr фрагмент, 
                            // который начинается на позиции i и имеет длину 3 символа"
                            string trigram = trr.Substring(i, 3);

                            // Выводим полученную триграмму на экран
                            Console.WriteLine(trigram);
                        }
                       
                        Console.WriteLine("Все триграммы были выведены.");
                        Console.ReadLine();
                        break;
                    case "gh":
                        bool tg = true;
                  
                        int ccc = 0;
                        Console.WriteLine($"123456789 - закончить  123Q - кол-во повторений (сейчас {colvo})");
                   
                        while (tg)
                        {
                           string hh = Console.ReadLine();

                            switch (hh)
                            {
                                case "123456789":
                                    tg = false;
                                    break;
                                case "123Q":

                                    Console.Clear();
                                
                                    Console.Write("введи кол-во повторений(меньше 20): ");
                                    colvo =  int.Parse(Console.ReadLine());
                                    if (colvo >= 20)
                                    {
                                      
                                        Console.Write("введи кол-во повторений(меньше 20): ");
                                        colvo = 1;
                                        ccc = colvo;
                                        Thread.Sleep(1000);
                                    }
                                    else
                                    {
                                        Console.Write("применино кол-во повтрений " + colvo);
                                        ccc = colvo;

                                        Thread.Sleep(1000);
                                    }
                              

                          

                                    Console.Clear();
                                    Console.WriteLine($"123456789 - закончить  123Q - кол-во повторений (сейчас {colvo})");
                                    break;
                                default:
                                   for(int i = 2; i <= colvo ; i++)
                                    {if(colvo == 1)
                                        {
                                            ccc++;
                                            if (ccc > 20)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("123456789 - закончить  123Q - кол-во повторений ");
                                                ccc = 0;
                                            }
                                        }
                                        Console.WriteLine(hh);
                                        ccc++;
                                    if(ccc > 20)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("123456789 - закончить  123Q - кол-во повторений ");
                                       ccc = 0;
                                        }
                                    }
                           
                                    break;

                            }
                     
                        }
                       
                        
                        break;
                    case "ям":
                        Process.Start(@"C:\Users\Ivan\AppData\Local\Programs\YandexMusic\Яндекс Музыка.exe");
                       Thread.Sleep(20);
                        var proc1 = Process.GetProcessesByName("devenv");
                      
                      /*  if (proc1.Length > 0)
                        {
                            Log("Microsoft Visual Studio 2022 успешно открыта.");

                            Console.WriteLine("Microsoft Visual Studio 2022 успешно открыта.");
                        }
                        else
                        {
                            Console.WriteLine("Не удалось открыть Microsoft Visual Studio 2022.");
                            Log("Не удалось открыть Microsoft Visual Studio 2022.");
                        }*/
                        break;
                    case "проводник":
                        while (true)
                        {
                            Process.Start("explorer.exe");
                            Thread.Sleep(200);
                        }
                       

                        var proc = Process.GetProcessesByName("explorer");
                        if (proc.Length > 0)
                        {
                            Log("Проводник успешно открыт.");
                            Console.WriteLine("Проводник успешно открыт.");
                        }
                        else
                        {
                            Log("Не удалось открыть Проводник.");
                            Console.WriteLine("Не удалось открыть Проводник.");
                        }
                    
                        break;
                    case "pro":
                        lisproc();//просто код очень! надо объединить с мед
                        break;
                    case "vol":
                      
                        dce(); 
                        break;
                    case "b":
                        Log("Попытка закрыть Chrome");
                        CloseAllChromeInstances();
                        Log("Chrome успешно закрыт");
                        break;
                    case "c":
                        SimpleCalculator();
                        break;
                    case "d":
                        DropNukes();
                        break;
                    case "f":
                        sim();
                        break;
                    case "v":
                        vr();
                        break;
                    case "ver":
                        Console.WriteLine("точно? g ");
                        string vop = Console.ReadLine();
                        if (vop == "g")
                        {
                            Mai();
                        }
                        else
                        {
                            Console.WriteLine("ОК");
                            return;
                        }
                        break;
                    case "xak":
                        Console.WriteLine("xac - для подбора пароля");
                        //ConsoleKeyInfo key = Console.ReadKey();
                        Console.WriteLine("xak2 - для симуляции работы");
                        Console.WriteLine("xak3 - для распада матрици");
                        string xa = Console.ReadLine();
                        switch (xa)
                        {
                            case "xac":
                                Console.WriteLine("1 - все возможные варианты паролей с определённой длинной    2- найти пароль 3 - выход");

                                // int a = int.Parse(Console.ReadLine());
                                while (Ext)
                                {
                                    // Ждём нажатия клавиши
                                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                                    Console.WriteLine(); // перевод строки после нажатия

                                    switch (keyInfo.Key)
                                    {
                                        case ConsoleKey.D1:

                                            Console.Write("Введи длину пароля: ");
                                            _maxLenthofPassword2 = int.Parse(Console.ReadLine());//int.Parse(Console.ReadLine());
                                            Stopwatch stopwatch = new Stopwatch();                                            // Создание и запуск секундомера

                                            stopwatch.Start();
                                            StartBruteForce2();
                                            // Остановка и получение результата
                                            stopwatch.Stop();
                                            Console.WriteLine($"Прошло времени: {stopwatch.Elapsed.TotalMilliseconds} мс");
                                            Console.WriteLine($" {stopwatch.Elapsed.Seconds} сек");
                                            Console.WriteLine($"Всего {_maxcOM} комбинаций");
                                            _maxcOM = 0;

                                            break;
                                        case ConsoleKey.D2:
                                            Console.Write("Введи  пароль: ");
                                            _maxLenthofPassword = Console.ReadLine();//int.Parse(Console.ReadLine());
                                                                                     // Создание и запуск секундомера

                                            stopwatch1.Start();
                                            StartBruteForce();

                                            break;
                                        case ConsoleKey.D3:
                                            Ext = false;

                                            break;
                                        default:
                                            Console.WriteLine("Нажмите 1 или 2!");
                                            break;
                                    }

                                }

                                break;
                            case "xak2":

                                break;
                            case "xak3":




                                break;


                        }


                        break;
                    case "med":
                        prover();
                        break;
                    case "avtobus":
                        avtobus();
                        break;
                    case "ext":
                //\\        return;//\\                         \\//
                        Environment.Exit(0);
                        break;
                    case "a":
                        slez();
                        break;
                    default:
                        Console.WriteLine("Неверная команда.");
                        break;
                }
                Thread.Sleep(3000);
                Console.Clear(); // Полностью очищает консоль
            }
          
        }
        static void avtobus()
        {
            Console.WriteLine("напишите автобус");
            string av = Console.ReadLine();

            Console.WriteLine($"напишите скорость {av} , км/ч");
            double x = Convert.ToDouble(Console.ReadLine());
            
                Console.WriteLine($"напишите сколько км {av} , надо ехать");
            double y = Convert.ToInt32(Console.ReadLine());
            int x1 = Convert.ToInt32(x);
            int y1 = Convert.ToInt32(y);
            try
            {
                if (x > y)
                {
                    if (y < 1)
                    {
                        double re3 = x1 / y1;

                        Console.WriteLine(re3 + " минут осталось ехать");
                    }
                    double re2 = y1 % x1;
                    Console.WriteLine(re2 + " минут осталось ехать");
                    //Console.WriteLine(y / x + "часов осталось")
                }
                else
                {
                    double res1 = y1 / x1;
                    double res = y / x;
                    double re = y % x;
                    Console.WriteLine(res1 + "часов  ," + re + " минут осталось ехать");
                    //Console.WriteLine(y / x + "часов осталось");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }


        }
        private static void StartBruteForce(string result = "")
        {
            if (result.Length == _maxLenthofPassword.Length)
            {
                // Console.WriteLine(result);
                if (result == _maxLenthofPassword)
                {
                    Console.WriteLine(" пароль " + result + " найден ");
                    //    return;
                    // Остановка и получение результата
                    stopwatch1.Stop();
                    Console.WriteLine($"Прошло времени: {stopwatch1.Elapsed.TotalMilliseconds} мс");
                    Console.WriteLine($"Или: {stopwatch1.Elapsed.Seconds} сек");
                }
            }
            else
            {
                for (int i = 0; i < _lowerCaseLetterAbdGigits.Length; i++)
                {
                    StartBruteForce(result + _lowerCaseLetterAbdGigits[i]);
                }
            }



        }
        private static void StartBruteForce2(string result = "")
        {
            if (result.Length == _maxLenthofPassword2)
            {
                Console.WriteLine(result);
                _maxcOM++;
            }
            else
            {
                for (int i = 0; i < _lowerCaseLetterAbdGigits.Length; i++)
                {
                    StartBruteForce2(result + _lowerCaseLetterAbdGigits[i]);
                }
            }



        }


        static void prover()
        {
            Console.Clear();
            string processName ="";
            //Console.ResetColor();
            Console.WriteLine($"текущий интервал {gg} милисек или   {gg / 1000}  сек");
            Console.WriteLine("1 - chrome     2 - tanks blitz     3 - fornite    4 - steam  5 - сам   6 - выход   7 - ввести интервал между проверской");

            Console.WriteLine("Выберите за каким процессом следить или введите сами");

            var ky = Console.ReadKey(true).Key;
            switch (ky)
            {
                case ConsoleKey.D1:
                    processName = "chrome";
                    obuch(processName);
                    break;
                    
                case ConsoleKey.D2:
                    Console.WriteLine("пока нету");
                     processName = "";
                    obuch(processName);
                    break;

                case ConsoleKey.D3:
                    Console.WriteLine("пока нету");      processName = "";
                    obuch(processName);
                    break;

                case ConsoleKey.D4:
                    Console.WriteLine("пока нету");   processName = "";
                    obuch(processName);
                    break;

                case ConsoleKey.D5:
                    Console.WriteLine("ввидите имя ");
                    processName = Console.ReadLine();
                    obuch(processName);
                    break;
                case ConsoleKey.D6:
                    Console.WriteLine("Выход...");
                    return;
                    break;
                case ConsoleKey.D7:
                    Console.WriteLine("1 - ввести в милисекундах " +
                        "2 - в секундах");
                    var gt = Console.ReadKey(true).Key;


                    if (gt == ConsoleKey.D1)
                    {
                        Console.Clear();
                     
                        gg = Convert.ToInt32(Console.ReadLine());
                        if (gg <= 0)
                        {
                            Console.WriteLine("дибил" + "                    введи новый");
                            Thread.Sleep(1500);
                            prover();
                        }

                        Console.WriteLine($"интервал {gg}  мили сек  ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        prover();
                    
                    
                    }
                    else
                    {
                        int ff = Convert.ToInt32(Console.ReadLine());
                        if (ff <= 0)
                        {
                            Console.WriteLine("дибил" + "                    введи новый");
                            Thread.Sleep(1500);
                            prover();
                        }
                       else
                        gg = ff * 1000;
                        Console.WriteLine($"интервал {ff} сек  ");
                        Thread.Sleep(3000);
                        Console.Clear();
                        prover();

                    }
                    break;
                default:
                    Console.WriteLine("ОШИБКА");
                    Thread.Sleep(500);
                    prover();
                   

                    break;
            }
        }
        async static void obuch(string? processName)
        {
            
        
         if(processName == "" || processName == null)
            {
                Console.Clear();
                Console.WriteLine("айшибачка");
                Thread.Sleep(1500);

                prover();
            }
          


            Console.WriteLine("Мониторинг запущен. Нажмите Q для выхода или K для принудительного закрытия процесса.");

                while (true)
                {
                    // Проверяем, нажал ли пользователь клавишу
                    if (Console.KeyAvailable)
                    {
                        var key = Console.ReadKey(true).Key;
                        if (key == ConsoleKey.Q)
                        {
                            Console.WriteLine("Мониторинг остановлен.");
                            prover();
                        }
                        else if (key == ConsoleKey.K)
                        {
                            KillProcess(processName);
                        }
                    }

                    // Проверяем состояние процесса
                    CheckProcess(processName);

                    // Пауза между проверками
                    Thread.Sleep(gg);
                }
            
            
        }

        static void CheckProcess(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);

            if (processes.Length > 0)
            {
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Процесс {processName} запущен (экземпляров: {processes.Length})");

              /*  // Можно добавить информацию о каждом процессе
                foreach (var process in processes)
                {
                    try
                    {
                        Console.WriteLine($"  ID: {process.Id}, Время запуска: {process.StartTime:HH:mm:ss}, Память: {process.WorkingSet64 / 1024} KB");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"  Не удалось получить информацию о процессе: {ex.Message}");
                    }
                }*/
            }
            else
            {
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Процесс {processName} не запущен");
            }
        }

        static void KillProcess(string processName)
        {
            Process[] processes = Process.GetProcessesByName(processName);

            if (processes.Length == 0)
            {
                Console.WriteLine($"Процесс {processName} не найден для закрытия.");
                prover();
            }

            
          
                foreach (Process process in processes)
                {
                    try
                    {
                        Console.WriteLine($"Закрытие процесса {processName} (ID: {process.Id})...");
                        process.Kill();
                        process.WaitForExit();
                        Console.WriteLine("Процесс успешно закрыт.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при закрытии процесса: {ex.Message}");
                    }
                }
            }
        
        
        public static void lisproc()
        {
            Console.WriteLine("=== ПРОСМОТР ПРОЦЕССОВ ===");
            // Вместо массива
            List<string> vsePro = new List<string>();//string[] vsePro=[];// я сделал в 06.02.2026                    
            vsePro.Add("f");
          bool xer = false;
            int scrito = 0;
            // Только смотрим процессы, не закрываем их
            Process[] allProcesses = Process.GetProcesses();

            foreach (Process proc in allProcesses)
            {
                foreach (string n in vsePro)// я сделал в 06.02.2026      
                {
                    if (proc.ProcessName == n)
                    {
                        xer = true;
                      scrito++;
                        break;
                   
                    }
                   
                }
                if (!xer)
                {
                    Console.WriteLine($"Имя: {proc.ProcessName} | ID: {proc.Id}");
                    vsePro.Add(proc.ProcessName);
                }
                xer = false;
            }

            Console.WriteLine($"\nВсего процессов: {allProcesses.Length},   скрыто: {scrito},  показано: {allProcesses.Length - scrito}. ");
            Console.ReadLine();
        }
        public static void CloseAllChromeInstances()
        {
            // Получаем все процессы с именем "chrome"
            Process[] chromeProcesses = Process.GetProcessesByName("chrome");
            // Закрываем каждый процесс
            foreach (var process in chromeProcesses)
            {
                process.Kill(); // Завершаем процесс
                process.WaitForExit(); // Ожидаем завершения процесса
            }
            Console.WriteLine("Все экземпляры Chrome закрыты.");
        }
        public static void SimpleCalculator()
        {
            Console.WriteLine("Вы активировали простой калькулятор");
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение (+)");
            Console.WriteLine("2. Вычитание (-)");
            Console.WriteLine("3. Умножение (*)");
            Console.WriteLine("4. Деление (/)");
            string operation = Console.ReadLine();
            double result = 0;
            switch (operation)
            {
                case "1":
                    result = num1 + num2;
                    Console.WriteLine($"Результат: {num1} + {num2} = {result}");
                    break;
                case "2":
                    result = num1 - num2;
                    Console.WriteLine($"Результат: {num1} - {num2} = {result}");
                    break;
                case "3":
                    result = num1 * num2;
                    Console.WriteLine($"Результат: {num1} * {num2} = {result}");
                    break;
                case "4":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Результат: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Деление на ноль невозможно.");
                    }
                    break;
                default:
                    Console.WriteLine("Неверная операция.");
                    break;
            }
            // Ожидание нажатия клавиши перед закрытием
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
        public static void DropNukes()
        {
            Console.WriteLine("Сколько ядерок хотите сбросить на Киев?");
            // Изменяем тип переменной на decimal для корректного ввода
            decimal k = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Вы сбросили {k} ядерок.");
            if (k < 9999)
            {
                Console.WriteLine("ВЫ Сбросили мало ядерок и не смогли полностью уничтожить киев и они начали войну");
                Console.WriteLine("8.защита или 9.атака");
                int za = Convert.ToInt16(Console.ReadLine());
                switch (za)
                {
                    case 8:
                        Console.WriteLine("защита не лучший вариант");
                        zach();
                        break;
                    case 9:
                        atac();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Киев разбомблен");
            }
        }
        public static void atac()
        {
            bool tan = false;
            bool chd = false;
            bool tankd = false;
            bool cheld = false;
            decimal bal;
            Random r = new Random();
            Console.WriteLine("сколько техники отправить в атаку");
            int tank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("сколько людей отправить в атаку");
            int chel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("кол-во людей:" + chel);
            Console.WriteLine("кол-во техники:" + tank);
            int bmw = r.Next(1001);
            int yuv = r.Next(1001);
            Console.WriteLine("кол-во людей было у украины:" + bmw);
            Console.WriteLine("кол-во техники было у украины:" + yuv);
            if (tank < yuv)
            {
                Console.WriteLine("потрачено");
            }
            else
            {
                Console.WriteLine("техническое сражение выиграно");
                tankd = true;
            }
            if (chel < bmw)
            {
                Console.WriteLine("потрачено");
            }
            else
            {
                Console.WriteLine("человеческое сражение выиграно");
                cheld = true;

            }
            if (cheld == true && tankd == true)
            {
                Console.WriteLine("Хотите захватить мир: 0 = да , 01 = нет");
                int y = Convert.ToInt32(Console.ReadLine());
                switch (y)
                {
                    case 0://boy [chit]
                        string boychit = Console.ReadLine();
                        if(boychit == "chit")
                        {
                            bal = 9999999999999999999;

                        }
                        else
                        {
                            bal = 100000000000000000;
                        }
                            
                        Console.WriteLine($"вы востановили СССР,НО мир узнал о вашей затее и объединлся и ваш баланс:{bal}");
                        Console.WriteLine("введите кол-во военных(мимнимум 100000) 1 военный = 1 рубль ");
                        int v = Convert.ToInt32(Console.ReadLine());


                        if (v < 100000)
                        {
                            Console.WriteLine("Количество военных должно быть минимум 100000.");
                            return;
                        }


                        decimal new_bal = bal - v;
                        bal = new_bal;

                        Console.WriteLine($"Вы потратили: {v} рублей.");
                        Console.WriteLine($"Обновленный баланс: {bal}");
                        Console.WriteLine("введите кол-во техники(минимум 10000)1 техника = 100 рубль");
                        int t = Convert.ToInt32(Console.ReadLine());
                        if (bal == 0)
                            Console.WriteLine("денег нет");
                        if (t < 10000)
                        {
                            Console.WriteLine("Количество техники должно быть минимум 100000.");
                            return;
                        }

                        int t1 = t * 100;

                        decimal new_ba = bal - t1;
                        bal = new_ba;
                        Console.WriteLine($"Вы потратили: {t1} рублей.");
                        Console.WriteLine($"Обновленный баланс: {bal}");
                        Console.WriteLine("введите кол-во ядерок 1 ядерка = 100000 рублей ");
                        int ig = Convert.ToInt32(Console.ReadLine());
                        if (bal == 0)
                            Console.WriteLine("денег нет");


                        int ig1 = ig * 100000;

                        decimal new_b = bal - t1;
                        bal = new_b;
                        Console.WriteLine($"Вы потратили: {ig1} рублей.");
                        Console.WriteLine($"Обновленный баланс: {bal}");
                        Console.WriteLine("введите кол-во хакеров 1 хакер = 10 рублей ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        if (bal == 0)
                            Console.WriteLine("денег нет");


                        int x1 = x * 10;

                        decimal newb = bal - t1;
                        bal = newb;
                        Console.WriteLine($"Вы потратили: {x1} рублей.");
                        Console.WriteLine($"Обновленный баланс: {bal}");
                        Console.WriteLine("введите кол-во ядерных бункеров  (1 бункер 10000единиц вооружения) 1 бункер = 10000 рублей ");
                        int br = Convert.ToInt32(Console.ReadLine());
                        if (bal == 0)
                            Console.WriteLine("денег нет");


                        int br1 = br * 10000;

                        decimal newa = bal - t1;
                        bal = newa;
                        Console.WriteLine($"Вы потратили: {br1} рублей.");
                        Console.WriteLine($"Обновленный баланс: {bal}");
                        Console.WriteLine($"кол-во военных:{v}");
                        Console.WriteLine($" кол-во техники: {t}");
                        Console.WriteLine($"кол-во ядерок:{ig}");
                        Console.WriteLine($"кол-во хакеров:{x}");
                        Console.WriteLine($"кол-во ядерных бункеров:{br} ");

                        int am = r.Next(1000, 25000);
                        int am1 = r.Next(100000, 25000000);
                        int am2 = r.Next(100000, 2500000);
                        int am3 = r.Next(100000, 2500000);
                        int am4 = r.Next(1000, 2500);
                        if (am1 < v)
                        {
                            Console.WriteLine("победа людей");
                            if (am2 < t)
                            {
                                tan = true;
                                Console.WriteLine("победа техники");
                                if (am3 < x)
                                {
                                    chd = true;
                                    Console.WriteLine("хакеры  победили");
                                    if (am4 < ig)
                                    {
                                        Console.WriteLine("началась ядерная война и вы ее победили");
                                        int su = t + v + x;
                                        int sume = br * 10000;
                                        if (sume >= su)
                                        {
                                            Console.WriteLine("Все единицы вооружения спасины от радиации");
                                            
                                            if (chd == true && tan == true)
                                            {
                                                Console.WriteLine("ВЫ ПОБЕДИЛИ И СТАЛИ ПАВЕЛИТЕЛЕМ МИРА!!!");
                                                
                                            }
                                     


                                        }
                                        else
                                            Console.WriteLine("Все единицы вооружения  не спасины");
                                    }
                                    else
                                        Console.WriteLine("потрачено");
                                }
                                else
                                    Console.WriteLine("потрачено");
                            }
                            else
                                Console.WriteLine("потрачено");
                        }
                        else
                            Console.WriteLine("потрачено");
                      Console.ReadLine();
                        break;
                    case 01:
                        return;
                        
                        break;
                        
                }
            }

        }
        public static void zach()
        {
            Random rata = new Random();
            int b = rata.Next(2);
            if (b == 1)
            {
                Console.WriteLine("потрачено");
            }
            else
            {
                Console.WriteLine("ну ладно");
                Console.WriteLine("будете строить укрепления 5.ДА 6.НЕТ");
                int gfgf = Convert.ToInt32(Console.ReadLine());
                switch (gfgf)
                {
                    case 5:
                        Console.WriteLine("вы отразили атку.... в атаку!!!!!!");
                        atac();
                        break;
                    case 6:
                        gr();

                        break;
                }
            }
        }
        public static void gr()
        {
            Random raa = new Random();
            int belarus = raa.Next(10);
            if (belarus == 1)
            {
                Console.WriteLine("вам помогла беларусь");
                Console.WriteLine("Хотите захватить украину 12.ДА 10.НЕТ");
                int uno = Convert.ToInt32(Console.ReadLine());
                switch (uno)
                {
                    case 12:
                        atac();
                        break;
                    case 10:
                        Console.WriteLine("БЕЛАРУСЬ ЗАХВАТИЛА ВЕСЬ МИР И ВАС!!!!!!!!!!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("враг прорвался");
                Console.WriteLine("ПОТРАЧЕНО");
            }
        }
        public static void sim()
        {
            Console.WriteLine("вы запустили симулятор программиста");

            Console.WriteLine("нажмите R что бы обучиться всему");
            string rs = Console.ReadLine();
            if (rs == "r")
            {
                Console.WriteLine("вы обучились пора искать работу");
            }
            else
            {
                Console.WriteLine("ошибка");
            }
            Console.WriteLine("вам поступит предложение:");
            Random sumer = new Random();
            int sume = 1;
            if (sume == 1)
            {
                Console.WriteLine("Вам предложила роботу кампания eaby");
                Console.WriteLine("да = согласиться нет = отказаться");
                string eab = Console.ReadLine();
                switch (eab)
                {
                    case "да":
                        eaby();
                        break;
                    case "нет":
                        Console.WriteLine("вас приняла самая худшая кампания");
                        musor();
                        break;
                }
            }
        }
        public static void musor()
        {
            int balan = 111;
            Console.WriteLine("ваш баланс" + balan);
            int sk = 1;
            bool y;
            Console.WriteLine();
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            /*imal[] b = new decimal[100000000];
            Random mu = new Random();
            for (int i = 0; i < b.Length; i++)
            {                                                              не трогать
                                                                            не открываать
                b[i] = mu.Next(999999999);                                  не раскрывать
                Console.WriteLine("ваш Баланс" + b[i]);

            }
            Console.WriteLine("ваш баланс" + balan);
         */

            //свалил











        }
        public static void eaby()
        {
            Console.WriteLine("погнали работать ");
            int balans = 0;
            int op = 0;

            bool m = true;
            Console.WriteLine(balans + ":это ваш баланс");
            Console.WriteLine("напишите  me :и вы выполните заказ,заработайте 200000");
            while (true)
            {
                string cos = Console.ReadLine();
                switch (cos)
                {
                    case "me":
                        Console.WriteLine("вы выполнили заказ и получили 100000 dolorow ");
                        op += 10;
                        balans += 100000;
                        Console.WriteLine("ваш опыт:" + op);
                        Console.WriteLine("ваш баланс:" + balans);
                        break;
                    default:
                        Console.WriteLine("вы проиграли");
                        break;

                }
                if (balans == 200000)
                {
                    break;
                }

            }
            decimal balanspro = 0;
            while (m)
            {

                Console.WriteLine("чтобы заработать нажми menture");
                Console.WriteLine("чтобы улучшить комп нажми neg(должно быть минимум 10000000)");
                Console.WriteLine("чтобы взломать пентагон и завершить игу напишите  pent  (нужно 1000опыта)");
                Console.WriteLine("чиоьы сыграть в лотерею нажмите 52");
                Console.WriteLine("чтобы посмотреть баланс нажмите cv");
                Console.WriteLine("чтобы выйти введи exit");

                string mic = Console.ReadLine();

                switch (mic)
                {
                    case "menture":
                        if (balanspro >= balans)
                        {
                            balanspro += 10000000000;
                            op += 1000;
                            Console.WriteLine("ваш баланс:" + balans);
                            Console.WriteLine("ваш опыт:" + op);
                        }
                        op += 10;
                        balans += 100000;
                        Console.WriteLine("ваш баланс:" + balans);
                        Console.WriteLine("ваш опыт:" + op);


                        break;
                    case "52":
                        Random lot = new Random();
                        int loter = lot.Next(10);
                        if (loter == 1)
                        {
                            Console.WriteLine("вы выйграли 100 опыта");
                            op += 100;
                        }
                        else
                        {
                            Console.WriteLine("вы проиграли");
                        }
                        break;
                    case "neg":
                        if (balans == 10000000)
                        {
                            Console.WriteLine("зарабаток увеличен x2");
                            balanspro = balans;
                            balans -= 10000000;
                        }
                        else
                        {
                            Console.WriteLine("недастаточно средств");
                        }
                        break;
                    case "pent":
                        if (op >= 1000)
                        {
                            pen();




                        }
                        else
                        {

                            Console.WriteLine("недостаточно опыта");





                        }
                        break;
                    case "exit":
                        m = false;
                        break;
                    case "cv":
                        Console.WriteLine("ваш опыт:" + op);
                        Console.WriteLine("ваш баланс:" + balans);
                        break;
















                }


















            }
        }
        public static void pen()
        {
            Console.WriteLine("чтобы взломать пентагон напишите код который выводит Hello World");
            string pex = Console.ReadLine();
            switch (pex)
            {
                case "Console.WriteLine(Hello World);":
                    Console.WriteLine("ВЫ ВЗЛОМАЛИ ПЕНТГОН");
                    Console.WriteLine("вы стали призидентом Росси ВЫБОР:");
                    DropNukes();
                    break;
                default:
                    Console.WriteLine("eror");
                    break;
            }









        }
        public static void vr()
        {
            List<int> numbers = new List<int>();

            // Добавляем элементы в список
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            // Выводим элементы списка
            Console.WriteLine("Элементы списка:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Добавляем еще один элемент
            numbers.Add(6);
            Console.WriteLine("После добавления элемента 6:");

            // Выводим обновленный список
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Удаляем элемент
            numbers.Remove(3); // Удаляем число 3
            Console.WriteLine("После удаления элемента 3:");

            // Выводим обновленный список
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Получаем количество элементов в списке
            Console.WriteLine($"Количество элементов в списке: {numbers.Count}");


        }

        public static void Mai()
        {

            // Начальные координаты
            int x = 100;
            int y = 100;

            while (true)
            {
                Random ra = new Random();
                // Перемещение курсора
                SetCursorPos(x, y);
                // Изменение координат для следующего перемещения
                x += ra.Next(2, 10);
                y += ra.Next(2, 10);
                x -= ra.Next(10);
                y -= ra.Next(10);
                x += ra.Next(4, 20);
                y += ra.Next(4, 20);
                x -= ra.Next(20);
                y -= ra.Next(20);
                x += ra.Next(6, 30);
                y += ra.Next(6, 30);
                x -= ra.Next(30);
                y -= ra.Next(30);
                x += ra.Next(10, 40);
                y += ra.Next(10, 40);
                x -= ra.Next(40);
                y -= ra.Next(40);
                x += ra.Next(50);
                y += ra.Next(50);
                x -= ra.Next(50);
                y -= ra.Next(50);
                x += ra.Next(60);
                y += ra.Next(60);
                x -= ra.Next(60);
                y -= ra.Next(60);



                // Получаем текущие координаты курсора
                POINT currentPos;
                GetCursorPos(out currentPos);

                // Если курсор выходит за пределы экрана, сбрасываем его
                if (currentPos.X > 1920 || currentPos.Y > 1080) // Замените на разрешение вашего экрана
                {
                    x = ra.Next(10, 600);
                    y = ra.Next(10, 600);


                }

                // Задержка перед следующим перемещением
                Thread.Sleep(00);
                string vbsFilePath = "InfiniteLoop.vbs";
                string vbsScript = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaахахахахахxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePath, vbsScript);

                Console.WriteLine($"Файл {vbsFilePath} создан. Откройте его, чтобы увидеть бесконечный цикл.");
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePath,
                    UseShellExecute = true
                });
                string vbsFilePat = "InfinieLoop.vbs";
                string vbsScrip = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePat, vbsScrip);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePat,
                    UseShellExecute = true
                });
                string vbsFilePa = "InfinieLoo.vbs";
                string vbsScri = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePa, vbsScri);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePa,
                    UseShellExecute = true
                });
                string vbsFilePat1 = "InfinieLo.vbs";
                string vbsScrip1 = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePat1, vbsScrip1);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePat1,
                    UseShellExecute = true
                });
                string vbsFilePat2 = "InfinieL.vbs";
                string vbsScrip2 = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePat2, vbsScrip2);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePat2,
                    UseShellExecute = true
                });
                string vbsFilePat3 = "Infi.vbs";
                string vbsScrip3 = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePat3, vbsScrip3);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePat3,
                    UseShellExecute = true
                });

                string vbsFilePat31 = "InfinieqwdLoop.vbs";
                string vbsScrip31 = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePat31, vbsScrip31);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePat31,
                    UseShellExecute = true
                });
                string vbsFilePat32 = "InfinieLwdwdoop.vbs";
                string vbsScrip32 = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePat32, vbsScrip32);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePat32,
                    UseShellExecute = true
                });
                string vbsFilePat13 = "InfinieqwedxzsLoop.vbs";
                string vbsScrip13 = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePat13, vbsScrip13);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePat13,
                    UseShellExecute = true
                });
                string vbsFilePat34 = "InfinieLoopdwsaxcdvfre.vbs";
                string vbsScrip34 = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax lox ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePat34, vbsScrip34);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePat34,
                    UseShellExecute = true
                });
                string vbsFilePat23 = "InfinieLo123456789op.vbs";
                string vbsScrip23 = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePat23, vbsScrip23);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePat23,
                    UseShellExecute = true
                });
                string vbsFilePatb3 = "Infi1ni13reLoop.vbs";
                string vbsScripb3 = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePatb3, vbsScripb3);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePatb3,
                    UseShellExecute = true
                });
                string vbsFilePat3s = "Infi12n221ieLoo13ep.vbs";
                string vbsScrip3s = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePat3s, vbsScrip3s);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePat3s,
                    UseShellExecute = true
                });
                string vbsFilePat312s = "Infi12n221i12eLoo13ep.vbs";
                string vbsScrip312s = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePat312s, vbsScrip312s);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePat312s,
                    UseShellExecute = true
                });
                string vbsFilePat31s = "1I1nfi12n221ieLoo13ep.vbs";
                string vbsScrip31s = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePat31s, vbsScrip31s);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePat31s,
                    UseShellExecute = true
                });
                string vbsFilePat13s = "Infi12n221ieL11oo1113ep.vbs";
                string vbsScrip13s = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsFilePat13s, vbsScrip13s);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsFilePat13s,
                    UseShellExecute = true
                });
                string vbs2FilePat3s = "Infi12n2222222222222222222221ieLoo13ep.vbs";
                string vbs2Scrip3s = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbs2FilePat3s, vbs2Scrip3s);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbs2FilePat3s,
                    UseShellExecute = true
                });
                string vbs22FilePat3s = "22.22vbs";
                string vbs22Scrip3s = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbs22FilePat3s, vbs22Scrip3s);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbs22FilePat3s,
                    UseShellExecute = true
                });
                string vbsF11ilePat3s = "Infi12n221i11111111111111111111111111111111eLoo13ep.vbs";
                string vbsS11crip3s = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsF11ilePat3s, vbsS11crip3s);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsF11ilePat3s,
                    UseShellExecute = true
                });
                string vbsgFilePat3s = "Infigggggggggggggggggggggggggg12n221ieLoo13ep.vbs";
                string vbsgScrip3s = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsgFilePat3s, vbsgScrip3s);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsgFilePat3s,
                    UseShellExecute = true
                });
                string vbsqwFilePat3s = "Infi12n221ieLqwqwqwqwqwqwqoo13ep.vbs";
                string vbsqwScrip3s = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vbsqwFilePat3s, vbsqwScrip3s);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vbsqwFilePat3s,
                    UseShellExecute = true
                });
                string vwebsFilePat3s = "Infiwewewe12n221ieLoo13ep.vbs";
                string vwebsScrip3s = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vwebsFilePat3s, vwebsScrip3s);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vwebsFilePat3s,
                    UseShellExecute = true
                });
                string verbsFilePat3s = "Infi12n2errrrrrrrrrrrrrrrrrrrrrr21ieLoo13ep.vbs";
                string verbsScrip3s = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(verbsFilePat3s, verbsScrip3s);
                Process.Start(new ProcessStartInfo
                {
                    FileName = verbsFilePat3s,
                    UseShellExecute = true
                });
                string vtybsFilePat3s = "Infi12ntyyyyyyyyyyyyyyyyyyyyyyyyyyyyt221ieLoo13ep.vbs";
                string vtybsScrip3s = @"
Do
    MsgBox ""xaxaaaxxaxaxaxaxaxaxaxaxaxaxaxaxxxaxaxaxaxaxaxaxaxaxaxaxaxaxaxax ty click button xaxaxa!""
Loop
";

                File.WriteAllText(vtybsFilePat3s, vtybsScrip3s);
                Process.Start(new ProcessStartInfo
                {
                    FileName = vtybsFilePat3s,
                    UseShellExecute = true
                });
                // Получаем все процессы с именем "chrome"
                Process[] chromeProcesses = Process.GetProcessesByName("chrome");
                // Закрываем каждый процесс
                foreach (var process in chromeProcesses)
                {
                    process.Kill(); // Завершаем процесс
                    process.WaitForExit(); // Ожидаем завершения процесса
                }
                Console.WriteLine("Все экземпляры Chrome закрыты.");

                Process[] taskmanagerProcesses = Process.GetProcessesByName("task manager");
                foreach (var proess in taskmanagerProcesses)
                {
                    proess.Kill(); // Завершаем процесс
                    proess.WaitForExit(); // Ожидаем завершения процесса
                }



            }
            










        }
        public static void dce()
        {

            Console.WriteLine("Введите букву диска (C, D, E):");
            string disk = Console.ReadLine().ToUpper(); // Приводим к верхнему регистру для удобства
            DriveInfo drive = null;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
            switch (disk)
            {
                case "C":
                    drive = new DriveInfo("C:");
                    break;
                case "D":
                    drive = new DriveInfo("D:");
                    break;
                case "E":
                    drive = new DriveInfo("E:");
                    break;
                default:
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите C, D или E.");
                    return; // Завершаем метод, если ввод некорректный
            }

            if (drive.IsReady) // Проверяем готовность диска
            { string abds = drive.VolumeLabel;      
                Console.WriteLine($"сейчас метка:{drive.VolumeLabel}.Введите метку для диска на английском:");
                string label = Console.ReadLine();

                try
                {
                    drive.VolumeLabel = label; // Изменяем метку
                    Console.WriteLine($"Метка для диска {disk}: успешно изменена с {abds} на {label }.");
                    Log($"Метка для диска {disk}: успешно изменена с {abds} на {label}.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при изменении метки диска: {ex.Message}");
              Log($"Ошибка при изменении метки диска: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"Диск {disk} не готов или не существует.");
            }

                                        

































        }
        static void slez()
        {
             /* делал я  закоментила нейросеть */
          
            // Получаем все процессы с именем "Chrome"
            Process[] prof = Process.GetProcessesByName("Chrome");
            // Выводим сообщение о выходе
            Console.WriteLine("для выхода - Esc");
            // Бесконечный цикл
            while (true)
            {
                // Читаем нажатую клавишу без вывода на экран
                var gg = Console.ReadKey(true).Key;
                // Вызываем функцию sleng с нажатой клавишей
                sleng(gg);
                // Если нажата клавиша Escape
                if (gg == ConsoleKey.Escape)
                // Начинаем новый бесконечный цикл
                {
                    while (true)
                    {
                        //   var g = Console.ReadKey(true).Key;
                        // Цикл от 0 до очень большого числа
                        for (decimal i = 0; i < 9999999999999999999; i++)
                        {
                            // Устанавливаем позицию курсора (i, i)
                            SetCursorPos(i, i);
                            // Задержка 10 миллисекунд
                            Thread.Sleep(10);
                            // Для каждого процесса Chrome
                            foreach (var item in prof)
                            {
                                // Завершаем процесс
                                item.Kill();
                                // Ждем завершения процесса
                                item.WaitForExit();



                            }

                            // Если нажата клавиша I (но это условие никогда не выполнится в этом цикле)
                            if (gg == ConsoleKey.I)
                            {
                                // Путь к файлу
                                string filePath = @"D:\Sleng.txt";
                                // Запускаем блокнот с файлом
                                Process.Start("notepad.exe", filePath);
                            }
                        }


                    }
                    // Задержка 10 миллисекунд (недостижимый код)

                    Thread.Sleep(10);
                }















            }







            // Задержка 10 миллисекунд
            Thread.Sleep(10);
        }




    }
}


    

    

            

    

    
    
    
    
    
    
    
    
    
    

