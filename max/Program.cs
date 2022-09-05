Console.WriteLine("Введи 2 числа и мы тебе скажем какое из них больше");
            int a, b;
            Console.WriteLine("Введи свое первое число - ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи свое второе число - ");
            b = Convert.ToInt32(Console.ReadLine());
 
            bool cht1 = a > b;
            bool cht2 = a == b;
            bool cht3 = a < b;
 
            if (cht1)
            {
                Console.WriteLine($"Число {a} больше чем {b}");
            }
            else if (cht2)
            {
                Console.WriteLine($"Числа {a} и {b} равны");
            }
            else
            {
                Console.WriteLine($"Число {b} больше чем {a}");
            }
