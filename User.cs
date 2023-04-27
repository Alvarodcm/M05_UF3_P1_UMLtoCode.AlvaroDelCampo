using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M05_UF3_P1_UMLtoCode.AlvaroDelCampo
{
    internal class User
    {
        private int IdUser { get; }
        private string Name { get; set; }
        private string Surname { get; set; }
        private string Email { get; set; }
        private string Pass { get; set; }
        private int Phone { get; set; }
        private string Adress { get; set; }
        private string DNI { get; set; }
        private List<Product> whishList { get; set; }

        public User(int idUser, string name, string surname, string email, string pass, int phone, string adress, string DNI, List<Product> whishList)
        {
            this.IdUser = idUser;
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Pass = pass;
            this.Phone = phone;
            this.Adress = adress;
            this.DNI = DNI;
            this.WishList = wishList;
        }

        public User()
        {


        }

        private void Adduser()
        {


        }

        private User Edituser(int idUser)
        {

            return new User();
        }

        private Boolean DeleteUser(int idUser)
        {

            return true;
        }



        private bool ValidateData(string data, int idUser)
        {

            if (data != null && productID != 0)
            {
                return true;
            }

            return false;
        }

    }
}
