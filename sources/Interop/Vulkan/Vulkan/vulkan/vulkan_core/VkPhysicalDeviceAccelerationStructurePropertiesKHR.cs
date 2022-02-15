// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.204
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
    {
        public VkStructureType sType;

        public void* pNext;

        [NativeTypeName("uint64_t")]
        public ulong maxGeometryCount;

        [NativeTypeName("uint64_t")]
        public ulong maxInstanceCount;

        [NativeTypeName("uint64_t")]
        public ulong maxPrimitiveCount;

        [NativeTypeName("uint32_t")]
        public uint maxPerStageDescriptorAccelerationStructures;

        [NativeTypeName("uint32_t")]
        public uint maxPerStageDescriptorUpdateAfterBindAccelerationStructures;

        [NativeTypeName("uint32_t")]
        public uint maxDescriptorSetAccelerationStructures;

        [NativeTypeName("uint32_t")]
        public uint maxDescriptorSetUpdateAfterBindAccelerationStructures;

        [NativeTypeName("uint32_t")]
        public uint minAccelerationStructureScratchOffsetAlignment;
    }
}
