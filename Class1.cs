using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ListViewProgram
{
    class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string dateOfBirth;
        public string DateOfBirth
        {
            get => dateOfBirth;
            set { dateOfBirth = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DateOfBirth")); }
        }
        private int birthNumber;
        public int BirthNumber
        {
            get => birthNumber;
            set { birthNumber = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BirthNumber")); }
        }
        public static Dictionary<string, Person> AllPeople = new Dictionary<string, Person>();
        public static void InitPersons()
        {
            AllPeople["Tonda Houška"] = new Person
            {
                DateOfBirth = "13. June 2002",
                BirthNumber = 25263732,

            };
            AllPeople["Lucie Houšková"] = new Person
            {
                DateOfBirth = "20. April 2005",
                BirthNumber = 4631635,

            };
        }
    }
}
