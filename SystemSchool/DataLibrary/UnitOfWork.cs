using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemSchool.DataLibrary
{
    public class UnitOfWork

    {
        private SisSchoolContextDataContext context = new SisSchoolContextDataContext();
        private GenericRepository<Inscripccion> InscripcionRepository;
        public GenericRepository<Inscripccion> inscripcionRepository
        {
            get
            {

                if (this.inscripcionRepository == null)
                {
                    this.inscripcionRepository = new GenericRepository<Inscripccion>(context);
                }
                return inscripcionRepository;
            }
        }




        public void Save()
        {
            context.SubmitChanges();
           
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}




