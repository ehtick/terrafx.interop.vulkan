// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_android.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkAndroidHardwareBufferFormatProperties2ANDROID
    {
        public VkStructureType sType;

        public void* pNext;

        public VkFormat format;

        [NativeTypeName("uint64_t")]
        public ulong externalFormat;

        [NativeTypeName("VkFormatFeatureFlags2KHR")]
        public ulong formatFeatures;

        public VkComponentMapping samplerYcbcrConversionComponents;

        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;

        public VkSamplerYcbcrRange suggestedYcbcrRange;

        public VkChromaLocation suggestedXChromaOffset;

        public VkChromaLocation suggestedYChromaOffset;
    }
}
