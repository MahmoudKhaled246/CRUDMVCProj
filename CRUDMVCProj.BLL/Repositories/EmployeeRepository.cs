using Microsoft.EntityFrameworkCore;
using CRUDMVCProj.BLL.Interfaces;
using CRUDMVCProj.DAL.Data.Contexts;
using CRUDMVCProj.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDMVCProj.BLL.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {


        public EmployeeRepository(AppDbContext context) :base(context) 
        {
           
        }

        public async Task<IEnumerable<Employee>> GetByNameAsync(string name)
        {
            return await _context.Employees.Where(E => E.Name.ToLower().Contains(name.ToLower())).Include(E=>E.WorkFor).ToListAsync();
        }
    }
}
