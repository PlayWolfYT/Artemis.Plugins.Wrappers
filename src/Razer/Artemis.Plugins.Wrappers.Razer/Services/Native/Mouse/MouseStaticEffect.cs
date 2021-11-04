﻿using SkiaSharp;
using System.Runtime.InteropServices;

namespace Artemis.Plugins.Wrappers.Razer.Services
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal unsafe struct MouseStaticEffect
    {
        private readonly uint _ledId;
        private readonly uint _color;

        public SKColor Color => SKColorExtensions.FromRazerUint(_color);
    }
}