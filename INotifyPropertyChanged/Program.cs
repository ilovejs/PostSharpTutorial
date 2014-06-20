using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyPropertyChanged
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerForEditing obj = new CustomerForEditing
            {
                Email = "z@gmail.com",
                FirstName = "Michael",
                LastName = "Zhuang",
                Mobile = "01222333333",
                Phone = "1111111111"
            };
            obj.Email = "kk@gmail.com";
            Console.WriteLine(obj);
        }
    }
}
