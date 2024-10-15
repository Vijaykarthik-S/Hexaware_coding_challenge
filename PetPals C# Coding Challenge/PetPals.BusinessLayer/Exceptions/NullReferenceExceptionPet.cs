using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals.BusinessLayer.Exceptions
{
    public class NullReferenceExceptionPet : Exception
    {
        public NullReferenceExceptionPet(string message) : base(message) { }
    }
}
