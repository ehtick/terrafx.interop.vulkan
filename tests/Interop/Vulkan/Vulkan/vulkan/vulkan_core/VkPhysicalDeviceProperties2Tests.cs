// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref="VkPhysicalDeviceProperties2" /> struct.</summary>
public static unsafe partial class VkPhysicalDeviceProperties2Tests
{
    /// <summary>Validates that the <see cref="VkPhysicalDeviceProperties2" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VkPhysicalDeviceProperties2>(), Is.EqualTo(sizeof(VkPhysicalDeviceProperties2)));
    }

    /// <summary>Validates that the <see cref="VkPhysicalDeviceProperties2" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VkPhysicalDeviceProperties2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="VkPhysicalDeviceProperties2" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(VkPhysicalDeviceProperties2), Is.EqualTo(840));
        }
        else
        {
            Assert.That(sizeof(VkPhysicalDeviceProperties2), Is.EqualTo(824));
        }
    }
}
