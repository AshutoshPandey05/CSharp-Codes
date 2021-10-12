using System;

namespace Demo_LatestlangFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            coordinates India = new coordinates(120, 150);
            Console.WriteLine("India coordinates r:" + India.X + India.Y);
        }
    }

    public record person(string Fname, string Lname);
    public record person1
    {
        public string Firstname { get; init; } = default!;
        public string lastname { get; init; } = default!;

    }
    public record Newperson
    {
        public string Firstname { get; set; } = default!;
        public string lastname { get; set; } = default!;
    }
}

