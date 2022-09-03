// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.224
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public partial struct VkDrawIndexedIndirectCommand
{
    [NativeTypeName("uint32_t")]
    public uint indexCount;

    [NativeTypeName("uint32_t")]
    public uint instanceCount;

    [NativeTypeName("uint32_t")]
    public uint firstIndex;

    [NativeTypeName("int32_t")]
    public int vertexOffset;

    [NativeTypeName("uint32_t")]
    public uint firstInstance;
}
