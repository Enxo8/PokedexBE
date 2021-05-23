using AutoMapper;
using Pokedex.BL.Contracts;
using Pokedex.Core.DTO;
using Pokedex.DAL.Contracts;
using Pokedex.DAL.Entities;
using Pokedex.DAL.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.BL.Implementations
{
    public class UsuariosBL : IUsuariosBL
    {
        public UsuariosRepository usuarioRepository { get; set; }
        public IMapper mapper { get; set; }
        public UsuariosBL(IUsuariosRepository usuarioRepository, IMapper mapper)
        {
            this.usuarioRepository = (UsuariosRepository)usuarioRepository;
            this.mapper = mapper;
        }

        public void Insertar(UsuariosDTO usuarioDTO)
        {
            var usuario = mapper.Map<UsuariosDTO, Usuario>(usuarioDTO);
            usuarioRepository.Insertar(usuario);
        }

        public void Actualizar(UsuariosDTO usuarioDTO)
        {
            var usuario = mapper.Map<UsuariosDTO, Usuario>(usuarioDTO);
            usuarioRepository.Actualizar(usuario);
        }

        public void Delete(string username)
        {
            usuarioRepository.Delete(username);
        }

       
    }
}
