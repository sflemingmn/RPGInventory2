﻿using RPG.Intentory.Items.Containers.Restrictions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Intentory.Items.Containers
{
    public class Backpack : Container
    {
        public Backpack() : base(4)
        {
            Name = "A leather backpack.";
            Description = "A rugged leather backpack.";
            Weight = 1;
            Type = ItemType.Container;

            AddRestriction(new CapacityRestriction());
        }
    }
}
