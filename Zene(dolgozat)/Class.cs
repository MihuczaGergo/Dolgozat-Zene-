using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zene_dolgozat_
{
    public class Class
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public int Length { get; set; }

        public Class(string title, string artist, int year, int length)
        {
            Title = title;
            Artist = artist;
            Year = year;
            Length = length;
        }

        public override string? ToString()
        {
            return $"Cím:{Title} Előadó: {Artist} Év: {Year} Hossz: {Length} seconds";
        }
    }
}
