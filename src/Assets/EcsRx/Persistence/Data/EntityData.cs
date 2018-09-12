﻿using System.Collections.Generic;
using EcsRx.Components;

namespace EcsRx.Persistence.Data
{
    public class EntityData
    {
        public int EntityId { get; set; }
        public IList<IComponent> Components { get; set; }

        public EntityData()
        {
            Components = new List<IComponent>();
        }
    }
}