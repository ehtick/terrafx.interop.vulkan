// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop.Vulkan
{
    [NativeTypeName("int")]
    [Flags]
    public enum VkCommandPoolCreateFlags : uint
    {
        VK_COMMAND_POOL_CREATE_TRANSIENT_BIT = 0x00000001,
        VK_COMMAND_POOL_CREATE_RESET_COMMAND_BUFFER_BIT = 0x00000002,
        VK_COMMAND_POOL_CREATE_PROTECTED_BIT = 0x00000004,
        VK_COMMAND_POOL_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}
