namespace oop_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Matrix operations");
                Console.WriteLine("2. MyFrac operations");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {

                    Matrix a = new Matrix(new double[,] {
                    {5, 2, 3, 1},
                    {1, 7, 2, 4},
                    {3, 1, 8, 2},
                    {2, 4, 1, 6}
                    });
                    Matrix b = new Matrix("5 2\n 3 1\n6 4\n 2 5");
                    Matrix c = new Matrix("-3 1\n 0 22\n6 44\n -2 1");

                    Console.WriteLine($"Matrix A:");
                    Console.WriteLine(a);
                    Console.WriteLine("Matrix B:");
                    Console.WriteLine(b);
                    Console.WriteLine("Matrix C:");
                    Console.WriteLine(c);

                    Matrix plus = b + c;
                    Console.WriteLine($"Matrix B + C:");
                    Console.WriteLine(plus);

                    Matrix product = a * b;
                    Console.WriteLine("Matrix A * B:");
                    Console.WriteLine(product);

                    Matrix transposed = a.GetTransponedCopy();
                    Console.WriteLine("Transposed Matrix A:");
                    Console.WriteLine(transposed);

                    transposed.TransponeMe();
                    Console.WriteLine("Twice transposed Matrix A:");
                    Console.WriteLine(transposed);
                }
                if (choice == 2)
                {
                    Console.WriteLine("MyFrac Examples:");

                    MyFrac f1 = new MyFrac(1, 2);
                    MyFrac f2 = new MyFrac(3, 4);
                    MyFrac f3 = new MyFrac(-5, 6);

                    Console.WriteLine($"f1: {f1}");
                    Console.WriteLine($"f2: {f2}");
                    Console.WriteLine($"f3: {f3}");

                    Console.WriteLine($"f1 with integer part: {f1.ToStringWithIntPart()}");
                    Console.WriteLine($"f2 with integer part: {f2.ToStringWithIntPart()}");
                    Console.WriteLine($"f3 with integer part: {f3.ToStringWithIntPart()}");

                    Console.WriteLine($"f1 as double: {f1.ToDouble()}");

                    MyFrac sum = f1 + f2;
                    MyFrac difference = f1 - f2;
                    MyFrac product = f1 * f2;
                    MyFrac quotient = f1 / f2;

                    Console.WriteLine($"f1 + f2 = {sum}");
                    Console.WriteLine($"f1 - f2 = {difference}");
                    Console.WriteLine($"f1 * f2 = {product}");
                    Console.WriteLine($"f1 / f2 = {quotient}");

                    MyFrac f4 = new MyFrac(1234, 5678);
                    Console.WriteLine($"f4: {f4}");
                    Console.WriteLine($"f4 with integer part: {f4.ToStringWithIntPart()}");

                    MyFrac f5 = new MyFrac(-15, 7);
                    MyFrac f6 = new MyFrac(8, -3);
                    Console.WriteLine($"f5: {f5}");
                    Console.WriteLine($"f6: {f6}");
                    Console.WriteLine($"f5 * f6 = {f5 * f6}");

                    int n = 10;
                    MyFrac f7 = new MyFrac(0, 1);
                    for (int i = 1; i <= n; i++)
                        f7 += new MyFrac(1, i * (i + 1));
                    Console.WriteLine($"f7 = {f7}");

                    MyFrac f8 = new MyFrac(1, 1);
                    for (int i = 2; i <= n; i++)
                        f8 *= new MyFrac(i * i - 1, i * i);
                    Console.WriteLine($"f8 = {f8}");
                }

            } while (choice != 0);


        }
    }
}