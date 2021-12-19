// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public enum VkPerformanceCounterScopeKHR
    {
        VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_BUFFER_KHR = 0,
        VK_PERFORMANCE_COUNTER_SCOPE_RENDER_PASS_KHR = 1,
        VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_KHR = 2,
        VK_QUERY_SCOPE_COMMAND_BUFFER_KHR = VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_BUFFER_KHR,
        VK_QUERY_SCOPE_RENDER_PASS_KHR = VK_PERFORMANCE_COUNTER_SCOPE_RENDER_PASS_KHR,
        VK_QUERY_SCOPE_COMMAND_KHR = VK_PERFORMANCE_COUNTER_SCOPE_COMMAND_KHR,
        VK_PERFORMANCE_COUNTER_SCOPE_MAX_ENUM_KHR = 0x7FFFFFFF,
    }
}
