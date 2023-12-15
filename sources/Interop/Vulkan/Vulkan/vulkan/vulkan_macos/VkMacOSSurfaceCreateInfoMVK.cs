// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_macos.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkMacOSSurfaceCreateInfoMVK
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkMacOSSurfaceCreateFlagsMVK flags;

    [NativeTypeName("const void *")]
    public void* pView;
}
