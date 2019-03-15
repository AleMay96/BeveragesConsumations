using System;

namespace DrinkDrunkDRUNK
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            System.Console.WriteLine("--------COFFE-------");
            
            Consumation coffe = new Coffee();
            Console.WriteLine($"Prodotto: {coffe.getProductName()} -- Prezzo: {coffe.getPrice()}€");
            

            Consumation coffeCream = new ExtraCreamDecorator(coffe);
            Console.WriteLine($"Prodotto: {coffeCream.getProductName()} -- Prezzo: {coffeCream.getPrice()}€");
            

            Consumation coffeLiquor = new ExtraLiquorDecorator(coffe);
            Console.WriteLine($"Prodotto: {coffeLiquor.getProductName()} -- Prezzo: {coffeLiquor.getPrice()}€");
            
            Consumation coffeDouble = new ExtraDoubleDecorator(coffe);
            Console.WriteLine($"Prodotto: {coffeDouble.getProductName()} -- Prezzo: {coffeDouble.getPrice()}€");

            Consumation coffeAmerican = new ExtraAmericanDecorator(coffe);
            Console.WriteLine($"Prodotto: {coffeAmerican.getProductName()} -- Prezzo: {coffeAmerican.getPrice()}€");
            
            System.Console.WriteLine("\n");
            System.Console.WriteLine("--------TEA-------");
             
            Consumation tea = new Tea();
            Console.WriteLine($"Prodotto: {tea.getProductName()} -- Prezzo: {tea.getPrice()}€");

            Consumation teaLemon = new ExtraLemonDecorator(tea);
            Console.WriteLine($"Prodotto: {teaLemon.getProductName()} -- Prezzo: {teaLemon.getPrice()}€");

            Consumation teaGinseng = new ExtraGinsengDecorator(tea);
            Console.WriteLine($"Prodotto: {teaGinseng.getProductName()} -- Prezzo: {teaGinseng.getPrice()}€");

            Consumation teaApple = new ExtraAppleDecorator(tea);
            Console.WriteLine($"Prodotto: {teaApple.getProductName()} -- Prezzo: {teaApple.getPrice()}€");
        }
    }
}
