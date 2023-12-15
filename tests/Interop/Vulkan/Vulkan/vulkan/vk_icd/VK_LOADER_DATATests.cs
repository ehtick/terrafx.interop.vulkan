// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vk_icd.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2016 The Khronos Group Inc. Copyright © 2015-2016 Valve Corporation. Copyright © 2015-2016 LunarG, Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Vulkan.UnitTests;

/// <summary>Provides validation of the <see cref="VK_LOADER_DATA" /> struct.</summary>
public static unsafe partial class VK_LOADER_DATATests
{
    /// <summary>Validates that the <see cref="VK_LOADER_DATA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<VK_LOADER_DATA>(), Is.EqualTo(sizeof(VK_LOADER_DATA)));
    }

    /// <summary>Validates that the <see cref="VK_LOADER_DATA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(VK_LOADER_DATA).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref="VK_LOADER_DATA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(VK_LOADER_DATA), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(VK_LOADER_DATA), Is.EqualTo(4));
        }
    }
}
