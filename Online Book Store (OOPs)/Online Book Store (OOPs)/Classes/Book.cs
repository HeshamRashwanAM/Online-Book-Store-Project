using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store__OOPs_
{
    class Book
    {
        private string Name;
        private string Author;
        private double Price;
        private string Category;
        public Book(string Name, string Author, double Price, string Category)
        {
            this.Name = Name;
            this.Author = Author;
            this.Price = Price;
            this.Category = Category;
        }
        // Getter And Setter
        #region
        public void SetName(string Name) { this.Name = Name; }
        public void SetAuthor(string Author) { this.Author = Author; }
        public void SetPrice(double Price) { this.Price = Price; }
        public void SetCategory(string Category) { this.Category = Category; }
        public string GetName() { return Name; }
        public string GetAuthor() { return Author; }
        public double GetPrice() { return Price; }
        public string GetCategory() { return Category; }
        #endregion
        // End Getter And Setter
    }
}
