namespace oop_lab2
{
    class Program
    {
        static void Main(string[] args)
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


        }
    }
}