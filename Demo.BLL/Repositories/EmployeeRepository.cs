using Demo.BLL.Interface;
using Demo.BLL.Interfaces;
using Demo.DAL.Contexts;
using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly MVCAppDBContext _dbContext;
        public EmployeeRepository(MVCAppDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
		public IQueryable<Employee> SearchEmployeeByName(string name)
		=>_dbContext.Employees.Where(E=>E.Name.Contains(name));
	}
}
