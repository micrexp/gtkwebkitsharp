//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMHTMLKeygenElement { WebKitDOMHTMLElement parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMHTMLKeygenElement
    {
        // DEBUG: WebKitDOMHTMLElement parent_instance
        [FieldOffset(0)]
        public _WebKitDOMHTMLElement parent_instance;
    }

    // DEBUG: struct _WebKitDOMHTMLKeygenElementClass { WebKitDOMHTMLElementClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMHTMLKeygenElementClass
    {
        // DEBUG: WebKitDOMHTMLElementClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMHTMLElementClass parent_class;
    }

    public unsafe partial class WebKitDOMHTMLKeygenElement: GLib.Object
    {
        public WebKitDOMHTMLKeygenElement(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_html_keygen_element_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_get_type")]
        internal static extern uint webkit_dom_html_keygen_element_get_type();
        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_html_keygen_element_get_type());
            }
        }

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_keygen_element_check_validity(WebKitDOMHTMLKeygenElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_check_validity")]
        internal static extern int webkit_dom_html_keygen_element_check_validity(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_keygen_element_set_custom_validity(WebKitDOMHTMLKeygenElement* self, const gchar* error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_set_custom_validity")]
        internal static extern void webkit_dom_html_keygen_element_set_custom_validity(global::System.IntPtr self, global::System.IntPtr error);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_keygen_element_get_autofocus(WebKitDOMHTMLKeygenElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_get_autofocus")]
        internal static extern int webkit_dom_html_keygen_element_get_autofocus(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_keygen_element_set_autofocus(WebKitDOMHTMLKeygenElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_set_autofocus")]
        internal static extern void webkit_dom_html_keygen_element_set_autofocus(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_keygen_element_get_challenge(WebKitDOMHTMLKeygenElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_get_challenge")]
        internal static extern sbyte* webkit_dom_html_keygen_element_get_challenge(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_keygen_element_set_challenge(WebKitDOMHTMLKeygenElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_set_challenge")]
        internal static extern void webkit_dom_html_keygen_element_set_challenge(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_keygen_element_get_disabled(WebKitDOMHTMLKeygenElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_get_disabled")]
        internal static extern int webkit_dom_html_keygen_element_get_disabled(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_keygen_element_set_disabled(WebKitDOMHTMLKeygenElement* self, gboolean value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_set_disabled")]
        internal static extern void webkit_dom_html_keygen_element_set_disabled(global::System.IntPtr self, int value);

        // DEBUG: WEBKIT_API WebKitDOMHTMLFormElement*webkit_dom_html_keygen_element_get_form(WebKitDOMHTMLKeygenElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_get_form")]
        internal static extern global::System.IntPtr webkit_dom_html_keygen_element_get_form(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_keygen_element_get_keytype(WebKitDOMHTMLKeygenElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_get_keytype")]
        internal static extern sbyte* webkit_dom_html_keygen_element_get_keytype(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_keygen_element_set_keytype(WebKitDOMHTMLKeygenElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_set_keytype")]
        internal static extern void webkit_dom_html_keygen_element_set_keytype(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_keygen_element_get_name(WebKitDOMHTMLKeygenElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_get_name")]
        internal static extern sbyte* webkit_dom_html_keygen_element_get_name(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_html_keygen_element_set_name(WebKitDOMHTMLKeygenElement* self, const gchar* value)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_set_name")]
        internal static extern void webkit_dom_html_keygen_element_set_name(global::System.IntPtr self, global::System.IntPtr value);

        // DEBUG: WEBKIT_API gbooleanwebkit_dom_html_keygen_element_get_will_validate(WebKitDOMHTMLKeygenElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_get_will_validate")]
        internal static extern int webkit_dom_html_keygen_element_get_will_validate(global::System.IntPtr self);

        // DEBUG: WEBKIT_API WebKitDOMValidityState*webkit_dom_html_keygen_element_get_validity(WebKitDOMHTMLKeygenElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_get_validity")]
        internal static extern global::System.IntPtr webkit_dom_html_keygen_element_get_validity(global::System.IntPtr self);

        // DEBUG: WEBKIT_API gchar*webkit_dom_html_keygen_element_get_validation_message(WebKitDOMHTMLKeygenElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_get_validation_message")]
        internal static extern sbyte* webkit_dom_html_keygen_element_get_validation_message(global::System.IntPtr self);

        // DEBUG: WEBKIT_API WebKitDOMNodeList*webkit_dom_html_keygen_element_get_labels(WebKitDOMHTMLKeygenElement* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_html_keygen_element_get_labels")]
        internal static extern global::System.IntPtr webkit_dom_html_keygen_element_get_labels(global::System.IntPtr self);
    }
}