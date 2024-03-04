namespace Exercise5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers:");
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            var result1 = Convert.ToInt32(a);
            var result2 = Convert.ToInt32(b);
            var result3 = Equal(result1, result2);
            Console.WriteLine("Your result is:" + result3);
        }

        public static int Equal(int a, int b)
        {
            if (a == b) return 0;
            else return a;
        }
    }
}
