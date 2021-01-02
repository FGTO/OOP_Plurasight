using System;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerID { get; private set; }
    
        public string EmailAdress { get; set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }
        public string VariableName;

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
    }
}
