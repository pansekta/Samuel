﻿using System.Configuration;
using System.Data.SqlClient;

namespace Samuel
{
  public class DBConnect
  {
    private static SqlConnection NewCon;
    private static string conStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;

    public static SqlConnection getConnection()
    {
      NewCon = new SqlConnection(conStr);
      return NewCon;
    }

    public DBConnect()
    {

    }

  }
}