using Xunit;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ToDoList
{
  public class ToDoTest : IDisposible
  {
    public ToDoTest()
    {
      DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=todo_test; Integrated Security=SSPI;"

    }

    public void Dispose()
    {
      Task.DeleteAll();
    }
    [Fact]
    public void Test_Equal_ReturnsTrueIfDescriptionsAreTheSame()
    {
      //Arrange, Act
      Task firstTask = new Task("Jump up and down");
      Task secondTask = new Task("Do Something Different");

      //Assert
      Assert.Equal(fistTask, secondTask);

      [Fact]
  public void Test_Save_SavesToDatabase()
  {
    //Arrange
    Task testTask = new Task("Mow the lawn");

    //Act
    testTask.Save();
    List<Task> result = Task.GetAll();
    List<Task> testList = new List<Task>{testTask};

    //Assert
    Assert.Equal(testList, result);
  }
    }
  }
}
