using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.BLL.Interface;
using Demo.BLL.Repositories;
using Demo.DAL.Contexts;
using Demo.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.BLL.Repository
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
		private readonly MVCAppDBContext _dbContext;
		public DepartmentRepository(MVCAppDBContext dbContext) : base(dbContext)
        {
			_dbContext = dbContext;
        }
		public IQueryable<Department> SearchEmployeeByName(string name)
		=> _dbContext.Departments.Where(D=>D.Name.Contains(name));
	}
}
