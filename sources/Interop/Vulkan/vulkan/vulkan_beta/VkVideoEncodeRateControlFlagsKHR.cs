// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum VkVideoEncodeRateControlFlagsKHR : uint
    {
        VK_VIDEO_ENCODE_RATE_CONTROL_DEFAULT_KHR = 0,
        VK_VIDEO_ENCODE_RATE_CONTROL_RESET_BIT_KHR = 0x00000001,
        VK_VIDEO_ENCODE_RATE_CONTROL_FLAG_BITS_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
