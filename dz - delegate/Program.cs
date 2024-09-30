using System;

namespace ConsoleMenu
{
    delegate void MenuAction();

    class Program
    {
        static void Main(string[] args)
        {
            MenuAction[] menuActions = new MenuAction[]
            {
                Exit,
                NewGame,
                LoadGame,
                ShowRules,
                AboutAuthor
            };

            while (true)
            {
                ShowMenu();

                int choice = GetUserInput();
                if (choice >= 0 && choice < menuActions.Length)
                {
                    menuActions[choice].Invoke();
                }
                else
                {
                    Console.WriteLine("нееверный выбор, попробуйте еще раз");
                }
            }
        }

        static void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1 - нью игра");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2 - загрузить игру");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("3 - правила");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("4 - об авторе");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0 - выход");

            Console.ResetColor();
            Console.Write("выберите пункт меню: ");
        }

        static int GetUserInput()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("пожалуйста, введите корректное число");
            }
            return choice;
        }

        static void NewGame()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("начинаем новую игру");
            Console.ResetColor();
        }

        static void LoadGame()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("загружаем игру");
            Console.ResetColor();
        }

        static void ShowRules()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("отображаем правила игры");
            Console.ResetColor();
        }

        static void AboutAuthor()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("информация об авторе");
            Console.ResetColor();
        }

        static void Exit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("выход из программы");
            Console.ResetColor();
            Environment.Exit(0);
        }
    }
}
