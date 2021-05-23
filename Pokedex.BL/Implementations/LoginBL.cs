using Pokedex.BL.Contracts;
using Pokedex.Core.DTO;
using Pokedex.DAL.Contracts;
using Pokedex.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.BL.Implementations
{
    public class LoginBL : ILoginBL
    {
        public ILoginRepository LoginRepository { get; set; }
        public LoginBL(ILoginRepository LoginRepository)
        {
            this.LoginRepository = LoginRepository;
        }
        public bool Login(LoginDTO loginDTO)
        {
            var usuario = new Usuario
            {
                Username = loginDTO.Username,
                password = loginDTO.password
            };

            return LoginRepository.Login(usuario);
        }
    }
}
