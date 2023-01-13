﻿using Demo.BLL.Interfaces;
using Demo.DAL.Contexts;
using Demo.DAL.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class EmployeeRepository:GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly MVCAppDbContext dbContext;

        public EmployeeRepository(MVCAppDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<Employee> GetEmployeesByName(string name)
            =>dbContext.Employees.Where(E => E.Name.Contains(name));
    }
}
