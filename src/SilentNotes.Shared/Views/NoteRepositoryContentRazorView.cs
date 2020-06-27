#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SilentNotes.Views
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#line 1 "NoteRepositoryContentRazorView.cshtml"
using SilentNotes.ViewModels;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "16.6.0.1061")]
public partial class NoteRepositoryContentRazorView : NoteRepositoryContentRazorViewBase
{

#line hidden

#line 2 "NoteRepositoryContentRazorView.cshtml"
public NoteRepositoryViewModel Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("<ul");

WriteLiteral(" id=\"note-repository\"");

WriteLiteral(" class=\"wraplist selectable sortable\"");

WriteLiteral(">\r\n");


#line 4 "NoteRepositoryContentRazorView.cshtml"
    

#line default
#line hidden

#line 4 "NoteRepositoryContentRazorView.cshtml"
     foreach (var note in @Model.FilteredNotes)
    {


#line default
#line hidden
WriteLiteral("    <li");

WriteLiteral(" class=\"wraplist-item sortable-item\"");

WriteLiteral(" data-note=\"");


#line 6 "NoteRepositoryContentRazorView.cshtml"
                                                  Write(note.Id.ToString());


#line default
#line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n        <div");

WriteAttribute ("class", " class=\"", "\""
, Tuple.Create<string,object,bool> ("", "note-card", true)

#line 7 "NoteRepositoryContentRazorView.cshtml"
, Tuple.Create<string,object,bool> (" ", note.GetDarkClass()

#line default
#line hidden
, false)
);
WriteAttribute ("style", " style=\"", "\""
, Tuple.Create<string,object,bool> ("", "background-color:", true)

#line 7 "NoteRepositoryContentRazorView.cshtml"
                                     , Tuple.Create<string,object,bool> ("", note.BackgroundColorHex

#line default
#line hidden
, false)
);
WriteLiteral(" onclick=\"bind(event);\"");

WriteLiteral(" data-binding=\"ShowNote\"");

WriteLiteral(">\r\n");


#line 8 "NoteRepositoryContentRazorView.cshtml"
            

#line default
#line hidden

#line 8 "NoteRepositoryContentRazorView.cshtml"
             if (@note.IsLocked)
            {


#line default
#line hidden
WriteLiteral("                <span");

WriteAttribute ("class", " class=\"", "\""
, Tuple.Create<string,object,bool> ("", "locked", true)

#line 10 "NoteRepositoryContentRazorView.cshtml"
, Tuple.Create<string,object,bool> (" ", note.GetDarkClass()

#line default
#line hidden
, false)
);
WriteLiteral("><svg");

WriteLiteral(" width=\'24\'");

WriteLiteral(" height=\'24\'");

WriteLiteral(" viewBox=\'0 0 24 24\'");

WriteLiteral("><use");

WriteLiteral(" xlink:href=\"#svg-lock-outline\"");

WriteLiteral(" /></svg></span>\r\n");


#line 11 "NoteRepositoryContentRazorView.cshtml"
            }
            else
            {


#line default
#line hidden
WriteLiteral("                <div");

WriteAttribute ("class", " class=\"", "\""
, Tuple.Create<string,object,bool> ("", "note-viewer", true)
, Tuple.Create<string,object,bool> (" ", "over-view", true)

#line 14 "NoteRepositoryContentRazorView.cshtml"
          , Tuple.Create<string,object,bool> (" ", note.CssClassNoteType

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 14 "NoteRepositoryContentRazorView.cshtml"
                                                                            WriteLiteral(note.UnlockedHtmlContent);

#line default
#line hidden
WriteLiteral("</div>\r\n");


#line 15 "NoteRepositoryContentRazorView.cshtml"
            }


#line default
#line hidden
WriteLiteral("        </div>\r\n        <div");

WriteAttribute ("class", " class=\"", "\""
, Tuple.Create<string,object,bool> ("", "note-handle", true)
, Tuple.Create<string,object,bool> (" ", "sortable-handle", true)

#line 17 "NoteRepositoryContentRazorView.cshtml"
        , Tuple.Create<string,object,bool> (" ", note.GetDarkClass()

#line default
#line hidden
, false)
);
WriteLiteral("><svg");

WriteLiteral(" width=\'22\'");

WriteLiteral(" height=\'22\'");

WriteLiteral(" viewBox=\'0 0 24 24\'");

WriteLiteral("><use");

WriteLiteral(" xlink:href=\"#svg-arrow-all\"");

WriteLiteral(" /></svg></div>\r\n        <div");

WriteAttribute ("class", " class=\"", "\""
, Tuple.Create<string,object,bool> ("", "note-handle", true)
, Tuple.Create<string,object,bool> (" ", "safe-handle", true)
, Tuple.Create<string,object,bool> (" ", "greenish", true)
, Tuple.Create<string,object,bool> (" ", new Action<System.IO.TextWriter> (__razor_attribute_value_writer => {

#line 18 "NoteRepositoryContentRazorView.cshtml"
                                                      if (!@Model.IsAnySafeOpen || @note.IsInSafe || @note.IsLocked) {

#line default
#line hidden
WriteLiteralTo(__razor_attribute_value_writer, " ");

WriteLiteralTo(__razor_attribute_value_writer, "hidden");

WriteLiteralTo(__razor_attribute_value_writer, " ");


#line 18 "NoteRepositoryContentRazorView.cshtml"
                                                                                                                                           }

#line default
#line hidden
}), false)

#line 18 "NoteRepositoryContentRazorView.cshtml"
                                                                                                     , Tuple.Create<string,object,bool> (" ", note.GetDarkClass()

#line default
#line hidden
, false)
);
WriteLiteral(" onclick=\"bind(event);\"");

WriteLiteral(" data-binding=\"AddToSafe\"");

WriteLiteral("><svg");

WriteLiteral(" width=\'18\'");

WriteLiteral(" height=\'18\'");

WriteLiteral(" viewBox=\'0 0 24 24\'");

WriteLiteral("><use");

WriteLiteral(" xlink:href=\"#svg-lock-open-variant\"");

WriteLiteral(" /></svg></div>\r\n        <div");

WriteAttribute ("class", " class=\"", "\""
, Tuple.Create<string,object,bool> ("", "note-handle", true)
, Tuple.Create<string,object,bool> (" ", "safe-handle", true)
, Tuple.Create<string,object,bool> (" ", "reddish", true)
, Tuple.Create<string,object,bool> (" ", new Action<System.IO.TextWriter> (__razor_attribute_value_writer => {

#line 19 "NoteRepositoryContentRazorView.cshtml"
                                                     if (!@Model.IsAnySafeOpen || !@note.IsInSafe || @note.IsLocked) {

#line default
#line hidden
WriteLiteralTo(__razor_attribute_value_writer, " ");

WriteLiteralTo(__razor_attribute_value_writer, "hidden");

WriteLiteralTo(__razor_attribute_value_writer, " ");


#line 19 "NoteRepositoryContentRazorView.cshtml"
                                                                                                                                           }

#line default
#line hidden
}), false)

#line 19 "NoteRepositoryContentRazorView.cshtml"
                                                                                                     , Tuple.Create<string,object,bool> (" ", note.GetDarkClass()

#line default
#line hidden
, false)
);
WriteLiteral(" onclick=\"bind(event);\"");

WriteLiteral(" data-binding=\"RemoveFromSafe\"");

WriteLiteral("><svg");

WriteLiteral(" width=\'18\'");

WriteLiteral(" height=\'18\'");

WriteLiteral(" viewBox=\'0 0 24 24\'");

WriteLiteral("><use");

WriteLiteral(" xlink:href=\"#svg-lock\"");

WriteLiteral(" /></svg></div>\r\n        <div");

WriteAttribute ("class", " class=\"", "\""
, Tuple.Create<string,object,bool> ("", "note-handle", true)
, Tuple.Create<string,object,bool> (" ", "recycle-handle", true)

#line 20 "NoteRepositoryContentRazorView.cshtml"
       , Tuple.Create<string,object,bool> (" ", note.GetDarkClass()

#line default
#line hidden
, false)
);
WriteLiteral(" onclick=\"bind(event);\"");

WriteLiteral(" data-binding=\"DeleteNote\"");

WriteLiteral("><svg");

WriteLiteral(" width=\'19\'");

WriteLiteral(" height=\'19\'");

WriteLiteral(" viewBox=\'0 0 24 24\'");

WriteLiteral("><use");

WriteLiteral(" xlink:href=\"#svg-delete\"");

WriteLiteral(" /></svg></div>\r\n    </li>\r\n");


#line 22 "NoteRepositoryContentRazorView.cshtml"
    }


#line default
#line hidden
WriteLiteral("</ul>\r\n");

}
}

// NOTE: this is the default generated helper class. You may choose to extract it to a separate file 
// in order to customize it or share it between multiple templates, and specify the template's base 
// class via the @inherits directive.
public abstract class NoteRepositoryContentRazorViewBase
{

