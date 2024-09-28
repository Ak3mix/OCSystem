using OC_System.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Oc_System_DataAccess.Tests.Utilities;
using Moq;
using System;
using OC_System_DataAccess.Concrete;
using System.Data.Entity;
using SQLitePCL;
using OC_System_Contracts;
using OC_System_Contracts.Interfaces;
using OC_System_DataAccess.Repos.RepoEntities;
using OC_System_DataAccess.Concrete;



namespace OC_System_DataAccess.Tests;

[TestClass]
public class FaseTests
{

    private IFaseRepository _faseRepository;
    private IUnitOfWork _unitOfWork;

    public FaseTests()
    {
        ApplicationContext context = new ApplicationContext(ConnectionStringProvider.GetConnectionString());
        _faseRepository = new FaseRepository(context); ;
        _unitOfWork = new UnitOfWork(context);
    }

    [DataRow("Calentamiento", "Fase de calentamiento inicial")]
    [TestMethod]
    public void Can_AddFase(string nombre, string descripcion)
    {

        //Arrange
        Guid id = Guid.NewGuid();
        Fase fase = new Fase(nombre, descripcion);

        //Execute
        _faseRepository.AddFase(fase);
        _unitOfWork.SaveChanges();

        //Assert
        Fase? loadedFase = _faseRepository.GetFaseByID(id);
        Assert.IsNotNull(loadedFase);
    }

}