using System;
namespace Vandrarhem.Models.Repository
{
   public interface IDbRepository
    {
        System.Collections.Generic.IList<VandrarhemDbAccess.Bokningar> SeBokningar();
        System.Collections.Generic.IList<VandrarhemDbAccess.Kund> SeKunder();
    }
}
