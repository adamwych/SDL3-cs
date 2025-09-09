// Copyright (c) Bottlenose Labs Inc. (https://github.com/bottlenoselabs). All rights reserved.
// Licensed under the MIT license. See LICENSE file in the Git repository root directory for full license information.

namespace bottlenoselabs.SDL;

/// <summary>
///     Represents a GPU resource that holds data in video memory.
/// </summary>
[PublicAPI]
public sealed unsafe class GpuDataBuffer : GpuResource<SDL_GPUBuffer>
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="GpuDataBuffer"/> class.
    /// </summary>
    /// <param name="device">The device.</param>
    /// <param name="handle">The handle.</param>
    public GpuDataBuffer(GpuDevice device, SDL_GPUBuffer* handle)
        : base(device, handle)
    {
    }

    /// <inheritdoc />
    protected override void Dispose(bool isDisposing)
    {
        SDL_ReleaseGPUBuffer(Device.HandleTyped, HandleTyped);
        base.Dispose(isDisposing);
    }
}
