// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_fuchsia.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref="VkMemoryZirconHandlePropertiesFUCHSIA" /> struct.</summary>
public static unsafe partial class VkMemoryZirconHandlePropertiesFUCHSIATests
{
    /// <summary>Validates that the <see cref="VkMemoryZirconHandlePropertiesFUCHSIA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VkMemoryZirconHandlePropertiesFUCHSIA>(), Is.EqualTo(sizeof(VkMemoryZirconHandlePropertiesFUCHSIA)));
    }

    /// <summary>Validates that the <see cref="VkMemoryZirconHandlePropertiesFUCHSIA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(VkMemoryZirconHandlePropertiesFUCHSIA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="VkMemoryZirconHandlePropertiesFUCHSIA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(VkMemoryZirconHandlePropertiesFUCHSIA), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(VkMemoryZirconHandlePropertiesFUCHSIA), Is.EqualTo(12));
        }
    }
}
