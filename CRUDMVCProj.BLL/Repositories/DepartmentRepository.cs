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
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {


        public DepartmentRepository(AppDbContext context) :base(context) //ASK CLR Create Object From AppDbContext
        {

        }

      

    }
}