		// This field is OPTIONAL, but used by the default implementation of Generate, Write, WriteAttribute and WriteLiteral
		//
		System.IO.TextWriter __razor_writer;

		// This method is OPTIONAL
		//
		/// <summary>Executes the template and returns the output as a string.</summary>
		/// <returns>The template output.</returns>
		public string GenerateString ()
		{
			using (var sw = new System.IO.StringWriter ()) {
				Generate (sw);
				return sw.ToString ();
			}
		}

		// This method is OPTIONAL, you may choose to implement Write and WriteLiteral without use of __razor_writer
		// and provide another means of invoking Execute.
		//
		/// <summary>Executes the template, writing to the provided text writer.</summary>
		/// <param name="writer">The TextWriter to which to write the template output.</param>
		public void Generate (System.IO.TextWriter writer)
		{
			__razor_writer = writer;
			Execute ();
			__razor_writer = null;
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the template output without HTML escaping it.</summary>
		/// <param name="value">The literal value.</param>
		protected void WriteLiteral (string value)
		{
			__razor_writer.Write (value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the TextWriter without HTML escaping it.</summary>
		/// <param name="writer">The TextWriter to which to write the literal.</param>
		/// <param name="value">The literal value.</param>
		protected static void WriteLiteralTo (System.IO.TextWriter writer, string value)
		{
			writer.Write (value);
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a value to the template output, HTML escaping it if necessary.</summary>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected void Write (object value)
		{
			WriteTo (__razor_writer, value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes an object value to the TextWriter, HTML escaping it if necessary.</summary>
		/// <param name="writer">The TextWriter to which to write the value.</param>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected static void WriteTo (System.IO.TextWriter writer, object value)
		{
			if (value == null)
				return;

			var write = value as Action<System.IO.TextWriter>;
			if (write != null) {
				write (writer);
				return;
			}

			//NOTE: a more sophisticated implementation would write safe and pre-escaped values directly to the
			//instead of double-escaping. See System.Web.IHtmlString in ASP.NET 4.0 for an example of this.
			writer.Write(System.Net.WebUtility.HtmlEncode (value.ToString ()));
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to the template output.
		/// </summary>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		protected void WriteAttribute (string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			WriteAttributeTo (__razor_writer, name, prefix, suffix, values);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to a TextWriter.
		/// </summary>
		/// <param name="writer">The TextWriter to which to write the attribute.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		///<remarks>Used by Razor helpers to write attributes.</remarks>
		protected static void WriteAttributeTo (System.IO.TextWriter writer, string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			// this is based on System.Web.WebPages.WebPageExecutingBase
			// Copyright (c) Microsoft Open Technologies, Inc.
			// Licensed under the Apache License, Version 2.0
			if (values.Length == 0) {
				// Explicitly empty attribute, so write the prefix and suffix
				writer.Write (prefix);
				writer.Write (suffix);
				return;
			}

			bool first = true;
			bool wroteSomething = false;

			for (int i = 0; i < values.Length; i++) {
				Tuple<string,object,bool> attrVal = values [i];
				string attPrefix = attrVal.Item1;
				object value = attrVal.Item2;
				bool isLiteral = attrVal.Item3;

				if (value == null) {
					// Nothing to write
					continue;
				}

				// The special cases here are that the value we're writing might already be a string, or that the
				// value might be a bool. If the value is the bool 'true' we want to write the attribute name instead
				// of the string 'true'. If the value is the bool 'false' we don't want to write anything.
				//
				// Otherwise the value is another object (perhaps an IHtmlString), and we'll ask it to format itself.
				string stringValue;
				bool? boolValue = value as bool?;
				if (boolValue == true) {
					stringValue = name;
				} else if (boolValue == false) {
					continue;
				} else {
					stringValue = value as string;
				}

				if (first) {
					writer.Write (prefix);
					first = false;
				} else {
					writer.Write (attPrefix);
				}

				if (isLiteral) {
					writer.Write (stringValue ?? value);
				} else {
					WriteTo (writer, stringValue ?? value);
				}
				wroteSomething = true;
			}
			if (wroteSomething) {
				writer.Write (suffix);
			}
		}
		// This method is REQUIRED. The generated Razor subclass will override it with the generated code.
		//
		///<summary>Executes the template, writing output to the Write and WriteLiteral methods.</summary>.
		///<remarks>Not intended to be called directly. Call the Generate method instead.</remarks>
		public abstract void Execute ();

}
}
#pragma warning restore 1591
