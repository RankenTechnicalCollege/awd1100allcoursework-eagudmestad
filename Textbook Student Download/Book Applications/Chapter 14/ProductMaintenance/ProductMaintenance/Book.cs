using System;

namespace ProductMaintenance
{
    public class Book : Product
    {
        public Book() { }

        public Book(string code, string description, string author,
            decimal price) : base(code, description, price)
        {
            this.Author = author;
        }

        public string Author { get; set; }

        public override string GetDisplayText(string sep) =>
            base.GetDisplayText(sep) + " (" + Author + ")";
    }
}
