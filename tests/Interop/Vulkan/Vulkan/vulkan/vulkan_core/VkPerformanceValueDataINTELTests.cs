// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.198
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests
{
    /// <summary>Provides validation of the <see cref="VkPerformanceValueDataINTEL" /> struct.</summary>
    public static unsafe partial class VkPerformanceValueDataINTELTests
    {
        /// <summary>Validates that the <see cref="VkPerformanceValueDataINTEL" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<VkPerformanceValueDataINTEL>(), Is.EqualTo(sizeof(VkPerformanceValueDataINTEL)));
        }

        /// <summary>Validates that the <see cref="VkPerformanceValueDataINTEL" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(VkPerformanceValueDataINTEL).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="VkPerformanceValueDataINTEL" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(VkPerformanceValueDataINTEL), Is.EqualTo(8));
        }
    }
}
