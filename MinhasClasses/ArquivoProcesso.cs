using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasClasses
{
    public class ArquivoProcesso
    {
        public bool ArquivoExiste(string nomeArquivo)
        {
            if (string.IsNullOrEmpty(nomeArquivo))
            {
                throw new ArgumentNullException("nomeArquivo");
            }

            return File.Exists(nomeArquivo);
        }
    }
}
