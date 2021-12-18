// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vk_video/vulkan_video_codec_h264std.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2019-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum StdVideoH264NonVclNaluType
    {
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_SPS = 0,
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_PPS = 1,
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_AUD = 2,
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_PREFIX = 3,
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_END_OF_SEQUENCE = 4,
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_END_OF_STREAM = 5,
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_PRECODED = 6,
        STD_VIDEO_H264_NON_VCL_NALU_TYPE_INVALID = 0x7FFFFFFF,
    }
}
