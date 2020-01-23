using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorPro
{
    static class Program:IDisposable
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public IEnumerable<Task>Execute(System.Action[] jobs)
        {
            var tasks = new Task[jobs.Length];
            for (int i = 0; i < jobs.Length; i++)
            {
                
            }
            return tasks;

        }
        public void RunJob(Action job, int index)
        {
            tasks[i] = Task.Run(() => RunJob(jobs[i].i);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls
        private bool disposed = false;
        // distructor in dotnet is a finallizer (the finalizer will be called by GC)

       //public void dispose()
       // {
       //     dispose(true);
       //     GC.SuppressFinalize(this); // notifiy GC that this thing/object has been disposed
       // }
       if (!dispossed )
            {
            connection.dispose // expliciete clean
            }

     

        protected virtual void Dispose(bool disposing)
        {
            if (!DisposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                DisposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Program() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion


    }
}
