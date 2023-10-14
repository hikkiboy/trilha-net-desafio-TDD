using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTests
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes;
        
        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesString();
        }


        [Fact]
        public void DeveContar3CaractersEmOlaERetonar3()
        {
            //Arrange
            string texto = "ola";
            //Act
            int resultado =_validacoes.ContarCaracters(texto);
            //Assert
            Assert.Equal(3, resultado);

        }


    }
}