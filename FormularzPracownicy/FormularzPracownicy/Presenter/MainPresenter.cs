using FormularzPracownicy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FormularzPracownicy.Presenter
{
    class MainPresenter
    {

        private View.Form1 view1;
        private Model.Employee tmpEmployee;
        private Model.MainModel model1;

        public MainPresenter(View.Form1 view, Model.MainModel model)
        {
            view1 = view;
            model1 = model;

            tmpEmployee = new Model.Employee("","",DateTime.Today,4000,Position.Lekarz,TypeOfContract.prace);

            view1.ChangeName += _view_ChangeName;
            view1.ChangeSurname += _view_ChangeSurname;
            view1.ChangeDate += _view_ChangeDate;
            view1.ChangeSalary += _view_ChangeSalary;
            view1.ChangePosition += _view_ChangePosition;
            view1.ChangeContract += _view_ChangeContract;
            view1.AddPerson += _view_AddPerson;
            view1.SerializeList += _view_SerializeList;
            view1.OnEmployeeSelect += _view_OnEmployeeSelect;
            view1.DeserializeList += _view_DeserializeList;

        }

        private void _view_ChangeName(string name)
        {
            tmpEmployee.Name = name;
        }

        private void _view_ChangeSurname(string surname)
        {
            tmpEmployee.Surname = surname;
        }

        private void _view_ChangeDate(DateTime date)
        {
            tmpEmployee.Birthdate = date;
        }

        private void _view_ChangeSalary(decimal salary)
        {
            tmpEmployee.Salary = salary;
        }

        private void _view_ChangePosition(int position_id)
        {
            if (position_id == 0)
            {
                tmpEmployee.Position = Model.Position.Lekarz;
            }

            else if (position_id == 1)
            {
                tmpEmployee.Position = Model.Position.Fizyk;
            }

            else if (position_id == 2)
            {
                tmpEmployee.Position = Model.Position.Akrobata;
            }

            else if (position_id == 3)
            {
                tmpEmployee.Position = Model.Position.Malarz;
            }

            else if (position_id == 4)
            {
                tmpEmployee.Position = Model.Position.Tester;
            }
        }

        private void _view_ChangeContract(int contract_id)
        {
            if (contract_id == 0)
            {
                tmpEmployee.Contract = Model.TypeOfContract.prace;
            }

            else if (contract_id == 1)
            {
                tmpEmployee.Contract = Model.TypeOfContract.b2b;
            }

            else if (contract_id == 2)
            {
                tmpEmployee.Contract = Model.TypeOfContract.zlecenie;
            }
        }

        private void _view_AddPerson()
        {
            model1.AddEmployee(tmpEmployee);
            tmpEmployee = new Model.Employee("", "", DateTime.Today, 4000, Position.Lekarz, TypeOfContract.prace);
            updateView();
        }

        private void updateView()
        {
            view1.DisplayEmployees.Clear();
            foreach (Employee e in model1.getList())
            {
                view1.DisplayEmployees.Add(e.ToString());
            }
        }

        private void _view_SerializeList()
        {
            Console.WriteLine("Serializacja");
            model1.SerializeList(model1.getList());
        }

        private void _view_DeserializeList()
        {
            Console.WriteLine("Deserializacja");
            model1.DeserializeList();
            updateView();
        }

        private void _view_OnEmployeeSelect(int index)
        {

            tmpEmployee = model1.getList()[index];
            int position = 0;
            if (tmpEmployee.Position == Position.Lekarz) { position = 0; }
            else if (tmpEmployee.Position == Position.Fizyk) { position = 1; }
            else if (tmpEmployee.Position == Position.Akrobata) { position = 2; }
            else if (tmpEmployee.Position == Position.Malarz) { position = 3; }
            else if (tmpEmployee.Position == Position.Tester) { position = 4; }

            bool r1 = true;
            bool r2 = false;
            bool r3 = false;

            if (tmpEmployee.Contract == TypeOfContract.prace) 
            {

                r1 = true;
                r2 = false;
                r3 = false;

            }

            else if (tmpEmployee.Contract == TypeOfContract.b2b)
            {
                r1 = false;
                r2 = true;
                r3 = false;
            }

            else if (tmpEmployee.Contract == TypeOfContract.zlecenie) 
            {
                r1 = false;
                r2 = false;
                r3 = true;
            }

            view1.setFormValues(tmpEmployee.Name, tmpEmployee.Surname, tmpEmployee.Birthdate, tmpEmployee.Salary, position, r1, r2, r3);
        }
    }
}
