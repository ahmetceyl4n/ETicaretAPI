using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories.InvoiceFile
{
    public class InvoiceFileReadRepository : ReadRepository<ETicaretAPI.Domain.Entities.InvoiceFile>, ETicaretAPI.Application.Repositories.IInvoiceFileReadRepository
    {
        public InvoiceFileReadRepository(ETicaretAPI.Persistence.Contexts.ETicaretAPIDbContext context) : base(context)
        {


        }

    }
}
