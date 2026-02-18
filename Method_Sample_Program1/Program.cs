namespace Method_Sample_Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition add = new Addition();
            

            int add_1 = add.CalculateSum(56,70);
            Console.WriteLine($"The Addition of two numbers are:{add_1}");
            Console.ReadLine();
        }
    }
    public class Addition
    {
    public int CalculateSum(int firstnumber, int secondnumber)

    {
        int add = firstnumber + secondnumber;
        return add;
    } }
}
