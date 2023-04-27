using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05_UF3_P1_UMLtoCode.AlvaroDelCampo
{
    internal class Order
    {
        private int OrderNumber { get; }
        private DateTime OrderDate { get; set; }
        private double FinalPrice { get; set; }
        private List<Product> Products { get; set; }
        private List<int> Quantities { get; set; }


        public Order(int orderNumber, DateTime orderDate, List<Product> products, List<int> quantities, double finalPrice)
        {
            this.OrderNumber = orderNumber;
            this.OrderDate = orderDate;
            this.FinalPrice = finalPrice;
            this.Products = products;
            this.Quantities = quantities;

        }

        public Order()
        {


        }

        private void AddOrder()
        {


        }

        private Order EditOrder(int orderNumber)
        {

            return new Order();
        }

        private bool DeleteOrder(int orderNumber)
        {

            return true;
        }



        private string GenerateReport(Order order)
        {

            return "Report";
        }
    }
}
}
