using PizzaStoreDaniel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStoreDaniel
{
    public class Store
    {

        public void Start()
        {
            //Opret 3 pizza objects
            Pizza pizza1 = new Pizza(1, "Margarita", "Tomat og ost", 95);
            Pizza pizza2 = new Pizza(2, "Hawaii", "Ananas og skinke", 110);
            Pizza pizza3 = new Pizza(3, "JordenRundt", "Bacon, shawarma, skinke, fried chicken, champignon, safran, kaviar", 420);
            Console.WriteLine();
            Console.WriteLine();

            //Opret 3 kunde objects
            Kunde kunde1 = new Kunde(1, "Jakob", "Kastrupvej 333, 2770 Kastrup");
            Kunde kunde2 = new Kunde(2, "Bo", "Tejn alle 5, 2770 Kastrup");
            Kunde kunde3 = new Kunde(3, "Camilla Mai Ryskjær", "Maglegårdsvej 2, 4000 Roskilde");
            Console.WriteLine();
            Console.WriteLine();

            //Opret 3 ordre, som alle har en forkellig pizza 
            Ordre ordre1 = new Ordre(1, kunde1.Kundeid, pizza1._pizzapris);
            Ordre ordre2 = new Ordre(2, kunde2.Kundeid, pizza2._pizzapris);
            Ordre ordre3 = new Ordre(3, kunde3.Kundeid, pizza3._pizzapris);
            Console.WriteLine();
            Console.WriteLine();

            //Her "printer" jeg informationen for hvert et individuelt objekt
            Console.WriteLine(pizza1);
            Console.WriteLine(pizza2);
            Console.WriteLine(pizza3);
            Console.WriteLine();

            Console.WriteLine(kunde1);
            Console.WriteLine(kunde2);
            Console.WriteLine(kunde3);
            Console.WriteLine();

            Console.WriteLine(ordre1);
            Console.WriteLine(ordre2);
            Console.WriteLine(ordre3);
            Console.WriteLine();
            Console.WriteLine();

            //Her tester jeg CalculateTotalPrice metoden
            Console.WriteLine($"Total pris for ordre1: {ordre1.CalculateTotalPrice()}");
            Console.WriteLine($"Total pris for ordre2: {ordre2.CalculateTotalPrice()}");
            Console.WriteLine($"Total pris for ordre3: {ordre3.CalculateTotalPrice()}");
            Console.WriteLine();
            Console.WriteLine();

            //Her "printer" jeg pizza navn, kunde navn og total pris for alle de 3 forskellige ordre
            Console.WriteLine("Ordre 1");
            Console.WriteLine($"Pizza navn for ordre1: {pizza1.Pizzanavn},Kundens navn: {kunde1.Kundenavn}, Den totale pris: {ordre1.CalculateTotalPrice()}");
            Console.WriteLine();

            Console.WriteLine("Ordre 2");
            Console.WriteLine($"Pizza navn for ordre2: {pizza2.Pizzanavn},Kundens navn: {kunde2.Kundenavn}, Den totale pris: {ordre2.CalculateTotalPrice()}");
            Console.WriteLine();

            Console.WriteLine("Ordre 3");
            Console.WriteLine($"Pizza navn for ordre3: {pizza3.Pizzanavn},Kundens navn: {kunde3.Kundenavn}, Den totale pris: {ordre3.CalculateTotalPrice()}");
            Console.WriteLine();



        }


    }
}
