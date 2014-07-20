//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Webbed.Scripting.Interop
{
    // DEBUG: typedef struct _WebKitWebBackForwardListPrivate WebKitWebBackForwardListPrivate
    // DEBUG: struct _WebKitWebBackForwardListPrivate
    [StructLayout(LayoutKind.Explicit, Size = 0)]
    public unsafe struct _WebKitWebBackForwardListPrivate
    {
    }

    // DEBUG: struct _WebKitWebBackForwardList { GObject parent_instance; /*< private >*/ WebKitWebBackForwardListPrivate *priv;}
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public unsafe struct _WebKitWebBackForwardList
    {
        // DEBUG: GObject parent_instance
        [FieldOffset(0)]
        public _GObject parent_instance;

        // DEBUG: WebKitWebBackForwardListPrivate *priv
        [FieldOffset(12)]
        public global::System.IntPtr priv;
    }

    // DEBUG: struct _WebKitWebBackForwardListClass { GObjectClass parent_class; /* Padding for future expansion */ void (*_webkit_reserved0) (void); void (*_webkit_reserved1) (void); void (*_webkit_reserved2) (void); void (*_webkit_reserved3) (void);}
    [StructLayout(LayoutKind.Explicit, Size = 84)]
    public unsafe struct _WebKitWebBackForwardListClass
    {
        // DEBUG: GObjectClass parent_class
        [FieldOffset(0)]
        public _GObjectClass parent_class;
    }

    public unsafe partial class WebKitWebBackForwardList : GLib.Object
    {
        public WebKitWebBackForwardList(IntPtr handle):base(handle){}
        // DEBUG: WEBKIT_API GTypewebkit_web_back_forward_list_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_get_type")]
        internal static extern uint webkit_web_back_forward_list_get_type();

        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_web_back_forward_list_get_type());
            }
        }

        // DEBUG: WEBKIT_API WebKitWebBackForwardList *webkit_web_back_forward_list_new_with_web_view (WebKitWebView *web_view)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_new_with_web_view")]
        internal static extern global::System.IntPtr webkit_web_back_forward_list_new_with_web_view(global::System.IntPtr web_view);

        public WebKitWebBackForwardList(WebKitWebView web_view) : base(webkit_web_back_forward_list_new_with_web_view(web_view.Handle)) { }

        // DEBUG: WEBKIT_API voidwebkit_web_back_forward_list_go_forward (WebKitWebBackForwardList *web_back_forward_list)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_go_forward")]
        internal static extern void webkit_web_back_forward_list_go_forward(global::System.IntPtr web_back_forward_list);

        public void GoForward()
        {
            webkit_web_back_forward_list_go_forward(this.Handle);
        }

        // DEBUG: WEBKIT_API voidwebkit_web_back_forward_list_go_back (WebKitWebBackForwardList *web_back_forward_list)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_go_back")]
        internal static extern void webkit_web_back_forward_list_go_back(global::System.IntPtr web_back_forward_list);

        public void GoBack()
        {
            webkit_web_back_forward_list_go_back(this.Handle);
        }

        // DEBUG: WEBKIT_API gbooleanwebkit_web_back_forward_list_contains_item (WebKitWebBackForwardList *web_back_forward_list, WebKitWebHistoryItem *history_item)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_contains_item")]
        internal static extern bool webkit_web_back_forward_list_contains_item(global::System.IntPtr web_back_forward_list, global::System.IntPtr history_item);

        public bool ContainsItem(WebKitWebHistoryItem history_item)
        {
            return webkit_web_back_forward_list_contains_item(this.Handle, history_item.Handle);
        }

        // DEBUG: WEBKIT_API voidwebkit_web_back_forward_list_go_to_item (WebKitWebBackForwardList *web_back_forward_list, WebKitWebHistoryItem *history_item)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_go_to_item")]
        internal static extern void webkit_web_back_forward_list_go_to_item(global::System.IntPtr web_back_forward_list, global::System.IntPtr history_item);

        public void GoToItem(WebKitWebHistoryItem history_item)
        {
            webkit_web_back_forward_list_go_to_item(this.Handle, history_item.Handle);
        }

        // DEBUG: WEBKIT_API GList *webkit_web_back_forward_list_get_forward_list_with_limit (WebKitWebBackForwardList *web_back_forward_list, gint limit)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_get_forward_list_with_limit")]
        internal static extern global::System.IntPtr webkit_web_back_forward_list_get_forward_list_with_limit(global::System.IntPtr web_back_forward_list, int limit);

        public GLib.List GetForwardListWithLimit(int limit)
        {
            return new GLib.List(webkit_web_back_forward_list_get_forward_list_with_limit(this.Handle,limit));
        }

        // DEBUG: WEBKIT_API GList *webkit_web_back_forward_list_get_back_list_with_limit (WebKitWebBackForwardList *web_back_forward_list, gint limit)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_get_back_list_with_limit")]
        internal static extern global::System.IntPtr webkit_web_back_forward_list_get_back_list_with_limit(global::System.IntPtr web_back_forward_list, int limit);

        public GLib.List GetBackListWithLimit(int limit)
        {
            return new GLib.List(webkit_web_back_forward_list_get_back_list_with_limit(this.Handle, limit));
        }

        // DEBUG: WEBKIT_API WebKitWebHistoryItem *webkit_web_back_forward_list_get_back_item (WebKitWebBackForwardList *web_back_forward_list)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_get_back_item")]
        internal static extern global::System.IntPtr webkit_web_back_forward_list_get_back_item(global::System.IntPtr web_back_forward_list);

        public WebKitWebHistoryItem GetBackItem()
        {
            return new WebKitWebHistoryItem(webkit_web_back_forward_list_get_back_item(this.Handle));
        }

        // DEBUG: WEBKIT_API WebKitWebHistoryItem *webkit_web_back_forward_list_get_current_item (WebKitWebBackForwardList *web_back_forward_list)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_get_current_item")]
        internal static extern global::System.IntPtr webkit_web_back_forward_list_get_current_item(global::System.IntPtr web_back_forward_list);

        public WebKitWebHistoryItem GetCurrentItem()
        {
            return new WebKitWebHistoryItem(webkit_web_back_forward_list_get_current_item(this.Handle));
        }

        // DEBUG: WEBKIT_API WebKitWebHistoryItem *webkit_web_back_forward_list_get_forward_item (WebKitWebBackForwardList *web_back_forward_list)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_get_forward_item")]
        internal static extern global::System.IntPtr webkit_web_back_forward_list_get_forward_item(global::System.IntPtr web_back_forward_list);

        public WebKitWebHistoryItem GetForwardItem()
        {
            return new WebKitWebHistoryItem(webkit_web_back_forward_list_get_forward_item(this.Handle));
        }

        // DEBUG: WEBKIT_API WebKitWebHistoryItem *webkit_web_back_forward_list_get_nth_item (WebKitWebBackForwardList *web_back_forward_list, gint index)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_get_nth_item")]
        internal static extern global::System.IntPtr webkit_web_back_forward_list_get_nth_item(global::System.IntPtr web_back_forward_list, int index);

        public WebKitWebHistoryItem GetNthItem(int index)
        {
            return new WebKitWebHistoryItem(webkit_web_back_forward_list_get_nth_item(this.Handle,index));
        }

        // DEBUG: WEBKIT_API gintwebkit_web_back_forward_list_get_back_length (WebKitWebBackForwardList *web_back_forward_list)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_get_back_length")]
        internal static extern int webkit_web_back_forward_list_get_back_length(global::System.IntPtr web_back_forward_list);
        
        public WebKitWebHistoryItem GetBackLength(int index)
        {
            return new WebKitWebHistoryItem(webkit_web_back_forward_list_get_back_length(this.Handle));
        }

        // DEBUG: WEBKIT_API gintwebkit_web_back_forward_list_get_forward_length (WebKitWebBackForwardList *web_back_forward_list)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_get_forward_length")]
        internal static extern int webkit_web_back_forward_list_get_forward_length(global::System.IntPtr web_back_forward_list);

        public WebKitWebHistoryItem GetForwardLength(int index)
        {
            return new WebKitWebHistoryItem(webkit_web_back_forward_list_get_forward_length(this.Handle));
        }

        // DEBUG: WEBKIT_API gintwebkit_web_back_forward_list_get_limit (WebKitWebBackForwardList *web_back_forward_list)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_get_limit")]
        internal static extern int webkit_web_back_forward_list_get_limit(global::System.IntPtr web_back_forward_list);

        public int Limit
        {
            get
            {
                return webkit_web_back_forward_list_get_limit(this.Handle);
            }
            set
            {
                webkit_web_back_forward_list_set_limit(this.Handle, value);
            }
        }

        // DEBUG: WEBKIT_API voidwebkit_web_back_forward_list_set_limit (WebKitWebBackForwardList *web_back_forward_list, gint limit)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_set_limit")]
        internal static extern void webkit_web_back_forward_list_set_limit(global::System.IntPtr web_back_forward_list, int limit);

        // DEBUG: WEBKIT_API voidwebkit_web_back_forward_list_add_item (WebKitWebBackForwardList *web_back_forward_list, WebKitWebHistoryItem *history_item)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_add_item")]
        internal static extern void webkit_web_back_forward_list_add_item(global::System.IntPtr web_back_forward_list, global::System.IntPtr history_item);

        public void AddItem(WebKitWebHistoryItem history_item)
        {
            webkit_web_back_forward_list_add_item(this.Handle, history_item.Handle);
        }

        // DEBUG: WEBKIT_API voidwebkit_web_back_forward_list_clear (WebKitWebBackForwardList *web_back_forward_list)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_web_back_forward_list_clear")]
        internal static extern void webkit_web_back_forward_list_clear(global::System.IntPtr web_back_forward_list);

        public void Clear()
        {
            webkit_web_back_forward_list_clear(this.Handle);
        }
    }
}
