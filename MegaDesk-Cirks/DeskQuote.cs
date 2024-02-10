using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_Cirks
{
    internal class DeskQuote
    {
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public Desk Desk { get; set; }
        public int RushDays { get; set; }
        public decimal QuotePrice { get; set; }

        public static List<DeskQuote> _quotes = new List<DeskQuote>(); //Quote List

        public DeskQuote() { }

        public DeskQuote(string customerName, DateTime quoteDate, Desk desk, int rushDays)
        {
            CustomerName = customerName;
            QuoteDate = quoteDate;
            Desk = desk;
            RushDays = rushDays;
            QuotePrice = CalculateQuotePrice(desk, rushDays);
        }

        private static int[,] ReadRushOrderPrices(string[] lines)
        {
            int[,] prices = new int[3, 3];
            int row = 0;
            for (int i = 0; i < lines.Length; i += 3)
            {
                for (int col = 0; col < 3; col++)
                {
                    prices[row, col] = int.Parse(lines[i + col].Trim());
                }
                row++;
            }
            return prices;
        }

        // Calculate Quote Price
        public static decimal CalculateQuotePrice(Desk desk, int rushDays)
        {
            string[] lines = File.ReadAllLines("rushOrderPrices.txt");
            int[,] rushPrices = ReadRushOrderPrices(lines);

            decimal quotePrice = 200;

            // Add surface area cost
            int surfaceArea = desk.Width * desk.Depth;
            if (surfaceArea > 1000)
            {
                quotePrice += surfaceArea - 1000;
            }

            // Add drawer cost
            quotePrice += desk.NumDrawers * 50;

            // Add surface material cost
            switch (desk.SurfaceMaterial)
            {
                case DeskMaterial.Oak:
                    quotePrice += 200;
                    break;
                case DeskMaterial.Laminate:
                    quotePrice += 100;
                    break;
                case DeskMaterial.Pine:
                    quotePrice += 50;
                    break;
                case DeskMaterial.Rosewood:
                    quotePrice += 300;
                    break;
                case DeskMaterial.Veneer:
                    quotePrice += 125;
                    break;
            }

            // Determine rush order price based on rushDays and desk size
            int sizeCategory = desk.Width * desk.Depth <= 1000 ? 0 : desk.Width * desk.Depth <= 2000 ? 1 : 2;
            int rushCategory = rushDays == 3 ? 0 : rushDays == 5 ? 1 : rushDays == 7 ? 2 : 3;

            if (rushCategory == 3)
            {
                return quotePrice;
            }
            else
            {
                int rushOrderPrice = rushPrices[rushCategory, sizeCategory];

                // Add rush order price to quotePrice
                quotePrice += rushOrderPrice;

                return quotePrice;
            }
        }

        public static List<DeskQuote> GetAllQuotes()  //method to return all quotes
        {
            return _quotes;
        }
    }
}
