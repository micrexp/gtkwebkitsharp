//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitDOMCSSRule { WebKitDOMObject parent_instance;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitDOMCSSRule
    {
        // DEBUG: WebKitDOMObject parent_instance
        [FieldOffset(0)]
        public _WebKitDOMObject parent_instance;
    }

    // DEBUG: struct _WebKitDOMCSSRuleClass { WebKitDOMObjectClass parent_class;}
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public unsafe struct _WebKitDOMCSSRuleClass
    {
        // DEBUG: WebKitDOMObjectClass parent_class
        [FieldOffset(0)]
        public _WebKitDOMObjectClass parent_class;
    }

    public unsafe partial class WebKitDOMCSSRule: GLib.Object
    {
        public WebKitDOMCSSRule(IntPtr handle) : base(handle) { }
        // DEBUG: WEBKIT_API GTypewebkit_dom_css_rule_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_css_rule_get_type")]
        internal static extern uint webkit_dom_css_rule_get_type();

        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_dom_css_rule_get_type());
            }
        }

        // DEBUG: WEBKIT_API gchar*webkit_dom_css_rule_get_css_text(WebKitDOMCSSRule* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_css_rule_get_css_text")]
        internal static extern sbyte* webkit_dom_css_rule_get_css_text(global::System.IntPtr self);

        // DEBUG: WEBKIT_API voidwebkit_dom_css_rule_set_css_text(WebKitDOMCSSRule* self, const gchar* value, GError **error)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_css_rule_set_css_text")]
        internal static extern void webkit_dom_css_rule_set_css_text(global::System.IntPtr self, global::System.IntPtr value, global::System.IntPtr error);

        // DEBUG: WEBKIT_API WebKitDOMCSSStyleSheet*webkit_dom_css_rule_get_parent_style_sheet(WebKitDOMCSSRule* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_css_rule_get_parent_style_sheet")]
        internal static extern global::System.IntPtr webkit_dom_css_rule_get_parent_style_sheet(global::System.IntPtr self);

        // DEBUG: WEBKIT_API WebKitDOMCSSRule*webkit_dom_css_rule_get_parent_rule(WebKitDOMCSSRule* self)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_dom_css_rule_get_parent_rule")]
        internal static extern global::System.IntPtr webkit_dom_css_rule_get_parent_rule(global::System.IntPtr self);
    }
}
