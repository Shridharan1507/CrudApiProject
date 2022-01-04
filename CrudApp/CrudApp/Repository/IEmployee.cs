using CrudApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudApp.Repository
{
  public interface IEmployee 
    {

        ICollection<Employee> GetEmployees();

        string  CreateEmp(Employee empnew);
    
        String Update(Employee empupd);

        string Delete(int empupd);

        bool ExistsAlready(Employee employee);

        bool ExistsAlreadyBasedOnId(int empid);

        
    }
}
