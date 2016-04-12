﻿using System;
using ColossalFramework;
using Transit.Addon.TM.Overlays.LaneRouting;
using Transit.Framework;
using UnityEngine;

namespace Transit.Addon.TM.Tools.LaneDirectionEditor
{
    public partial class LaneDirectionEditor
    {
        public override void RenderOverlay(RenderManager.CameraInfo cameraInfo)
        {
            //Log._Debug($"LaneArrow Overlay: {HoveredNodeId} {HoveredSegmentId} {SelectedNodeId} {SelectedSegmentId}");
            if (_hoveredSegmentId != null && 
                _hoveredNodeId != null && 
                (_hoveredSegmentId != _selectedSegmentId || _hoveredNodeId != _selectedNodeId))
            {
                var netFlags = Singleton<NetManager>.instance.m_nodes.m_buffer[_hoveredNodeId.Value].m_flags;

                if ((netFlags & NetNode.Flags.Junction) != NetNode.Flags.None)
                {
                    NetTool.RenderOverlay(cameraInfo, ref Singleton<NetManager>.instance.m_segments.m_buffer[_hoveredSegmentId.Value], GetToolColor(false, false), GetToolColor(false, false));
                }
            }

            if (_selectedSegmentId != null)
            {
                NetTool.RenderOverlay(cameraInfo, ref Singleton<NetManager>.instance.m_segments.m_buffer[_selectedSegmentId.Value], GetToolColor(true, false), GetToolColor(true, false));
            }

            NodeRoutesOverlay.instance.Render(cameraInfo);
        }
    }
}
