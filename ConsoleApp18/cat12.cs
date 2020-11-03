﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class cat12
    {
        public class Cat

        {
            public class cat
            {

                byte _hungryStatus;
                public cat(string name, DateTime birthday)

                {
                    Name = name;
                    BirthDay = birthday;
                    Task.Run(LifeCircle);
                }

                public string Name
                {
                    get;
                    set;
                }
                public void MakeNoise()
                {
                    Console.WriteLine($"{Name } мяукает");
                }
                public DateTime BirthDay
                {
                    get; set;
                }
                public int GetAge()
                {
                    return (DateTime.Today - BirthDay).Days / 365;
                }
                public byte HungryStatus
                {
                    get { return _hungryStatus; }
                    set
                    {
                        if (value < 0)
                        {
                            _hungryStatus = 0;
                        }
                        else if (value > 100)
                        {
                            _hungryStatus = 100;
                        }
                        else
                            _hungryStatus = value;
                    }
                }
                public void GetStatus()
                {
                    Console.WriteLine(Name);
                    Console.WriteLine($"Возраст: {GetAge()}");
                    if (HungryStatus <= 10)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Кошка умирает от голода");
                    }
                    else if (HungryStatus > 10 && HungryStatus <= 40)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Кошка очень голодна");
                    }
                    else if (HungryStatus > 40 && HungryStatus <= 70)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Кошка хочет кушать");
                    }
                    else if (HungryStatus > 40 && HungryStatus <= 70)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Кошка не против перекусить");
                    }
                    else if (HungryStatus > 90)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Кошка недавно поела");
                    }
                    Console.ResetColor();
                }

                async Task LifeCircle()
                {
                    await Task.Delay(10000);
                    HungryStatus -= 10;
                    GetStatus();
                    await LifeCircle();

                }

            }

        }
    }
}

