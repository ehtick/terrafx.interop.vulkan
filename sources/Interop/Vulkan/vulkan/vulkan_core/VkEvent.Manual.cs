// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.2.189
// Original source is Copyright © 2015-2020 The Khronos Group Inc.

using System;

namespace TerraFX.Interop
{
    public struct VkEvent : IEquatable<VkEvent>
    {
        private ulong _value;

        public VkEvent(ulong value)
        {
            _value = value;
        }

        public static bool operator ==(VkEvent l, VkEvent r) => l._value == r._value;

        public static bool operator !=(VkEvent l, VkEvent r) => !(l == r);

        public static implicit operator VkEvent(ulong value) => new VkEvent(value);

        public static implicit operator ulong(VkEvent value) => value._value;

        public override bool Equals(object? obj) => (obj is VkEvent other) && Equals(other);

        public bool Equals(VkEvent other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
