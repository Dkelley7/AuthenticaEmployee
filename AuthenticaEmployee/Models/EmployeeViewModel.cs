

namespace AuthenticaEmployee.Models
{
    public class EmployeeViewModel /*: ICustomMappings*/
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Social { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }

        
   /* public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<EmployeeModel, EmployeeViewModel>()
                .ForMember(dest => dest.Fname,
                    opts => opts.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.Lname,
                    opts => opts.MapFrom(src => src.LastName))
                .ForMember(dest => dest.Role,
                    opts => opts.MapFrom(src => src.Position))
                .ForMember(dest => dest.Social,
                    opts => opts.MapFrom(src => src.Ssn))
                .ForMember(dest => dest.Age,
                   opts => opts.MapFrom(src => src.Position));
        }*/
    }
}