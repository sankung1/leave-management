﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using leave_management.Contracts;
using leave_management.Data;

namespace leave_management.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public ICollection<Employee> FindAll()
        {
            throw new NotImplementedException();
        }

        public Employee FindById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Create(Employee entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public ICollection<Employee> GetEmployeesByEmployees(int id)
        {
            throw new NotImplementedException();
        }
    }
}
