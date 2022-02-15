// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
    {
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("VkDeviceSize")]
        public ulong storageTexelBufferOffsetAlignmentBytes;

        public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;

        [NativeTypeName("VkDeviceSize")]
        public ulong uniformTexelBufferOffsetAlignmentBytes;

        public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
    }
}
