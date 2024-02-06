using System;
using System.Collections.Generic;

namespace MegaDesk_Cirks
{
    internal class DeskQuote
    {
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public Desk Desk { get; set; }
        public int RushDays { get; set; }
        public decimal QuotePrice { get; set; }

        public DeskQuote() { }

        public DeskQuote(string customerName, DateTime quoteDate, Desk desk, int rushDays)
        {
            CustomerName = customerName;
            QuoteDate = quoteDate;
            Desk = desk;
            RushDays = rushDays;
            QuotePrice = CalculateQuotePrice(desk, rushDays);
        }

        private static int[,] ReadRushOrderPrices()
        {
            string[] lines = System.IO.File.ReadAllLines("rushOrderPrices.txt");
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
            decimal quotePrice = 200;
            int[,] rushPrices = ReadRushOrderPrices();

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

            // Add rush order cost based on the rushOrderPrices.txt file
            string[] lines = System.IO.File.ReadAllLines("rushOrderPrices.txt");
            List<string> rushOrderPrices = new List<string>();
            foreach (string line in lines)
            {
                rushOrderPrices.Add(line);
            }

            // Determine rush order price based on rushDays and desk size
            int sizeCategory = desk.Width * desk.Depth <= 1000 ? 0 : desk.Width * desk.Depth <= 2000 ? 1 : 2;
            int rushCategory = rushDays == 3 ? 0 : rushDays == 5 ? 1 : 2;
            int rushOrderPrice = rushPrices[sizeCategory, rushCategory];

            // Add rush order price to quotePrice
            quotePrice += rushOrderPrice;

            return quotePrice;
        }
    }
}
