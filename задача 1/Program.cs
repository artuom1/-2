Console.WriteLine("Введите трехзначное число :");

int value = Convert.ToInt32(Console.ReadLine());

int result = (value / 10 ) % 10 ;

System.Console.WriteLine(result);