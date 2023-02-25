// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.239
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

using System;

namespace TerraFX.Interop.Vulkan;

[Flags]
public enum VkPipelineStageFlags2 : ulong
{
    VK_PIPELINE_STAGE_2_NONE = 0UL,
    VK_PIPELINE_STAGE_2_NONE_KHR = 0UL,
    VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT = 0x00000001UL,
    VK_PIPELINE_STAGE_2_TOP_OF_PIPE_BIT_KHR = 0x00000001UL,
    VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT = 0x00000002UL,
    VK_PIPELINE_STAGE_2_DRAW_INDIRECT_BIT_KHR = 0x00000002UL,
    VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT = 0x00000004UL,
    VK_PIPELINE_STAGE_2_VERTEX_INPUT_BIT_KHR = 0x00000004UL,
    VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT = 0x00000008UL,
    VK_PIPELINE_STAGE_2_VERTEX_SHADER_BIT_KHR = 0x00000008UL,
    VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT = 0x00000010UL,
    VK_PIPELINE_STAGE_2_TESSELLATION_CONTROL_SHADER_BIT_KHR = 0x00000010UL,
    VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT = 0x00000020UL,
    VK_PIPELINE_STAGE_2_TESSELLATION_EVALUATION_SHADER_BIT_KHR = 0x00000020UL,
    VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT = 0x00000040UL,
    VK_PIPELINE_STAGE_2_GEOMETRY_SHADER_BIT_KHR = 0x00000040UL,
    VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT = 0x00000080UL,
    VK_PIPELINE_STAGE_2_FRAGMENT_SHADER_BIT_KHR = 0x00000080UL,
    VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT = 0x00000100UL,
    VK_PIPELINE_STAGE_2_EARLY_FRAGMENT_TESTS_BIT_KHR = 0x00000100UL,
    VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT = 0x00000200UL,
    VK_PIPELINE_STAGE_2_LATE_FRAGMENT_TESTS_BIT_KHR = 0x00000200UL,
    VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT = 0x00000400UL,
    VK_PIPELINE_STAGE_2_COLOR_ATTACHMENT_OUTPUT_BIT_KHR = 0x00000400UL,
    VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT = 0x00000800UL,
    VK_PIPELINE_STAGE_2_COMPUTE_SHADER_BIT_KHR = 0x00000800UL,
    VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT = 0x00001000UL,
    VK_PIPELINE_STAGE_2_ALL_TRANSFER_BIT_KHR = 0x00001000UL,
    VK_PIPELINE_STAGE_2_TRANSFER_BIT = 0x00001000UL,
    VK_PIPELINE_STAGE_2_TRANSFER_BIT_KHR = 0x00001000UL,
    VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT = 0x00002000UL,
    VK_PIPELINE_STAGE_2_BOTTOM_OF_PIPE_BIT_KHR = 0x00002000UL,
    VK_PIPELINE_STAGE_2_HOST_BIT = 0x00004000UL,
    VK_PIPELINE_STAGE_2_HOST_BIT_KHR = 0x00004000UL,
    VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT = 0x00008000UL,
    VK_PIPELINE_STAGE_2_ALL_GRAPHICS_BIT_KHR = 0x00008000UL,
    VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT = 0x00010000UL,
    VK_PIPELINE_STAGE_2_ALL_COMMANDS_BIT_KHR = 0x00010000UL,
    VK_PIPELINE_STAGE_2_COPY_BIT = 0x100000000UL,
    VK_PIPELINE_STAGE_2_COPY_BIT_KHR = 0x100000000UL,
    VK_PIPELINE_STAGE_2_RESOLVE_BIT = 0x200000000UL,
    VK_PIPELINE_STAGE_2_RESOLVE_BIT_KHR = 0x200000000UL,
    VK_PIPELINE_STAGE_2_BLIT_BIT = 0x400000000UL,
    VK_PIPELINE_STAGE_2_BLIT_BIT_KHR = 0x400000000UL,
    VK_PIPELINE_STAGE_2_CLEAR_BIT = 0x800000000UL,
    VK_PIPELINE_STAGE_2_CLEAR_BIT_KHR = 0x800000000UL,
    VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT = 0x1000000000UL,
    VK_PIPELINE_STAGE_2_INDEX_INPUT_BIT_KHR = 0x1000000000UL,
    VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT = 0x2000000000UL,
    VK_PIPELINE_STAGE_2_VERTEX_ATTRIBUTE_INPUT_BIT_KHR = 0x2000000000UL,
    VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT = 0x4000000000UL,
    VK_PIPELINE_STAGE_2_PRE_RASTERIZATION_SHADERS_BIT_KHR = 0x4000000000UL,
    VK_PIPELINE_STAGE_2_VIDEO_DECODE_BIT_KHR = 0x04000000UL,
    VK_PIPELINE_STAGE_2_VIDEO_ENCODE_BIT_KHR = 0x08000000UL,
    VK_PIPELINE_STAGE_2_TRANSFORM_FEEDBACK_BIT_EXT = 0x01000000UL,
    VK_PIPELINE_STAGE_2_CONDITIONAL_RENDERING_BIT_EXT = 0x00040000UL,
    VK_PIPELINE_STAGE_2_COMMAND_PREPROCESS_BIT_NV = 0x00020000UL,
    VK_PIPELINE_STAGE_2_FRAGMENT_SHADING_RATE_ATTACHMENT_BIT_KHR = 0x00400000UL,
    VK_PIPELINE_STAGE_2_SHADING_RATE_IMAGE_BIT_NV = 0x00400000UL,
    VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_KHR = 0x02000000UL,
    VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_KHR = 0x00200000UL,
    VK_PIPELINE_STAGE_2_RAY_TRACING_SHADER_BIT_NV = 0x00200000UL,
    VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_BUILD_BIT_NV = 0x02000000UL,
    VK_PIPELINE_STAGE_2_FRAGMENT_DENSITY_PROCESS_BIT_EXT = 0x00800000UL,
    VK_PIPELINE_STAGE_2_TASK_SHADER_BIT_NV = 0x00080000UL,
    VK_PIPELINE_STAGE_2_MESH_SHADER_BIT_NV = 0x00100000UL,
    VK_PIPELINE_STAGE_2_SUBPASS_SHADING_BIT_HUAWEI = 0x8000000000UL,
    VK_PIPELINE_STAGE_2_INVOCATION_MASK_BIT_HUAWEI = 0x10000000000UL,
    VK_PIPELINE_STAGE_2_ACCELERATION_STRUCTURE_COPY_BIT_KHR = 0x10000000UL,
}
