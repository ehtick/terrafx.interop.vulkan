// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop
{
    public unsafe partial struct VkPerformanceOverrideInfoINTEL
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        public VkPerformanceOverrideTypeINTEL type;

        [NativeTypeName("VkBool32")]
        public uint enable;

        [NativeTypeName("uint64_t")]
        public ulong parameter;
    }
}
