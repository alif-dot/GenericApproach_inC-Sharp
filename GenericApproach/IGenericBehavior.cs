using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach
{
    public interface IGenericBehavior<T>
    {
        string GetGenericBehavior(T obj);
    }
}
