using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode.AbstractFactoryPattern
{
    class Department
    {
        private int _id;
        public int ID { get => ID; set => _id = value; }
        private string _departName;
        public string DepartName { get => _departName; set => _departName = value; }
    }

    interface IDepartment
    {
        void Insert(Department department);
        Department GetDepartment(int id);
    }

    class SqlServerDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在SQL Server中给Department表增加一条记录");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在SQL Server中根据ID得到Department表一条记录");
            return null;
        }
    }
}
