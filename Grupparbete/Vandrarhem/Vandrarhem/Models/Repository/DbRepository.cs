using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using VandrarhemDbAccess;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vandrarhem.Models.Repository
{
    public class DbRepository : Vandrarhem.Models.Repository.IDbRepository 
    {
        public IList<Kund> SeKunder()
        {
            using (var ctx = new VandrarhemSQLEntities())
            {
                return ctx.Kunds
                    .Include(x => x.Telefon)
                    .ToList();
            }
        }
        public IList<Bokningar> SeBokningar()
        {
            using (var ctx = new VandrarhemSQLEntities())
        {
                return ctx.Bokningars
                    .ToList();
        }
        }

        }
    }

