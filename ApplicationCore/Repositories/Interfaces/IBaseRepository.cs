using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Repositories.Interfaces
{
    public interface IBaseRepository<T> where T: class
    {
        IEnumerable<T> List();
    }
}
