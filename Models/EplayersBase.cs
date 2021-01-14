using System.Collections.Generic;
using System.IO;

namespace EPlayers_AspNetCore.Models
{
    public class EplayersBase
    {
        public void CreateFolderAndFile(string _path)
        {
            string folder = _path.Split("/")[0];

            if(!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if(!File.Exists(_path))
            {
                File.Create(_path).Close();
            }
        }

        public List<string> ReadAllLinesCSV(string _path)
        {
            List<string> linhas = new List<string>();
            using(StreamReader file = new StreamReader(_path))
            {
                string linha;
                
                while ((linha = file.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
            }
            return linhas;
        }

        public void ReWriteCSV(string _path, List<string> linhas)
        {
            using(StreamWriter output = new StreamWriter(_path))
            {
                foreach (var item in linhas)
                {
                    output.Write(item + '\n');
                }
            }
        }
    }
}