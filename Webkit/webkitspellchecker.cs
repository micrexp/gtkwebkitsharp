//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Webbed.Scripting.Interop
{
    // DEBUG: struct _WebKitSpellCheckerInterface { GTypeInterface g_iface; void (*check_spelling_of_string) (WebKitSpellChecker* checker, const char* word, int* misspelling_location, int* misspelling_length); char** (*get_guesses_for_word) (WebKitSpellChecker* checker, const char* word, const char* context); void (*update_spell_checking_languages) (WebKitSpellChecker* checker, const char* languages); char* (*get_autocorrect_suggestions_for_misspelled_word) (WebKitSpellChecker* checker, const char* word); void (*learn_word) (WebKitSpellChecker* checker, const char* word); void (*ignore_word) (WebKitSpellChecker* checker, const char* word);}
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe struct _WebKitSpellCheckerInterface
    {
        // DEBUG: GTypeInterface g_iface
        [FieldOffset(0)]
        public _GTypeInterface g_iface;

        // DEBUG: void (*check_spelling_of_string) (WebKitSpellChecker* checker, const char* word, int* misspelling_location, int* misspelling_length)
        [FieldOffset(8)]
        public global::System.IntPtr check_spelling_of_string;

        // DEBUG: char** (*get_guesses_for_word) (WebKitSpellChecker* checker, const char* word, const char* context)
        [FieldOffset(12)]
        public global::System.IntPtr get_guesses_for_word;

        // DEBUG: void (*update_spell_checking_languages) (WebKitSpellChecker* checker, const char* languages)
        [FieldOffset(16)]
        public global::System.IntPtr update_spell_checking_languages;

        // DEBUG: char* (*get_autocorrect_suggestions_for_misspelled_word) (WebKitSpellChecker* checker, const char* word)
        [FieldOffset(20)]
        public global::System.IntPtr get_autocorrect_suggestions_for_misspelled_word;

        // DEBUG: void (*learn_word) (WebKitSpellChecker* checker, const char* word)
        [FieldOffset(24)]
        public global::System.IntPtr learn_word;

        // DEBUG: void (*ignore_word) (WebKitSpellChecker* checker, const char* word)
        [FieldOffset(28)]
        public global::System.IntPtr ignore_word;
    }

    public unsafe partial class WebKitSpellChecker :GLib.Object
    {
        public WebKitSpellChecker(IntPtr handle) : base(handle){}
        // DEBUG: WEBKIT_API GType webkit_spell_checker_get_type (void)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="webkit_spell_checker_get_type")]
        internal static extern uint webkit_spell_checker_get_type();

        public GLib.GType Type
        {
            get
            {
                return new GLib.GType((IntPtr)webkit_spell_checker_get_type());
            }
        }

        // DEBUG: WEBKIT_API void webkit_spell_checker_check_spelling_of_string (WebKitSpellChecker *checker, const char *string, int *misspelling_location, int *misspelling_length)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet=CharSet.Ansi,
            EntryPoint="webkit_spell_checker_check_spelling_of_string")]
        internal static extern void webkit_spell_checker_check_spelling_of_string(global::System.IntPtr checker, string @string, ref int misspelling_location, ref int misspelling_length);

        public void CheckSpellingOfString(string @string, ref int misspelling_location,ref int misspelling_length){
            webkit_spell_checker_check_spelling_of_string(this.Handle,@string,ref misspelling_location,ref misspelling_length);
        }

        // DEBUG: WEBKIT_API char** webkit_spell_checker_get_guesses_for_word (WebKitSpellChecker *checker, const char *word, const char *context)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = CharSet.Ansi,
            EntryPoint="webkit_spell_checker_get_guesses_for_word")]
        internal static extern StringBuilder webkit_spell_checker_get_guesses_for_word(global::System.IntPtr checker,string word, string context);

        public string GetGuessesForWord(string word, string context)
        {
            return webkit_spell_checker_get_guesses_for_word(this.Handle, word, context).ToString();
        }

        // DEBUG: WEBKIT_API void webkit_spell_checker_update_spell_checking_languages (WebKitSpellChecker *checker, const char *languages)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = CharSet.Ansi,
            EntryPoint="webkit_spell_checker_update_spell_checking_languages")]
        internal static extern void webkit_spell_checker_update_spell_checking_languages(global::System.IntPtr checker, string languages);

        public void UpdateSpellCheckingLanguages(string languages)
        {
            webkit_spell_checker_update_spell_checking_languages(this.Handle, languages);
        }

        // DEBUG: WEBKIT_API char* webkit_spell_checker_get_autocorrect_suggestions_for_misspelled_word (WebKitSpellChecker *checker, const char *word)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = CharSet.Ansi,
            EntryPoint="webkit_spell_checker_get_autocorrect_suggestions_for_misspelled_word")]
        internal static extern string webkit_spell_checker_get_autocorrect_suggestions_for_misspelled_word(global::System.IntPtr checker, string word);

        public string AutoCorrectSuggestionsForMisspelledWord(string word){
            return webkit_spell_checker_get_autocorrect_suggestions_for_misspelled_word(this.Handle, word);
        }

        // DEBUG: WEBKIT_API void webkit_spell_checker_learn_word (WebKitSpellChecker *checker, const char *word)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = CharSet.Ansi,
            EntryPoint="webkit_spell_checker_learn_word")]
        internal static extern void webkit_spell_checker_learn_word(global::System.IntPtr checker, string word);

        public void LearnWord(string word)
        {
            webkit_spell_checker_learn_word(this.Handle, word);
        }

        // DEBUG: WEBKIT_API void webkit_spell_checker_ignore_word (WebKitSpellChecker *checker, const char *word)
        [SuppressUnmanagedCodeSecurity]
        [DllImport("webkitgtk-1.0", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, CharSet = CharSet.Ansi,
            EntryPoint="webkit_spell_checker_ignore_word")]
        internal static extern void webkit_spell_checker_ignore_word(global::System.IntPtr checker, string word);

        public void IgnoreWord(string word)
        {
            webkit_spell_checker_ignore_word(this.Handle, word);
        }
    }
}
