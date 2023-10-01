internal class Program
{

    public static void Main(string[] args)
    {
        /*string[,] area = new string [,]
        {
            { ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", "."},
            { ".", " ", "X", " ", ".", " ", " ", " ", " ", " ", ".", " ", " ", " ", " ", " ", " ", " ", "."},
            { ".", " ", " ", " ", ".", " ", " ", " ", " ", " ", " ", " ", " ", " ", ".", " ", " ", " ", "."},
            { ".", " ", " ", " ", " ", " ", " ", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", "."},
            { ".", " ", " ", " ", ".", " ", ".", " ", ".", " ", " ", " ", " ", " ", ".", " ", " ", " ", "."},
            { ".", " ", " ", " ", ".", " ", " ", " ", ".", " ", " ", " ", " ", " ", " ", " ", " ", " ", "."},
            { ".", " ", " ", " ", ".", " ", " ", " ", " ", " ", " ", " ", ".", " ", ".", " ", " ", " ", "."},
            { ".", " ", " ", " ", " ", " ", " ", " ", ".", " ", " ", " ", ".", " ", " ", " ", " ", " ", " "},
            { ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", "."}
        };*/
        string[,] area = new string[,]
        {
            { ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", "." },
            { ".", " ", "X", " ", ".", " ", " ", " ", " ", " ", ".", " ", " ", " ", " ", " ", " ", " ", " ", " ", "." },
            { ".", " ", " ", " ", ".", " ", " ", " ", " ", " ", " ", " ", " ", " ", ".", " ", " ", " ", " ", " ", "." },
            { ".", " ", " ", " ", " ", " ", " ", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", "." },
            { ".", " ", " ", " ", ".", " ", ".", " ", ".", " ", " ", " ", " ", " ", ".", " ", " ", " ", " ", " ", "." },
            { ".", " ", " ", " ", ".", " ", " ", " ", ".", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "." },
            { ".", " ", " ", " ", ".", " ", " ", " ", " ", " ", " ", " ", ".", " ", ".", " ", " ", " ", ".", " ", "." },
            { ".", " ", " ", " ", " ", " ", " ", " ", ".", " ", " ", " ", ".", " ", " ", " ", " ", " ", " ", " ", "." },
            { ".", " ", ".", " ", " ", " ", " ", " ", ".", " ", " ", " ", " ", " ", " ", " ", ".", " ", ".", " ", "." },
            { ".", " ", " ", " ", ".", " ", " ", " ", " ", " ", " ", " ", ".", " ", " ", " ", " ", " ", " ", " ", " " },
            { ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", ".", " ", "." }
        };

        int x_curyy = 2; 
        int y_curxx = 1;

        Console.WriteLine("Press R to exit");
        printArea(area);
        int r = 0;
        //Console.WriteLine(area.GetLength(1));    //        19

        
        ConsoleKeyInfo button;

        while (r != 1)
        {
            if (y_curxx == area.GetLength(0) - 2 && x_curyy == area.GetLength(1) - 1)
            {
                Console.WriteLine("U WON!!!");
                break;
            }
            button = Console.ReadKey(true);
            if (button.Key == ConsoleKey.S)
            {
                if (area[y_curxx + 1, x_curyy] != "." && y_curxx + 1 < area.GetLength(0) && x_curyy + 2 < area.GetLength(1))
                {
                    area[y_curxx, x_curyy] = " ";
                    y_curxx += 1;
                    area[y_curxx, x_curyy] = "X";
                    Console.Clear();
                }
                else { continue; }
                Console.WriteLine("Press R to exit");
                printArea(area);
            }
            else
            {
                if (button.Key == ConsoleKey.D)
                {
                    if (area[y_curxx, x_curyy + 2] != "." && y_curxx + 1 < area.GetLength(0) && x_curyy + 2 < area.GetLength(1))
                    {
                        area[y_curxx, x_curyy] = " ";
                        x_curyy += 2;
                        area[y_curxx, x_curyy] = "X";
                        Console.Clear();
                    }
                    else { continue; }
                    Console.WriteLine("Press R to exit");
                    printArea(area);
                }
                else
                {
                    if (button.Key == ConsoleKey.W)
                    {
                        if (area[y_curxx - 1, x_curyy] != "." && y_curxx - 1 > 0)
                        {
                            area[y_curxx, x_curyy] = " ";
                            y_curxx -= 1;
                            area[y_curxx, x_curyy] = "X";
                            Console.Clear();
                        }
                        else { continue; }
                        Console.WriteLine("Press R to exit");
                        printArea(area);
                    }
                    else
                    {
                        if (button.Key == ConsoleKey.A)
                        {
                            if (area[y_curxx, x_curyy - 2] != "." && x_curyy - 2 > 0)
                            {
                                area[y_curxx, x_curyy] = " ";
                                x_curyy -= 2;
                                area[y_curxx, x_curyy] = "X";
                                Console.Clear();
                            }
                            else { continue; }
                            Console.WriteLine("Press R to exit");
                            printArea(area);
                        }
                        else
                        {
                            if (button.Key == ConsoleKey.R)
                            {
                                Console.WriteLine("was pressed R\nEND");
                                r = 1;
                            }
                        }
                    }
                }
            }
        }     
    }

    public static void printArea(string[,] a)
    {      
       for(int i = 0; i < a.GetLength(0); i++)
       {
           for(int j = 0; j < a.GetLength(1); j++)
           {
               Console.Write(a[i, j]);
           }
           Console.WriteLine();
       }
    }
}