//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMProcessingInstruction { WebKitDOMNode parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMProcessingInstruction
    {
        // DEBUG: WebKitDOMNode parent_instance
        [FieldOffset(0)]
        public _WebKitDOMNode parent_instance;
    }

    // DEBUG: struct _WebKitDOMProcessingInstructionClass { WebKitDOMNodeClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMProcessingInstructionClass
    {
        // DEBUG: WebKitDOMNodeClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMNodeClass parent_class;
    }

    public unsafe partial class WebKitDOMProcessingInstruction: GLib.Object
    {
        public WebKitDOMProcessingInstruction(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_processing_instruction_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_processing_instruction_get_type")]
        internal static extern uint webkit_dom_processing_instruction_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_processing_instruction_get_type());
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_processing_instruction_get_target(WebKitDOMProcessingInstruction* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_processing_instruction_get_target")]
        internal static extern sbyte* webkit_dom_processing_instruction_get_target(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_processing_instruction_get_data(WebKitDOMProcessingInstruction* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_processing_instruction_get_data")]
        internal static extern sbyte* webkit_dom_processing_instruction_get_data(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_processing_instruction_set_data(WebKitDOMProcessingInstruction* self, const gchar* value, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_processing_instruction_set_data")]
        internal static extern void webkit_dom_processing_instruction_set_data(global::System.IntPtr self, global::System.IntPtr value, global::System.IntPtr error);

        // DEBUG: WEBKIT_API WebKitDOMStyleSheet*webkit_dom_processing_instruction_get_sheet(WebKitDOMProcessingInstruction* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_processing_instruction_get_sheet")]
        internal static extern global::System.IntPtr webkit_dom_processing_instruction_get_sheet(global::System.IntPtr self);
    }
}
