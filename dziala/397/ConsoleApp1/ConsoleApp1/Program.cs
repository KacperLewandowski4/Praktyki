using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shoe> shoeCloset = new List<Shoe>();

            shoeCloset.Add(new Shoe()
            {
                Style = Style.Sneakers,
                Color = "Czarny"
            });
            shoeCloset.Add(new Shoe()
            {
                Style = Style.Clogs,
                Color = "Brązowy"
            });
            shoeCloset.Add(new Shoe()
            {
                Style = Style.Wingtips,
                Color = "Czarny"
            });
            shoeCloset.Add(new Shoe()
            {
                Style = Style.Loafers,
                Color = "Biały"
            });
            shoeCloset.Add(new Shoe()
            {
                Style = Style.Loafers,
                Color = "Czerwony"
            });
            shoeCloset.Add(new Shoe()
            {
                Style = Style.Sneakers,
                Color = "Zielony"
            });
            int numbersOfShoes = shoeCloset.Count;
            foreach(Shoe shoe in shoeCloset)
            {
                shoe.Style = Style.Flipflops;
                shoe.Color = "Pomarańczowy";
            }

            shoeCloset.RemoveAt(4);

            Shoe thirdShoe = shoeCloset[2];
            Shoe secoundShoe = shoeCloset[1];
            shoeCloset.Clear();

            shoeCloset.Add(thirdShoe);
            if(shoeCloset.Contains(secoundShoe))
            {
                Console.WriteLine("A to ci niespodzianka.");
            }
        }
    }
}
