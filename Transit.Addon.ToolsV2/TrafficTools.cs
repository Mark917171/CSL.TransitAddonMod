﻿using System;
using Transit.Framework.Modularity;

namespace Transit.Addon.ToolsV2
{
    [Module("Transit.Addon.Mod")]
    public partial class TrafficToolsModule : ModuleBase
    {
        public override string Name
        {
            get { return "Tools V2"; }
        }
    }
}
