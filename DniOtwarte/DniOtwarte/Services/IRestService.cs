using DniOtwarte.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DniOtwarte.Services
{
    public interface IRestService
    {
        Task<Rootobject> GetDataAsync();
    }
}
