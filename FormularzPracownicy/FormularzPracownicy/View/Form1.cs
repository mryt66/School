using FormularzPracownicy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FormularzPracownicy.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setFormValues(string.Empty, string.Empty, DateTime.Now, 4000, 2, true, false, false);
        }

        public event Action<string> ChangeName;
        public event Action<string> ChangeSurname;
        public event Action<DateTime> ChangeDate;
        public event Action<decimal> ChangeSalary;
        public event Action<int> ChangePosition;
        public event Action<int> ChangeContract;
        public event Action<int> OnEmployeeSelect;
        public event Action AddPerson;
        public event Action SerializeList;
        public event Action DeserializeList;

        public ListBox.ObjectCollection DisplayEmployees
        {
            get
            {
                return listbox_out.Items;
            }
        }

        void send_name(object sender, EventArgs e)
        {
            var name_input = sender as TextBox;
            string name = name_input.Text;
            text_name_Validating(sender, new CancelEventArgs());
            ChangeName?.Invoke(name);
        }

        void send_surname(object sender, EventArgs e)
        {
            var surname_input = sender as TextBox;
            string surname = surname_input.Text;
            text_surname_Validating(sender, new CancelEventArgs());
            ChangeSurname?.Invoke(surname);
        }
        
        void send_date(object sender, EventArgs e)
        {
            var date_input = sender as DateTimePicker;
            DateTime date = date_input.Value;
            ChangeDate?.Invoke(date);
        }

        void send_salary(object sender, EventArgs e)
        {
            var salary_input = sender as NumericUpDown;
            decimal salary = salary_input.Value;
            ChangeSalary?.Invoke(salary);
        }

        void send_position(object sender, EventArgs e)
        {
            var position_input = sender as ComboBox;
            int position = position_input.SelectedIndex;
            ChangePosition?.Invoke(position);
        }

        void send_contract(object sender, EventArgs e)
        {

            int contract = 0;
            
            if (radiobutton_1.Checked)
            {
                contract = 0;
            }
            else if (radiobutton_2.Checked)
            {
                contract = 1;
            }
            else if (radiobutton_3.Checked)
            {
                contract = 2;
            }

            ChangeContract?.Invoke(contract);
        }


        public void setFormValues(string name, string surname, DateTime date, decimal salary, int position, bool r1, bool r2, bool r3)
        {
            textbox_name.Text = name;
            textbox_surname.Text = surname;
            datepicker_birthdate.Value = date;
            numeric_salary.Value = salary;
            combobox_position.SelectedIndex = position;
            radiobutton_1.Checked = r1;
            radiobutton_2.Checked = r2;
            radiobutton_3.Checked = r3;
        }

        void add_person(object sender, EventArgs e)
        {
            AddPerson?.Invoke();
            setFormValues(string.Empty, string.Empty, DateTime.Now, 4000, 2, true, false, false);
        }

        void serialize_list(object sender, EventArgs e)
        {
            SerializeList?.Invoke();
        }

        void deserialize_list(object sender, EventArgs e)
        {
            DeserializeList?.Invoke();
        }

        void on_employee_select(object sender, EventArgs e)
        {
            var listbox = sender as ListBox;
            int index = listbox.SelectedIndex;
            OnEmployeeSelect?.Invoke(index);
        }
        

        void text_surname_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textbox_surname.Text))
            {
                errorProvider_surname.SetError(sender as TextBox, "Wpisz nazwisko!");
            }
            else
            {
                errorProvider_surname.SetError(sender as TextBox, null);
            }
        }


        void text_name_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textbox_name.Text))
            {
                errorProvider_name.SetError(sender as TextBox, "Wpisz imię!");
            }
            else
            {
                errorProvider_name.SetError(sender as TextBox, null);
            }
        }


        private void groupBox_form_Enter(object sender, EventArgs e)
        {

        }

        private void radiobutton_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void combobox_position_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
