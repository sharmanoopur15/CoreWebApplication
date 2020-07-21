using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeModel.Repository.Inteface
{
   interface IRegister
    {
        int RegisterUser(RegisterViewModel registerViewModel);
    }
}
