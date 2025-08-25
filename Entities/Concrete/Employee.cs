using Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Employee:IEntity
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeUserName { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeeRole { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeePhone { get; set; }
    }
}
