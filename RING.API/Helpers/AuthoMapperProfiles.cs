using AutoMapper;
using RING.API.Dtos.Generales;
using RING.Generales.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RING.API.Helpers
{
    public class AuthoMapperProfiles : Profile
    {
        public AuthoMapperProfiles()
        {
            CreateMap<Producto, ProductoToReturnDTO>()
            .ForMember(dest => dest.Clasificacion, opt => {
                opt.MapFrom(src => src.Clasificacion.Descripcion);

            });
            
        }

    }
}
