using OC_System.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using OC_System_Contracts.Interfaces;
using OC_System.DataAccess.Concrete;
using OC_System.DataAccess.Repos.RepoEntities;
using OC_System_Contracts;
using Oc_System.DataAccess.Test.Utilities;



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
            _faseRepository = new FaseRepository(context); ;
            _unitOfWork = new UnitOfWork(context);
        }

        [DataRow("Calentamiento", "Fase de calentamiento inicial", "Receta1", "Descripcion", "io34")]
        [TestMethod]
        public void Can_AddFase(string nombre, string descripcion, string rnombre, string rdescripcion, string codigoUnidad)
        {

            //Arrange
            Guid id = Guid.NewGuid();
            Receta receta = new Receta(rnombre, rdescripcion, codigoUnidad);
            Fase fase = new Fase(nombre, descripcion, receta);

            //Execute
            _recetaRepository.AddReceta(receta);
            _faseRepository.AddFase(fase);
            _unitOfWork.SaveChanges();

            //Assert
            Fase? loadedFase = _faseRepository.GetFaseByID(id);
            Assert.IsNotNull(loadedFase);
        }

    }
}