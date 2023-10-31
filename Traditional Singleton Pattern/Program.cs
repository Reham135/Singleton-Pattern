namespace Traditional_Singleton_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

         Singleton firstInstance=Singleton.GetInstance();
         Singleton secondInstance=Singleton.GetInstance();
         Console.WriteLine(firstInstance.GetHashCode());           //54267293
         Console.WriteLine(secondInstance.GetHashCode());          //54267293
         Console.WriteLine(firstInstance==secondInstance); //this will print true because they have the same hash code ,they isa the same obj

        }
    }
}