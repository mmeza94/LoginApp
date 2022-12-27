using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LoginViewModel
{
    public class Helpers
    {


        public static Dictionary<string,object> GenerateParameters(string email,object Password)
        {
            var pass = ((PasswordBox)Password).Password;
            Dictionary<string,object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@email", email);
            Parameters.Add("@Password", pass);

            return Parameters;

        }










    }
}
