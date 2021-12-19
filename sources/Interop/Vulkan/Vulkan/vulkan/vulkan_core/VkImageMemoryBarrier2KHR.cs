// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkImageMemoryBarrier2KHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("VkPipelineStageFlags2KHR")]
        public ulong srcStageMask;

        [NativeTypeName("VkAccessFlags2KHR")]
        public ulong srcAccessMask;

        [NativeTypeName("VkPipelineStageFlags2KHR")]
        public ulong dstStageMask;

        [NativeTypeName("VkAccessFlags2KHR")]
        public ulong dstAccessMask;

        public VkImageLayout oldLayout;

        public VkImageLayout newLayout;

        [NativeTypeName("uint32_t")]
        public uint srcQueueFamilyIndex;

        [NativeTypeName("uint32_t")]
        public uint dstQueueFamilyIndex;

        public VkImage image;

        public VkImageSubresourceRange subresourceRange;
    }
}
