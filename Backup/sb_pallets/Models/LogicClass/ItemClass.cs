using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sb_pallets.Models
{
    public class ItemClass
    {
        sb_dbDataContext objItem = new sb_dbDataContext();

        public bool addItem(Item_Detail newItem)
        {
            using (objItem)
            {
                objItem.Item_Details.InsertOnSubmit(newItem);
                objItem.SubmitChanges();
                return true;
            }

        }

        public Item_Detail getLastItem()
        {
            return objItem.Item_Details.OrderByDescending(x => x.item_id).FirstOrDefault();
        }

        public IQueryable<int> getAllItemIds()
        {
            return objItem.Item_Details.Select(x=>x.item_id);
        }

        public Item_Detail getItemById(int id)
        {
            var result =  objItem.Item_Details.Where(x => x.item_id == id).First();

            return result;
        }
    }
        
}