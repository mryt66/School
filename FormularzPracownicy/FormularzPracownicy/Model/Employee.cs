using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularzPracownicy.Model
{
    public enum Position {Lekarz, Fizyk, Akrobata, Malarz, Tester};
    public enum TypeOfContract {prace, b2b, zlecenie};

    public class Employee
    {
        private String name1;
        private String surname1;
        private DateTime birthdate1;
        private decimal salary1;
        private Position position1;
        private TypeOfContract contract1;

        public Employee() { }

        public Employee(string name, string surname, DateTime birthdate, decimal salary, Position position, TypeOfContract contract)
        {
            name1 = name;
            surname1 = surname;
            birthdate1 = birthdate;
            salary1 = salary;
            position1 = position;
            contract1 = contract;
        }

        public string Name
        {
            get { return name1; }
            set { name1 = value; }
        }

        public string Surname
        {
            get { return surname1; }
            set { surname1 = value; }
        }

        public DateTime Birthdate
        {
            get { return birthdate1; }
            set { birthdate1 = value; }
        }

        public decimal Salary
        {
            get { return salary1; }
            set  { salary1 = value; }
        }

        public TypeOfContract Contract
        {
            get { return contract1; }
            set { contract1 = value; }
        }

        public Position Position
        {
            get { return position1; }
            set { position1 = value; }
        }

        public override string ToString()
        {

            string type_of_contract = "";
            string position = "";    

            if (position1 == Position.Lekarz)
            {
                position = "Lekarz";
            }
            if (position1 == Position.Fizyk)
            {
                position = "Fizyk";
            }
            if (position1 == Position.Akrobata)
            {
                position = "Akrobata";
            }
            if (position1 == Position.Malarz)
            {
                position = "Malarz";
            }
            if (position1 == Position.Tester)
            {
                position = "Tester";
            }

            if (contract1 == TypeOfContract.prace)
            {
                type_of_contract = "Umowa o pracę";
            }
            if (contract1 == TypeOfContract.b2b)
            {
                type_of_contract = "B2B";
            }
            if (contract1 == TypeOfContract.zlecenie)
            {
                type_of_contract = "Umowa zlecenie";
            }

            return $" {name1} {surname1} ; Data urodzenia: {birthdate1.ToShortDateString().ToString()} ; "  +
                $"Stanowisko: {position} ; Rodzaj umowy: {type_of_contract} ; Pensja: {salary1} zł ";
        }
    }
}
