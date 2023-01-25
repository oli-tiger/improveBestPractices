using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;
using static Acme.Common.LoggingService;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory
    /// </summary>
    public class Product
    {
        public Product()
        {
            Console.WriteLine("Product instance created");
        }

        public Product(string productName, string description, int productId) :this()
        {
            this.ProductName = productName;
            this.ProductId = productId;
            this.Description = description;           
                     
            Console.WriteLine("Product instance has a name: " + ProductName);
        }

        private string productName;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string SayHello()
        {
            var vendor = new Vendor();
            vendor.SendWelcomeEmail("Message from Email");

            var emailService = new EmailService();
            emailService.SendMessage("New Product", this.ProductName, "sales@abc.com");

            var result = LogAction("saying hello");

            return "Hello " + ProductName + " (" + ProductId + "): " + Description;
        }
    }
}
