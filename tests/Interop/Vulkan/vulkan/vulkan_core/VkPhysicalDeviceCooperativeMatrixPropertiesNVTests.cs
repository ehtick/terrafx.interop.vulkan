// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkPhysicalDeviceCooperativeMatrixPropertiesNV" /> struct.</summary>
    public static unsafe class VkPhysicalDeviceCooperativeMatrixPropertiesNVTests
    {
        /// <summary>Validates that the <see cref="VkPhysicalDeviceCooperativeMatrixPropertiesNV" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkPhysicalDeviceCooperativeMatrixPropertiesNV>(), Is.EqualTo(sizeof(VkPhysicalDeviceCooperativeMatrixPropertiesNV)));
        }

        /// <summary>Validates that the <see cref="VkPhysicalDeviceCooperativeMatrixPropertiesNV" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkPhysicalDeviceCooperativeMatrixPropertiesNV).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkPhysicalDeviceCooperativeMatrixPropertiesNV" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkPhysicalDeviceCooperativeMatrixPropertiesNV), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(VkPhysicalDeviceCooperativeMatrixPropertiesNV), Is.EqualTo(12));
            }
        }
    }
}
