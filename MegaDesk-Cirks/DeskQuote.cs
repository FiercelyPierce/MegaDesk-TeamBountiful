using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace MegaDesk_Cirks
{
    [JsonObject]
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

        // Calculate Quote Price
        public static decimal CalculateQuotePrice(Desk desk, int rushDays)
        {
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

            // Add rush order cost
            switch (rushDays)
            {
                case 3:
                    if (surfaceArea < 1000)
                    {
                        quotePrice += 60;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        quotePrice += 70;
                    }
                    else
                    {
                        quotePrice += 80;
                    }
                    break;
                case 5:
                    if (surfaceArea < 1000)
                    {
                        quotePrice += 40;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        quotePrice += 50;
                    }
                    else
                    {
                        quotePrice += 60;
                    }
                    break;
                case 7:
                    if (surfaceArea < 1000)
                    {
                        quotePrice += 30;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        quotePrice += 35;
                    }
                    else
                    {
                        quotePrice += 40;
                    }
                    break;
                default:
                    break;
            }

            return quotePrice;
        }
    }
}
