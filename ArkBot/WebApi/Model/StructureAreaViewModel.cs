﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkBot.WebApi.Model
{
    public class StructureAreaViewModel
    {
        public StructureAreaViewModel()
        {
            Structures = new List<Structure2ViewModel>();
        }

        public int OwnerId { get; set; }
        public List<Structure2ViewModel> Structures { get; set; }
        public int StructureCount { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public float TopoMapX { get; set; }
        public float TopoMapY { get; set; }
        public float Radius { get; set; }
        public float RadiusPx { get; set; }
        public float TrashQuota { get; set; }
    }
}
