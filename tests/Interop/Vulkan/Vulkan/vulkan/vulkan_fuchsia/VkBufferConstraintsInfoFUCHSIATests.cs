// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_fuchsia.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkBufferConstraintsInfoFUCHSIA" /> struct.</summary>
    public static unsafe partial class VkBufferConstraintsInfoFUCHSIATests
    {
        /// <summary>Validates that the <see cref="VkBufferConstraintsInfoFUCHSIA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkBufferConstraintsInfoFUCHSIA>(), Is.EqualTo(sizeof(VkBufferConstraintsInfoFUCHSIA)));
        }

        /// <summary>Validates that the <see cref="VkBufferConstraintsInfoFUCHSIA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(VkBufferConstraintsInfoFUCHSIA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="VkBufferConstraintsInfoFUCHSIA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(VkBufferConstraintsInfoFUCHSIA), Is.EqualTo(120));
            }
            else
            {
                Assert.That(sizeof(VkBufferConstraintsInfoFUCHSIA), Is.EqualTo(80));
            }
        }
    }
}
