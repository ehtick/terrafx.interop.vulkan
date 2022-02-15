// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum VkFragmentShadingRateCombinerOpKHR
    {
        VK_FRAGMENT_SHADING_RATE_COMBINER_OP_KEEP_KHR = 0,
        VK_FRAGMENT_SHADING_RATE_COMBINER_OP_REPLACE_KHR = 1,
        VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MIN_KHR = 2,
        VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_KHR = 3,
        VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MUL_KHR = 4,
        VK_FRAGMENT_SHADING_RATE_COMBINER_OP_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
