using DientesLimpios.Dominio.Excepciones;
using DientesLimpios.Dominio.ObjetosDeValor;


namespace DientesLimpios.Pruebas.ObjetosDeValor
{
    [TestClass]
    public class EmailTests
    {
        [TestMethod]
        [ExpectedException(typeof(ExcepcionDeReglaDeNegocio))]
        public void Constructor_EmailNulo_LanzaExcepcion()
        {
            new Email(null!);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionDeReglaDeNegocio))]
        public void Constructor_EmailSinArroba_LanzaExcepcion()
        {
            new Email("luigi.com");
        }

        [TestMethod]
        public void Constructor_EmailValido_NoLanzaExcepcion()
        {
            new Email("luigi@ejemplo.com");
        }


    }
}
