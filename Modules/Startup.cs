using System.IO;
using Microsoft.AspNet.Builder;
using Nancy.Owin;
using Nancy;

namespace ToDoList
{
  public class Startup
  {
    public void Configure(IApplicationBuilder app)
    {
      app.UseOwin(x => x.UseNancy());
    }
  }
  public class CustomRootPathProvider : IRootPathProvider
  {
    public string GetRootPath()
    {
      return Directory.GetCurrentDirectory();
    }
    public static class DBConfiguration
    {
        public static string ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=todo;Integrated Security=SSPI;";
    }
  }
}
