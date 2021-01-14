using System.Collections.Generic;
using EPlayers_AspNetCore.Models;

namespace EPlayers_AspNetCore.Interfaces
{
    public interface IPartidas
    {
          void Create(Partida p);

         List<Partida> ReadAll();
         void Update(Partida p);
         void Delete(int id);
    }
}