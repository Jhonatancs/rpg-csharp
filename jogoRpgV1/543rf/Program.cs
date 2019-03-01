using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _543rf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Joguinho maroto";

            int dano, turno = 0, Num,block;
            int HeroHp = 30, HeroAttack = 10, HeroDef = 10;
            int MonsHp = 30, MonsAttack = 10, MonsDef = 10;
            string acao = "";

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("==========================================");
            Console.WriteLine("|               One Enemy                |");
            Console.WriteLine("==========================================");

            Console.WriteLine("==========================================");
            Console.WriteLine("|              Menu de Ações             |");
            Console.WriteLine("|----------------------------------------|");
            Console.WriteLine("|                  Atacar                |");
            Console.WriteLine("|                   Fugir                |");
            Console.WriteLine("|                 Defender               |");
            Console.WriteLine("|                   sair                 |");
            Console.WriteLine("==========================================");

            Console.ReadKey();
            Console.Clear();

            Random random = new Random();

            while (acao != "sair")
            {
                if(turno%2 == 0)
                {
                    Console.WriteLine("É a sua vez! o que voce faz?");
                    acao = Console.ReadLine();
                    switch (acao)
                    {
                        case "atacar":
                            Num = random.Next(1, 20);
                            dano = Num + HeroAttack;

                            Num = random.Next(1, 20);
                            block = Num + MonsDef;
                            if (dano > block)
                            {
                                MonsHp -= (dano - block);
                                Console.WriteLine("Voce deu " + (dano - block) + " de dano no monstro");

                                if(MonsHp <= 0)
                                {
                                    Console.WriteLine("O monstro Faliceu");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Voce errou");
                            }
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Num = random.Next(1, 20);
                    dano = Num + MonsAttack;

                    Num = random.Next(1, 20);
                    block = Num + HeroDef;
                    if (dano > block)
                    {
                        HeroHp -= (dano - block);
                        Console.WriteLine("Voce recebeu " + (dano - block) + " de dano do monstro");
                        if(HeroHp <= 0)
                        {
                            Console.WriteLine("Voce morreu");
                            acao = "sair";
                        }
                    }
                    else
                    {
                        Console.WriteLine("O monstro te atacou, mas errou!");
                    }
                }
                turno++;
            }

            Console.ReadKey();
            
        }
    }
}
