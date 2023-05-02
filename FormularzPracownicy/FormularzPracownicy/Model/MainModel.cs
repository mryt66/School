using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace FormularzPracownicy.Model
{
    internal class MainModel
    {
        private List<Employee> employees_list;

        public MainModel()
        {
            employees_list = new List<Employee>();
        }

        public List<Employee> getList() 
        { 
            return employees_list; 
        }

        public void AddEmployee(Employee employee)
        {
            employees_list.Add(employee);
        }

        public void SerializeList(List<Employee> employees_list)
        {

            XmlSerializer xs = new XmlSerializer(typeof(List<Employee>));
            Stream s = File.Create("employees.xml");
            xs.Serialize(s, employees_list);
            s.Close();

        }

        public void DeserializeList()
        {

            List<Employee> list;
            XmlSerializer xs = new XmlSerializer(typeof(List<Employee>));
            Stream s = File.OpenRead("employees.xml");
            list = (List<Employee>)xs.Deserialize(s);
            s.Close();

            employees_list = list;
        }

    }
}
