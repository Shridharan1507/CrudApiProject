using CrudApp.Data;
using CrudApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Repository
{
    public class EmployeeService : IEmployee
    {

        private readonly EmpContext _emp;

        public EmployeeService(EmpContext emp)
        {
            _emp = emp;
        }

        public string CreateEmp(Employee empnew)
        {
            _emp.Add(empnew);
            _emp.SaveChanges();
            return "Created Sucessfully";

        }
       
        public ICollection<Employee> GetEmployees()
        {
            return _emp.Employees.OrderBy(x => x.EmployeeName).ToList();
        }

        public String Update(Employee empupd)
        {
            _emp.Update(empupd);
            _emp.SaveChanges();
            return "Updated Sucessfully";
        }

        public string Delete(int empupd)
        {
            Employee emp = _emp.Employees.Where(x => x.EmployeeId == empupd).Single<Employee>();
            _emp.Employees.Remove(emp);
            _emp.SaveChanges();
            return "Deleted Successfully";

        }

        public bool ExistsAlready(Employee employee)
        {
            bool value = _emp.Employees.Any(a => a.EmployeeName.ToLower().Trim() == employee.EmployeeName.ToLower().Trim());
            return value;
        }

        public bool ExistsAlreadyBasedOnId(int empid)
        {
            bool value = _emp.Employees.Any(a => a.EmployeeId == empid);
            return value;
        }
    }
}

