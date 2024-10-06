using AutoMapper;
using CRUDMVCProj.DAL.Models;
using CRUDMVCProj.PL.ViewModels.Employees;

namespace CRUDMVCProj.PL.Mapping
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeViewModel, Employee>().ReverseMap();
            //CreateMap<Employee, EmployeeViewModel>();
        }
    }
}
