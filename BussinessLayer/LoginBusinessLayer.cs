﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using BussinessLayer.Models;
using System.Data.SqlClient;

namespace BussinessLayer
{
    public class LoginBusinessLayer
    {
         
        public SqlDataReader LoginUser(string Emailid,string Password)
        {
            LoginDataAccess loginDl = new LoginDataAccess();
            
            return loginDl.Login(Emailid, Password);
            

        }
    }
}
