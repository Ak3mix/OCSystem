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

        [DataRow("Calentamiento", "iqwe34", "Fase de calentamiento inicial")]
        [TestMethod]
        public void Can_AddFase(string nombre, string code, string descripcion)
        {

            //Arrange
            Guid id =Guid.NewGuid();
            Fase fase = new Fase(id,nombre, code, descripcion);


            //Execute
           
            _faseRepository.AddFase(fase);
            _unitOfWork.SaveChanges();

            //Assert
            Fase? loadedFase = _faseRepository.GetFaseByID(fase.Id);
            Assert.IsNotNull(loadedFase);
        }

    }
}