// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_beta.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

namespace TerraFX.Interop.Vulkan
{
    public unsafe partial struct VkDeviceManualImports
    {
        public delegate* unmanaged<VkDevice, VkVideoSessionCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionKHR*, VkResult> vkCreateVideoSessionKHR;

        public delegate* unmanaged<VkDevice, VkVideoSessionKHR, VkAllocationCallbacks*, void> vkDestroyVideoSessionKHR;

        public delegate* unmanaged<VkDevice, VkVideoSessionKHR, uint*, VkVideoGetMemoryPropertiesKHR*, VkResult> vkGetVideoSessionMemoryRequirementsKHR;

        public delegate* unmanaged<VkDevice, VkVideoSessionKHR, uint, VkVideoBindMemoryKHR*, VkResult> vkBindVideoSessionMemoryKHR;

        public delegate* unmanaged<VkDevice, VkVideoSessionParametersCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionParametersKHR*, VkResult> vkCreateVideoSessionParametersKHR;

        public delegate* unmanaged<VkDevice, VkVideoSessionParametersKHR, VkVideoSessionParametersUpdateInfoKHR*, VkResult> vkUpdateVideoSessionParametersKHR;

        public delegate* unmanaged<VkDevice, VkVideoSessionParametersKHR, VkAllocationCallbacks*, void> vkDestroyVideoSessionParametersKHR;
    }
}
