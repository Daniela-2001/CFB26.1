namespace aula26._1
{
    internal class Program
    {
        static void Main()
        {
            
        }

        static int divide(int dividendo,int divisor, out int resto)
        {
            int quociente;
            quociente= dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }
    }
}