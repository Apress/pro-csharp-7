using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
  class PointyClassTest : IPointy
  {
    public byte Points => throw new NotImplementedException();
  }
}
