﻿using System;
using System.Runtime.InteropServices;

namespace Dapplo.Dopy.Utils
{
    /// <summary>
    /// The SID_AND_ATTRIBUTES structure represents a security identifier (SID) and its attributes.
    /// SIDs are used to uniquely identify users or groups.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct SidAndAttributes
    {
        /// <summary>
        /// A pointer to a SID structure.
        /// </summary>
        public IntPtr Sid;
        /// <summary>
        /// Specifies attributes of the SID. This value contains up to 32 one-bit flags. Its meaning depends on the definition and use of the SID.
        /// </summary>
        public readonly uint Attributes;
    }
}
