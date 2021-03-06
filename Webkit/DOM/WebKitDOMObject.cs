using GLib;
//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: typedef struct _WebKitDOMObjectPrivate WebKitDOMObjectPrivate
    // DEBUG: struct _WebKitDOMObjectPrivate
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public unsafe struct _WebKitDOMObjectPrivate
    {
    }

    // DEBUG: struct _WebKitDOMObject { GObject parentInstance; gpointer coreObject;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMObject
    {
        // DEBUG: GObject parentInstance
        [FieldOffset(0)]
        public _GObject parentInstance;

        // DEBUG: gpointer coreObject
        [FieldOffset(12)]
        public void* coreObject;
    }

    // DEBUG: struct _WebKitDOMObjectClass { GObjectClass parentClass;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMObjectClass
    {
        // DEBUG: GObjectClass parentClass
        [FieldOffset(0)]
        public _GObjectClass parentClass;
    }

    public unsafe class WebKitDOMObject : GLib.Object
    {
        // DEBUG: WEBKIT_API GType webkit_dom_object_get_type(void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_object_get_type")]
        internal static extern uint webkit_dom_object_get_type();

        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_object_get_type());
            }
        }

        public WebKitDOMObject(IntPtr handle)
            :base(handle)
        {
        }
    }
}
