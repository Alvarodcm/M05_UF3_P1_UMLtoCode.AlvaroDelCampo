using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05_UF3_P1_UMLtoCode.AlvaroDelCampo
{
    internal class Product
    {
        private int Id { get; }
        private string Name { get; set; }
        private string Brand { get; set; }
        private List<string> Images { get; set; }
        private string Description { get; set; }
        private double BasePrice { get; set; }
        private double Discount { get; set; }
        private List<string> Labels { get; set; }

        private Classification HighCat { get; set; }
        private Classification LowCat { get; set; }
        private Classification HighSubcat { get; set; }
        private Classification LowSubcat { get; set; }


        public Product(string name, string brand, List<string> images, string description, double basePrice, double discount, List<string> labels)
        {
            this.Name = name;
            this.Brand = brand;
            this.Images = images;
            this.Description = description;
            this.BasePrice = basePrice;
            this.Discount = discount;
            this.Labels = labels;
        }

        public Product()
        {

        }


        private Product AddProduct(string name, string brand, List<string> images, string description, double basePrice, double discount, List<string> labels)
        {

            return new Product(name, brand, images, description, basePrice, discount, labels);


        }

        private Product EditProduct(int productId)
        {


            return new Product();
        }


        private bool DeleteProduct(int productId)
        {

            return true;
        }



        private bool ValidateData(string data, int productId)
        {

            if (data != null && productId != 0)
            {

                return true;
            }

            return false;
        }
    }

}

