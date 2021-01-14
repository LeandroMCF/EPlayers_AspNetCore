using System;
using System.Collections.Generic;
using EPlayers_AspNetCore.Interfaces;

namespace EPlayers_AspNetCore.Models
{
    public class Partida : EplayersBase , IPartidas
    {
        public int IdPartida { get; set; }
        public int IdJogador1 { get; set; }
        public int IdJogador2 { get; set; }
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioTermino { get; set; }
        private const string PATH = "Database/Equipe.csv";
        public Partida()
        {
            CreateFolderAndFile(PATH);
        }

        public void Create(Partida p)
        {
            throw new NotImplementedException();
        }

        public List<Partida> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Partida p)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}