using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Music.Entities
{
    public interface IRepository<T> where T :class
    {
        IEnumerable<T> GetAllAsync();
    }
}
