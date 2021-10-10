// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_win32.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2021 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct VkExportMemoryWin32HandleInfoKHR
    {
        public VkStructureType sType;

        [NativeTypeName("const void *")]
        public void* pNext;

        [NativeTypeName("const SECURITY_ATTRIBUTES *")]
        public IntPtr pAttributes;

        [NativeTypeName("DWORD")]
        public uint dwAccess;

        [NativeTypeName("LPCWSTR")]
        public ushort* name;
    }
}
