using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinhasClasses;
using System;

namespace MinhasClassesTeste
{
    [TestClass]
    public class ArquivoProcessoTeste
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void NomeArquivoExiste()
        {
            ArquivoProcesso ap = new ArquivoProcesso();
            bool resultado;

            resultado = ap.ArquivoExiste(@"C:\Cursos\Arquivo.txt");

            Assert.IsTrue(resultado);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void NomeArquivoNaoExiste()
        {
            ArquivoProcesso ap = new ArquivoProcesso();
            bool resultado;

            resultado = ap.ArquivoExiste(@"C:\Arquivo.txt");

            Assert.IsFalse(resultado);
        }

        /// <summary>
        /// Teste unitário que trata o tipo da exceção esperado
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NomeArquivoNuloOuVazioDisparoExcecao()
        {
            ArquivoProcesso ap = new ArquivoProcesso();

            ap.ArquivoExiste("");
        }

        [TestMethod]
        public void NomeArquivoNuloOuVazioDisparoExcecaoUsandoTryCatch()
        {
            ArquivoProcesso ap = new ArquivoProcesso();

            try
            {
                ap.ArquivoExiste("");
            }
            catch (ArgumentException)
            {
                //Teste bem sucedido
                return;
            }

            Assert.Fail("Falha");
        }
    }
}
