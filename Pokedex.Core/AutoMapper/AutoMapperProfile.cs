using AutoMapper;
using Pokedex.Core.DTO;
using Pokedex.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Core.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UsuariosDTO, Usuario>();
            CreateMap<Usuario, UsuariosDTO>();
            CreateMap<LoginDTO, Usuario>();
        }
    }
}
