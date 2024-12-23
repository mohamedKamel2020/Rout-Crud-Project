using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.BLL.Interfaces;
using Demo.DAL.Entities;

namespace Demo.BLL.Interface
{
	public interface IDepartmentRepository:IGenericRepository<Department>
	{
		IQueryable<Department> SearchEmployeeByName(string name);
	}
}
