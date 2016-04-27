using System;
using AutoMapper;
using AuthenticaEmployee.Models;

namespace AuthenticaEmployee
{
    public static class AutoMapperConfiguration
    {
        public static void RegisterMappings()
        {
            //Maps EmployeeModel to EmployeeViewModel
            Mapper.CreateMap<EmployeeModel, EmployeeViewModel>()
                .ForMember(dest => dest.Fname,
                    opts => opts.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Lname,
                    opts => opts.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Role,
                    opts => opts.MapFrom(src => src.Position))
                .ForMember(dest => dest.Social,
                    opts => opts.ResolveUsing(src =>
                    {
                        string ssn = src.Ssn.ToString();
                        return "XXX-XX-" + ssn.Substring(ssn.Length - 4, 4);
                     }))
                .ForMember(dest => dest.Age,
                   opts => opts.ResolveUsing(src =>
                   {
                       var birthday = src.DoB;
                       var age = DateTime.Today.Year - birthday.Year;
                       if((birthday.Month > DateTime.Now.Month) || ((birthday.Month == DateTime.Now.Month) && (birthday.Day > DateTime.Now.Day)))
                       {
                           age--;
                       }
                       return age;
                   } ));
        }
    }
}