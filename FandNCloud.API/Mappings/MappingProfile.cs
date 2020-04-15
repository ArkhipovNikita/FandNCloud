using AutoMapper;
using FandNCloud.API.Resources;
using FandNCloud.Core.Models;

namespace FandNCloud.API.Mappings
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<User, UserResource>();
            
            //Resource to Domain
            CreateMap<UserResource,User > ();

        }
    }
}