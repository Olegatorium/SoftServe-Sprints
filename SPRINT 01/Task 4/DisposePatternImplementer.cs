using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPRINT_01.Task_4
{
    public class DisposePatternImplementer : CloseableResource, IDisposable
    {
        private bool disposed = false;

        ~DisposePatternImplementer()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources
                    Console.WriteLine("Disposing by developer");
                }
                else
                {
                    // Dispose unmanaged resources
                    Console.WriteLine("Disposing by GC");
                }

                // Close the resource in either case
                Close();

                disposed = true;
            }
        }
    }
}
