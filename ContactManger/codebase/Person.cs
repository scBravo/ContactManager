using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ContactManger.codebase
{
    [Serializable]    
    class Person : IPerson
    {
        private string address;
        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
                //Implement some logic 
            }
        }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value > 0 && value < 90)
                    age = value;
                else
                    //TODO: Write catch code when UI is created;
                    throw new ArgumentException("Not correct age!");
            }
        }
        private DateTime birthday;
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                if (value < DateTime.Now)
                    birthday = value;
                else
                    throw new ArgumentException("Youre contact isn't guest from the future ;)");
            }
        }

        public string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }
        //TODO: This code must compare value with help regular expression;
        private string homePhoneNumber;
        public string HomePhoneNumber
        {
            get
            {
                return homePhoneNumber;
            }

            set
            {//TODO: realize
                throw new NotImplementedException();
            }
        }

        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        private string mobilePhoneNumber;
        public string MobilePhoneNumber
        {
            get
            {
                return mobilePhoneNumber;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        private string organization;
        public string Organization
        {
            get
            {
                return organization;
            }

            set
            {
                organization = value;
            }
        }
    }
}
