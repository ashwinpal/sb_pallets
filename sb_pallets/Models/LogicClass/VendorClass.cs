using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using sb_pallets.Models;

namespace sb_pallets.Models
{
    public class VendorClass
    {
        sb_dbDataContext objVendor = new sb_dbDataContext();

        public bool addItem(Vendor_Detail newVendor)
        {
            using (objVendor)
            {
                objVendor.Vendor_Details.InsertOnSubmit(newVendor);
                objVendor.SubmitChanges();
                return true;
            }

        }

        public Vendor_Detail getLastItem()
        {
            return objVendor.Vendor_Details.OrderByDescending(x => x.vendor_id).FirstOrDefault();
        }

    }
}