using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPro
{
    class Minimal_DisposePattern:IDisposable
    {
        private SqlConnection connection = new SqlConnection();

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    class Complete_DisposePattern : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
