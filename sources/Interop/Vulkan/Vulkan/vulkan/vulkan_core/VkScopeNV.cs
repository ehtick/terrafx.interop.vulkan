// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public enum VkScopeNV
{
    VK_SCOPE_DEVICE_NV = 1,
    VK_SCOPE_WORKGROUP_NV = 2,
    VK_SCOPE_SUBGROUP_NV = 3,
    VK_SCOPE_QUEUE_FAMILY_NV = 5,
    VK_SCOPE_MAX_ENUM_NV = 0x7FFFFFFF,
}
