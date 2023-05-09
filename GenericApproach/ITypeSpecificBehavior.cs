using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach
{
    public interface ITypeSpecificBehavior<T>
    {
        string GetTypeSpecicBehavior<T>(T data) where T : Animal;
    }
}
