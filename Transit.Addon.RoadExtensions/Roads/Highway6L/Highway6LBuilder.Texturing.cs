﻿using Transit.Framework;

namespace Transit.Addon.RoadExtensions.Roads.Highway6L
{
    public partial class Highway6LBuilder
    {
        private static void SetupTextures(NetInfo info, NetInfoVersion version)
        {
            ///////////////////////////
            // Texturing             //
            ///////////////////////////
            switch (version)
            {
                case NetInfoVersion.Ground:
                    info.SetAllSegmentsTexture(
                        new TexturesSet(
                            @"Roads\Highway6L\Textures\Ground\Segment__MainTex.png",
                            @"Roads\Highway6L\Textures\Ground\Segment__APRMap.png"),
                    new LODTexturesSet
                           (@"Roads\Highway6L\Textures\Ground\SegmentLOD__MainTex.png",
                            @"Roads\Highway6L\Textures\Ground\SegmentLOD__APRMap.png",
                            @"Roads\Highway6L\Textures\Ground\SegmentLOD__XYSMap.png"));
                    info.SetAllNodesTexture(
                        new TexturesSet
                           (@"Roads\Highway6L\Textures\Ground\Node__MainTex.png",
                            @"Roads\Highway6L\Textures\Ground\Node__APRMap.png"),
                        new LODTexturesSet
                           (@"Roads\Highway6L\Textures\Ground\NodeLOD__MainTex.png",
                            @"Roads\Highway6L\Textures\Ground\NodeLOD__APRMap.png",
                            @"Roads\Highway6L\Textures\Ground\NodeLOD__XYSMap.png"));
                    break;

                case NetInfoVersion.Elevated:
                case NetInfoVersion.Bridge:
                    info.SetAllSegmentsTexture(
                        new TexturesSet(
                            @"Roads\Highway6L\Textures\ElevatedBridge\Segment__MainTex.png",
                            @"Roads\Highway6L\Textures\ElevatedBridge\Segment__APRMap.png"),
                        new LODTexturesSet
                           (@"Roads\Highway6L\Textures\ElevatedBridge\SegmentLOD__MainTex.png",
                            @"Roads\Highway6L\Textures\ElevatedBridge\SegmentLOD__APRMap.png",
                            @"Roads\Highway6L\Textures\ElevatedBridge\LOD__XYSMap.png"));
                    info.SetAllNodesTexture(
                        new TexturesSet
                           (@"Roads\Highway6L\Textures\ElevatedBridge\Node__MainTex.png",
                            @"Roads\Highway6L\Textures\ElevatedBridge\Node__APRMap.png"),
                        new LODTexturesSet
                           (@"Roads\Highway6L\Textures\ElevatedBridge\NodeLOD__MainTex.png",
                            @"Roads\Highway6L\Textures\ElevatedBridge\NodeLOD__APRMap.png",
                            @"Roads\Highway6L\Textures\ElevatedBridge\LOD__XYSMap.png"));
                    break;

                case NetInfoVersion.Slope:
                    info.SetAllSegmentsTexture(
                        new TexturesSet
                           (@"Roads\Highway6L\Textures\Slope\Segment__MainTex.png",
                            @"Roads\Highway6L\Textures\Slope\Segment__APRMap.png"),
                        new LODTexturesSet
                            (@"Roads\Highway6L\Textures\Slope\SegmentLOD__MainTex.png",
                            @"Roads\Highway6L\Textures\Slope\SegmentLOD__APRMap.png",
                            @"Roads\Highway6L\Textures\Slope\SegmentLOD__XYSMap.png"));
                    info.SetAllNodesTexture(
                        new TexturesSet
                           (@"Roads\Highway6L\Textures\Tunnel\Node__MainTex.png",
                            @"Roads\Highway6L\Textures\Ground\Node__APRMap.png"),
                        new LODTexturesSet
                           (@"Roads\Highway6L\Textures\Ground\NodeLOD__MainTex.png",
                            @"Roads\Highway6L\Textures\Ground\NodeLOD__APRMap.png",
                            @"Roads\Highway6L\Textures\Ground\NodeLOD__XYSMap.png"));
                    break;
                case NetInfoVersion.Tunnel:
                    info.SetAllSegmentsTexture(
                        new TexturesSet
                           (@"Roads\Highway6L\Textures\Tunnel\Segment__MainTex.png",
                            @"Roads\Highway6L\Textures\Tunnel\Segment__APRMap.png"),
                        new LODTexturesSet
                           (@"Roads\Highway6L\Textures\Tunnel\SegmentLOD__MainTex.png",
                            @"Roads\Highway6L\Textures\Tunnel\SegmentLOD__APRMap.png",
                            @"Roads\Highway6L\Textures\Tunnel\NodeLOD__XYSMap.png"));
                    info.SetAllNodesTexture(
                        new TexturesSet
                           (@"Roads\Highway6L\Textures\Tunnel\Node__MainTex.png",
                            @"Roads\Highway6L\Textures\Tunnel\Segment__APRMap.png"),
                        new LODTexturesSet
                           (@"Roads\Highway6L\Textures\Tunnel\NodeLOD__MainTex.png",
                            @"Roads\Highway6L\Textures\Tunnel\SegmentLOD__APRMap.png",
                            @"Roads\Highway6L\Textures\Tunnel\NodeLOD__XYSMap.png"));
                    break;
            }
        }
    }
}