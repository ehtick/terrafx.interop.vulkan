// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public partial struct VkShaderResourceUsageAMD
    {
        [NativeTypeName("uint32_t")]
        public uint numUsedVgprs;

        [NativeTypeName("uint32_t")]
        public uint numUsedSgprs;

        [NativeTypeName("uint32_t")]
        public uint ldsSizePerLocalWorkGroup;

        [NativeTypeName("size_t")]
        public nuint ldsUsageSizeInBytes;

        [NativeTypeName("size_t")]
        public nuint scratchMemUsageInBytes;
    }
}
