﻿using ICities;
using Transit.Addon.ToolsV3.UI.Toolbar.RoadEditor;
using Transit.Addon.ToolsV3.UI.Toolbar.RoadEditor.Textures;
using Transit.Framework;
using Transit.Framework.ExtensionPoints.UI;
using Transit.Framework.Modularity;

namespace Transit.Addon.ToolsV3
{
    public partial class ToolModuleV3 : ModuleBase
    {
        public override void OnInstallingContent()
        {
            base.OnInstallingContent();

            if (TrafficToolsOptions != ModOptions.None)
            {
                GameMenuManager.AddToolbarItem<RoadEditorToolbarItemInfo>();
                GameMenuManager.AddBigSeparator(12);
            }
        }

        public override void OnReleased()
        {
            base.OnReleased();

            // Not required
            //ToolsModifierControl.toolController.RemoveTool<LaneRoutingTool>();
            //ToolsModifierControl.toolController.RemoveTool<LaneRestrictorTool>();
            //ToolsModifierControl.toolController.RemoveTool<TrafficLightsTool>();
        }

        public override void OnLevelLoaded(LoadMode mode)
        {
            if (mode == LoadMode.NewGame || mode == LoadMode.LoadGame)
            {
                InstallTools();
            }
        }

        public override void OnLevelUnloading()
        {
            UninstallTools();
        }
    }
}