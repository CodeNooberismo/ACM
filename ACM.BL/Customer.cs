using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        //Code for notes only....
        //private string _lastName;

        //public string LastName
        //{
        //    get
        //    {
        //        //ANY Code here.....
        //        return _lastName;
        //    }
        //    set
        //    {
        //        //ANY Code here......
        //        _lastName = value;
        //    }
        //}

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerID { get; private set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }



    }
}
