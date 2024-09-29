using OC_System.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using OC_System.Contracts.Interfaces;
using OC_System.DataAccess.Concrete;
using OC_System.DataAccess.Repos.RepoEntities;
using OC_System_Contracts;
using Oc_System.DataAccess.Test.Utilities;
using OC_System.Contracts;
using Microsoft.VisualStudio.TestPlatform.Common.Telemetry;
using System.Xml.Linq;



namespace OC_System.DataAccess.Test
{

    [TestClass]
    public class FaseTests
    {

        private IFaseRepository _faseRepository;
        private IUnitOfWork _unitOfWork;
        private IRecetaRepository _recetaRepository;

        public FaseTests()
        {
            ApplicationContext context = new ApplicationContext(ConnectionStringProvider.GetConnectionString());
            _faseRepository = new FaseRepository(context); 
            _recetaRepository= new RecetaRepository(context);
            _unitOfWork = new UnitOfWork(context);
        }

        [DataRow("Calentamiento","iqwe34","Fase de calentamiento inicial", "Receta1", "w12331","Descripcion", "io34")]
        [TestMethod]
        public void Can_AddFase(string nombre, string code, string descripcion, string rnombre, string rcode ,string rdescripcion, string codigoUnidad)
        {

            //Arrange
            Receta receta= new Receta(rnombre,rcode,rdescripcion,codigoUnidad);
            Fase fase = new Fase(nombre, code, descripcion, receta);


            //Execute
            _recetaRepository.AddReceta(receta);
            _faseRepository.AddFase(fase);
            _unitOfWork.SaveChanges();

            //Assert
            Fase? loadedFase = _faseRepository.GetFaseByID(fase.Id);
            Assert.IsNotNull(loadedFase);
        }

    }
}