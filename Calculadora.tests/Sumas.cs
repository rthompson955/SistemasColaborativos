using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica.Negocio;

namespace Calculadora.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumarUnoMasDos()
        {
            // Paso 1. defina el escenario de la prueba
            var elPrimerOperando = 1;
            var elSegundoOperando = 2;
            var elResultadoEsperado = 3;

            // Paso 2. invoque al metodo que se desea validar
            var laReferencia = new Suma();
            var elResultadoReal = laReferencia.Operar(elPrimerOperando, elSegundoOperando);

            // Paso 3, Comparacion del resultado obtenido con el esperado.

            Assert.AreEqual(elResultadoEsperado, elResultadoReal);

        }
    }
}
