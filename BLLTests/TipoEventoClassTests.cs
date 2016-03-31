using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tests
{
    [TestClass()]
    public class TipoEventoClassTests
    {
        TipoEventoClass TipoEvento = new TipoEventoClass();
        [TestMethod()]
        public void TipoEventoClassTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TipoEventoClassTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void InsertarTest()
        {
            TipoEvento.Descripcion = "Prueba de test";        

            Assert.IsTrue(TipoEvento.Insertar());
        }

        [TestMethod()]
        public void EditarTest()
        {
            TipoEventoClass TipoEvento = new TipoEventoClass();
            TipoEvento.TipoEventoId = 1;
            TipoEvento.Descripcion = "Prueba de test";

            bool paso = TipoEvento.Editar();

            Assert.IsTrue(paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            
           
            TipoEvento.TipoEventoId = 3;
            Assert.IsTrue(TipoEvento.Eliminar());
        }

        [TestMethod()]
        public void BuscarTest()
        {
            TipoEventoClass TipoEvento = new TipoEventoClass();
            Assert.IsTrue(TipoEvento.Buscar(TipoEvento.TipoEventoId = 1));
        }

        [TestMethod()]
        public void ListadoTest()
        {
        }

        [TestMethod()]
        public void UnicaDescripcionTest()
        {
            Assert.Fail();
        }
    }

    internal class DataTable
    {
        public object Rows { get; internal set; }
    }
}