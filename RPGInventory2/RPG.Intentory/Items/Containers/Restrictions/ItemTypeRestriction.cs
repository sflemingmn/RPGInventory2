using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Intentory.Items.Containers.Restrictions
{
    public class ItemTypeRestriction : IItemRestriction
    {
        private ItemType _typeToRestrict;

        public ItemTypeRestriction(ItemType typeToResctrict)
        {
            _typeToRestrict = typeToResctrict;
        }

        public AddItemStatus AddItem(Item itemToAdd, Container container)
        {
            if(itemToAdd.Type != _typeToRestrict)
            {
                return AddItemStatus.ItemWrongType;
            }
            else
            {
                return AddItemStatus.Ok;
            }
        }
    }
}
