using Pokedex.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.BL.Contracts
{
    public interface ILoginBL
    {
        public bool Login(LoginDTO loginDTO);
    }
}
