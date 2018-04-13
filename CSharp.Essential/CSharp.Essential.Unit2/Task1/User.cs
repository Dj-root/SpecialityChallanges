using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Essential.Unit2
{
    class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LatName { get; set; }
        public int Age { get; set; }
        private readonly DateTime fillDate;

        public User( string login, string firstName, string latName, int age)
        {
            this.fillDate = DateTime.Now;
            Login = login;
            FirstName = firstName;
            LatName = latName;
            Age = age;
        }

        public void GetUserInfo()
        {
            Console.WriteLine("Information about user:\nLogin:\t\t{0}" +
                              "\nFirst Name:\t{1} \nLast Name:\t{2} \nAge:\t\t{3}" +
                              "\nFill Date:\t{4}", Login, FirstName,LatName, Age, FillDate);
        }

        public DateTime FillDate
        {
            get { return fillDate; }
        }
    }
}


//todo: Login, name, surname, age, filling date(readonly)