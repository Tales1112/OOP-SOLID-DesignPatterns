﻿using System;
using DesignPatterns._01___Creational._1._4___Builder;
using DesignPatterns._01___Creational._1._5___Prototype;
using DesignPatterns.FactoryMethod;
using ExecucaoAbstractFactory = DesignPatterns.AbstractFactory.ExecucaoAbstractFactory;

namespace DesignPatterns
{
    class Program
    {
        private static void Main()
        {
            
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Method Factory");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("10 -  Builder");
            Console.WriteLine("11 - Prototype");
            Console.WriteLine("------------------------");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("6 - Composite");
            Console.WriteLine("------------------------");
            Console.WriteLine("Behavioral Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("7 - Command");
            Console.WriteLine("8 - Strategy");
            Console.WriteLine("9 - Observer");
            Console.WriteLine("------------------------");

            var opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            switch (opcao)
            {
                case 1:
                    ExecucaoAbstractFactory.Executar();
                    break;
                case 2:
                    //ExecucaoFactoryMethod.Executar();
                    break;
                case 3:
                    ExecucaoSingleton.Executar();
                    break;
                case 4:
                    ExecucaoAdapter.Executar();
                    break;
                case 5:
                    ExecucaoFacade.Executar();
                    break;
                case 6:
                    ExecucaoComposite.Executar();
                    break;
                case 7:
                    ExecucaoCommand.Executar();
                    break;
                case 8:
                    ExecucaoStrategy.Executar();
                    break;
                case 9:
                    ExecucaoObserver.Executar();
                    break;
                case 10:
                    ExecucaoBuilder.Executar();
                    break;
                case 11:
                    ExecucaoPrototype.Executar();
                    break;
            }

            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }
}
