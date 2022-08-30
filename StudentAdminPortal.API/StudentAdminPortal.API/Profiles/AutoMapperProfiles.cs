using AutoMapper;
using DataModels = StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;


namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Student, Student>().ReverseMap();

            CreateMap<Gender, Gender>().ReverseMap();

            CreateMap<Address, Address>().ReverseMap();
        }
    }
}
