using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace ToDoList
{
  public class Task
  {
    private int _id;

    private string _description;

    public Task(string description, int Id = 0)
    {

      _id = Id;
      _description = description;

    }

    public int GetId()
    {
      return _id;
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public static List<Task> GetAll()
    {
      List<Task> allTasks = new List<Task>{};

      SqlConnection conn = DB.Connection();
      conn.Open();

      SqlCommand cmd = new SqlCommand("SELECT * FROM tasks;", conn);
      SqlDataReader rdr = cmd.ExecuteReader();

      while(rdr.Read())
      {
        int taskId = rdr.GetInt32(0);
        string taskDescription = rdr.GetSTring(1);
        Task newTask = new Task(taskDescription, taskId);
        allTasks.Add(newTask);
      }
      if (rdr != null)
      {
        rdr.Close();
      }
       if (conn != null)
       {
         conn.Close();
       }

       return allTasks;
    
    }
  }
}
