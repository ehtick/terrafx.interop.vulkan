// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_fuchsia.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkImportSemaphoreZirconHandleInfoFUCHSIA
{
    public VkStructureType sType;

    [NativeTypeName("const void *")]
    public void* pNext;

    public VkSemaphore semaphore;

    public VkSemaphoreImportFlags flags;

    [NativeTypeName("VkExternalSemaphoreHandleTypeFlagBits")]
    public VkExternalSemaphoreHandleTypeFlags handleType;

    [NativeTypeName("zx_handle_t")]
    public uint zirconHandle;
}
