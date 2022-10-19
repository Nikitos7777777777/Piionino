namespace pionino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете одну из октав : F1, F2, F3, F4");
            ConsoleKeyInfo go = Console.ReadKey();
            while (true)
            {
                if (go.Key == ConsoleKey.F1)
                    while (go.Key != ConsoleKey.F2 && go.Key != ConsoleKey.F3 && go.Key != ConsoleKey.F4)
                    {
                        go = key(go, 0 );
                    }
                else if (go.Key == ConsoleKey.F2)
                    while (go.Key != ConsoleKey.F1 && go.Key != ConsoleKey.F3 && go.Key != ConsoleKey.F4)
                    {
                        go = ke(go, 1 );
                    }
                else if(go.Key == ConsoleKey.F3)
                    while (go.Key != ConsoleKey.F2 && go.Key != ConsoleKey.F1 && go.Key != ConsoleKey.F4)
                    {
                        go = kek(go, 2);
                    }
                else if(go.Key == ConsoleKey.F4)
                    while (go.Key != ConsoleKey.F2 && go.Key != ConsoleKey.F3 && go.Key != ConsoleKey.F1)
                    {
                        go = keke(go, 3);
                    }
                
            }
            ///////////////////////////////////soundF1 массив/////////////////////////////////////////////
            static int soundF1(int i)
            {
                int[] Oktavu = new int[] { 523, 587, 659, 698, };
                return Oktavu[i];
            }
            /////////////////////////// soundF2 массив ///////////////////////////////////////
            static int soundF2(int i)
            {
                int[] Oktavu = new int[] { 261, 293, 329, 349, };
                return Oktavu[i];
            }
            ////////////////////////////  soundF3 массив //////////////////////////////////////
            static int soundF3(int i)
            {
                int[] Oktavu = new int[] { 65, 73, 82, 87, };
                return Oktavu[i];
            }
            /////////////////////////////// soundF4 массив /////////////////////////////////////////////
            static int soundF4(int i)
            {
                int[] Oktavu = new int[] { 130, 146, 164, 174 };
                return Oktavu[i];
            }

            static int sound1(int z)
            {
                Console.Clear();
                Console.Beep(z, 200);
                return z;
            }
            ///////////////////////////////////////////////////////// Октава F1/////////////////////////////////////////////////////////////////////////
             static ConsoleKeyInfo key(ConsoleKeyInfo klafisha, int i)
            {
                klafisha = Console.ReadKey();
              

                if (klafisha.Key == ConsoleKey.Q) 
                {
                    int z = soundF1(0);
                    sound1(z);
                }
                if (klafisha.Key == ConsoleKey.W)
                {
                    int z = soundF1(1);
                    sound1(z);
                }
                if (klafisha.Key == ConsoleKey.E)
                {
                    int z = soundF1(2);
                    sound1(z);
                }
                if (klafisha.Key == ConsoleKey.R)
                {
                    int z = soundF1(3);
                    sound1(z);
                }
                if (klafisha.Key != ConsoleKey.Q && klafisha.Key != ConsoleKey.W && klafisha.Key != ConsoleKey.E && klafisha.Key != ConsoleKey.R)
                {
                    Console.WriteLine(" : Нет такой клафиши");
                }
                return klafisha;         
            }
            ///////////////////////////////////////////////////////Октава F2///////////////////////////////////////////////////////
            static ConsoleKeyInfo ke(ConsoleKeyInfo klafisha, int i)
            {
                klafisha = Console.ReadKey();

                 if (klafisha.Key == ConsoleKey.Q) 
                {
                    int z = soundF2(0);
                    sound1(z);
                }
                if (klafisha.Key == ConsoleKey.W)
                {
                    int z = soundF2(1);
                    sound1(z);
                }
                if (klafisha.Key == ConsoleKey.E)
                {
                    int z = soundF2(2);
                    sound1(z);
                }
                if (klafisha.Key == ConsoleKey.R)
                {
                    int z = soundF2(3);
                    sound1(z);
                }
                if (klafisha.Key != ConsoleKey.Q && klafisha.Key != ConsoleKey.W && klafisha.Key != ConsoleKey.E && klafisha.Key != ConsoleKey.R)
                {
                    Console.WriteLine(" : Нет такой клафиши");
                }
                return klafisha;
            }
            ////////////////////////////////////////////////////////Октава F3////////////////////////////////////////////////////////////////
            static ConsoleKeyInfo kek(ConsoleKeyInfo klafisha, int i)
            {
                klafisha = Console.ReadKey();

                if (klafisha.Key == ConsoleKey.Q)
                {
                    int z = soundF3(0);
                    sound1(z);
                }
                if (klafisha.Key == ConsoleKey.W)
                {
                    int z = soundF3(1);
                    sound1(z);
                }
                if (klafisha.Key == ConsoleKey.E)
                {
                    int z = soundF3(2);
                    sound1(z);
                }
                if (klafisha.Key == ConsoleKey.R)
                {
                    int z = soundF3(3);
                    sound1(z);
                }
                if (klafisha.Key != ConsoleKey.Q && klafisha.Key != ConsoleKey.W && klafisha.Key != ConsoleKey.E && klafisha.Key != ConsoleKey.R)
                {
                    Console.WriteLine(" : Нет такой клафиши");
                }
                return klafisha;
            }
            ///////////////////////////////////////////////////////Октава F4//////////////////////////////////////////////////////////////////////////
            static ConsoleKeyInfo keke(ConsoleKeyInfo klafisha, int i)
            {
                klafisha = Console.ReadKey();

                if (klafisha.Key == ConsoleKey.Q)
                {
                    int z = soundF4(0);
                    sound1(z);
                }
                if (klafisha.Key == ConsoleKey.W)
                {
                    int z = soundF4(1);
                    sound1(z);
                }
                if (klafisha.Key == ConsoleKey.E)
                {
                    int z = soundF4(2);
                    sound1(z);
                }
                if (klafisha.Key == ConsoleKey.R)
                {
                    int z = soundF4(3);
                    sound1(z);
                }
                if (klafisha.Key != ConsoleKey.Q  && klafisha.Key != ConsoleKey.W && klafisha.Key != ConsoleKey.E && klafisha.Key != ConsoleKey.R)
                {
                    Console.WriteLine(" : Нет такой клафиши");
                }
                return klafisha;
            }
        }
    }
}