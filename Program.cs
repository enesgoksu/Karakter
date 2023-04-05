namespace Karakter.Karakter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Kelime ya da cümle yazınız: ");
            string yazı = Console.ReadLine();
            Console.Write("İndex numarası giriniz: ");
            int index = int.Parse(Console.ReadLine());

            yazı = yazı.Remove(index,1);
            Console.WriteLine(yazı);
        }
    }
}