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

#line 1 "ChecklistRazorView.cshtml"
using SilentNotes.ViewModels;

#line default
#line hidden


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "16.6.0.1062")]
public partial class ChecklistRazorView : ChecklistRazorViewBase
{

#line hidden

#line 2 "ChecklistRazorView.cshtml"
public NoteViewModel Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n<head>\r\n    <meta");

WriteLiteral(" http-equiv=\"X-UA-Compatible\"");

WriteLiteral(" content=\"IE=edge\"");

WriteLiteral(" />\r\n    <base");

WriteAttribute ("href", " href=\"", "\""

#line 7 "ChecklistRazorView.cshtml"
, Tuple.Create<string,object,bool> ("", Model.HtmlBase

#line default
#line hidden
, false)
);
WriteLiteral(">\r\n    <title>SilentNotes</title>\r\n    <meta");

WriteLiteral(" charset=\"UTF-8\"");

WriteLiteral(" />\r\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1, shrink-to-fit=no, user-scalable=no" +
"\"");

WriteLiteral(">\r\n\r\n    <link");

WriteLiteral(" href=\"bootstrap.min.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteLiteral(" href=\"silentnotes.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute ("href", " href=\"", "\""

#line 14 "ChecklistRazorView.cshtml"
, Tuple.Create<string,object,bool> ("", Model.Theme.DarkMode ? "silentnotes.dark.css" : "silentnotes.light.css"

#line default
#line hidden
, false)
);
WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n\r\n    <link");

WriteLiteral(" href=\"quill/quill.snow.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" href=\"note-view.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" href=\"quillsearchhighlighter.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n\r\n    <script");

WriteLiteral(" src=\"vue.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"jquery-3.5.1.slim.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"bootstrap.bundle.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"silentnotes.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"checklist.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"quill/quill.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"quillsearchhighlighter.js\"");

WriteLiteral("></script>\r\n\r\n    <style");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(">\r\nbody { background-color: transparent; }\r\n\r\n.note-viewer {\r\n    font-size: ");


#line 32 "ChecklistRazorView.cshtml"
           Write(Model.NoteBaseFontSize);


#line default
#line hidden
WriteLiteral("px !important;\r\n}\r\ndiv .detail-view.checklist .ql-editor p::before { content: ");


#line 34 "ChecklistRazorView.cshtml"
                                                             WriteLiteral(Model.Icon.LoadIconAsCssUrl("checkbox-blank-outline", new[] { new KeyValuePair<string, string>("fill", "#000000") }));

#line default
#line hidden
WriteLiteral("; }\r\ndiv .detail-view.checklist .ql-editor p.done::before { content: ");


#line 35 "ChecklistRazorView.cshtml"
                                                                  WriteLiteral(Model.Icon.LoadIconAsCssUrl("check-box-outline", new[] { new KeyValuePair<string, string>("fill", "#000000") }));

#line default
#line hidden
WriteLiteral("; }\r\ndiv .detail-view.checklist .ql-editor p.disabled::before { content: ");


#line 36 "ChecklistRazorView.cshtml"
                                                                      WriteLiteral(Model.Icon.LoadIconAsCssUrl("checkbox-blank-outline", new[] { new KeyValuePair<string, string>("fill", "#000000") }));

#line default
#line hidden
WriteLiteral("; }\r\ndiv .detail-view.checklist .ql-editor p::after { content: ");


#line 37 "ChecklistRazorView.cshtml"
                                                            WriteLiteral(Model.Icon.LoadIconAsCssUrl("delete", new[] { new KeyValuePair<string, string>("fill", "#000000") }));

#line default
#line hidden
WriteLiteral("; }\r\ndiv.dark .detail-view.checklist .ql-editor p::before { content: ");


#line 38 "ChecklistRazorView.cshtml"
                                                                  WriteLiteral(Model.Icon.LoadIconAsCssUrl("checkbox-blank-outline", new[] { new KeyValuePair<string, string>("fill", "#FFFFFF") }));

#line default
#line hidden
WriteLiteral("; }\r\ndiv.dark .detail-view.checklist .ql-editor p.done::before { content: ");


#line 39 "ChecklistRazorView.cshtml"
                                                                       WriteLiteral(Model.Icon.LoadIconAsCssUrl("check-box-outline", new[] { new KeyValuePair<string, string>("fill", "#FFFFFF") }));

#line default
#line hidden
WriteLiteral("; }\r\ndiv.dark .detail-view.checklist .ql-editor p.disabled::before { content: ");


#line 40 "ChecklistRazorView.cshtml"
                                                                           WriteLiteral(Model.Icon.LoadIconAsCssUrl("checkbox-blank-outline", new[] { new KeyValuePair<string, string>("fill", "#FFFFFF") }));

#line default
#line hidden
WriteLiteral("; }\r\ndiv.dark .detail-view.checklist .ql-editor p::after { content: ");


#line 41 "ChecklistRazorView.cshtml"
                                                                 WriteLiteral(Model.Icon.LoadIconAsCssUrl("delete", new[] { new KeyValuePair<string, string>("fill", "#FFFFFF") }));

#line default
#line hidden
WriteLiteral("; }\r\n\r\n.color-btn { color: black; }\r\n.color-btn.dark { color: white; }\r\n.locked {" +
"\r\n    position: relative;\r\n    height: 100%;\r\n}\r\n.locked svg {\r\n    fill: rgba(1" +
"60, 160, 160, 0.4);\r\n}\r\n#pretty-time-ago {\r\n    position: fixed;\r\n    display: i" +
"nline-block;\r\n    margin: 0;\r\n    padding: 0.1em 0.8em 0.15em 0.8em;\r\n    right:" +
" 0;\r\n    bottom: 0;\r\n    color: black;\r\n    background-color: rgba(128, 128, 128" +
", 0.2);\r\n\tpointer-events: none; /* do not prevent clicks on recyclebin */\r\n}\r\n#p" +
"retty-time-ago.dark {\r\n    color: white;\r\n    background-color: rgba(211, 211, 2" +
"11, 0.3);\r\n}\r\n\r\n    </style>\r\n    <script>\r\n        var quill;\r\n        var sear" +
"chHighlighter;\r\n\r\n        function getNoteHtmlContent() {\r\n            return qu" +
"ill.root.innerHTML;\r\n        }\r\n\r\n        function setNoteHtmlContent(text) {\r\n " +
"           quill.setText(text, \'user\');\r\n        }\r\n\r\n        function toggleSea" +
"rchDialog() {\r\n            var makeVisible = $(\'#search-dialog\').hasClass(\'hidde" +
"n\');\r\n            showSearchDialog(makeVisible);\r\n        }\r\n\r\n        function " +
"showSearchDialog(visible) {\r\n            if (visible) {\r\n                // Open" +
" dialog\r\n                $(\'#search-dialog\').removeClass(\'hidden\');\r\n           " +
"     $(\'#TxtFilter\').focus();\r\n                searchHighlighter.startListening(" +
");\r\n            }\r\n            else {\r\n                // Close dialog\r\n        " +
"        searchHighlighter.stopListening();\r\n                searchHighlighter.cl" +
"earSearchHighlights();\r\n                $(\'#search-dialog\').addClass(\'hidden\');\r" +
"\n                $(\'#TxtFilter\').val(\'\');\r\n            }\r\n        }\r\n\r\n        f" +
"unction scrollToTop() {\r\n            var element = quill.root;\r\n            elem" +
"ent.scrollTop = 0;\r\n        }\r\n\r\n        function scrollToBottom() {\r\n          " +
"  var element = quill.root;\r\n            element.scrollTop = element.scrollHeigh" +
"t;\r\n        }\r\n\r\n        $(function () {\r\n            // quill \"imports\" the exi" +
"sting html content and looses the class attributes,\r\n            // that\'s why w" +
"e save and reapply the check states.\r\n            var checkStates = saveCheckSta" +
"tes();\r\n            quill = new Quill(\'#myeditor\', {\r\n                formats: [" +
"\'header\'],\r\n                modules: {\r\n                    toolbar: {\r\n        " +
"                container: \'#quill-toolbar\',\r\n                    },\r\n          " +
"      },\r\n                theme: \'snow\',\r\n            });\r\n            restoreCh" +
"eckStates(checkStates);\r\n\r\n            quill.on(\'text-change\', function (delta, " +
"oldDelta, source) {\r\n                if (source === \'user\') {\r\n                 " +
"   vuePropertyChanged(\'UnlockedHtmlContent\', null);\r\n                }\r\n        " +
"    });\r\n\r\n            $(quill.root).one(\"focusin\", function () {\r\n             " +
"   vm.PrettyTimeAgoVisible = false;\r\n            });\r\n\r\n            searchHighli" +
"ghter = new QuillSearchHighlighter(quill, document.getElementById(\"TxtFilter\"));" +
"\r\n        });\r\n\r\n");


#line 140 "ChecklistRazorView.cshtml"
        

#line default
#line hidden

#line 140 "ChecklistRazorView.cshtml"
          WriteLiteral(Model.VueDataBindingScript);

#line default
#line hidden
WriteLiteral("\r\n    </script>\r\n</head>\r\n<body><div");

WriteLiteral(" id=\"vueDataBinding\"");

WriteLiteral(">\r\n    <nav");

WriteLiteral(" id=\"navigation\"");

WriteLiteral(" class=\"d-flex\"");

WriteLiteral(">\r\n        <button");

WriteLiteral(" class=\"nav-item mr-auto\"");

WriteLiteral(" v-on:click=\"GoBackCommand\"");

WriteAttribute ("title", " title=\"", "\""

#line 145 "ChecklistRazorView.cshtml"
                                    , Tuple.Create<string,object,bool> ("", Model.Language["back"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 145 "ChecklistRazorView.cshtml"
                                                                                                      WriteLiteral(Model.Icon["arrow-left"]);

#line default
#line hidden
WriteLiteral("</button>\r\n\r\n");


#line 147 "ChecklistRazorView.cshtml"
        

#line default
#line hidden

#line 147 "ChecklistRazorView.cshtml"
         if (!Model.IsLocked)
        {


#line default
#line hidden
WriteLiteral("            <button");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(" onclick=\"toggleSearchDialog(); return false;\"");

WriteAttribute ("title", " title=\"", "\""

#line 149 "ChecklistRazorView.cshtml"
                                                   , Tuple.Create<string,object,bool> ("", Model.Language["search"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 149 "ChecklistRazorView.cshtml"
                                                                                                                       WriteLiteral(Model.Icon["magnify"]);

#line default
#line hidden
WriteLiteral("</button>\r\n");

WriteLiteral("            <button");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(" onclick=\"moveUp(true); return false;\"");

WriteAttribute ("title", " title=\"", "\""

#line 150 "ChecklistRazorView.cshtml"
                                           , Tuple.Create<string,object,bool> ("", Model.Language["checklist_move_to_top"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 150 "ChecklistRazorView.cshtml"
                                                                                                                              WriteLiteral(Model.Icon["arrow-collapse-up"]);

#line default
#line hidden
WriteLiteral("</button>\r\n");

WriteLiteral("            <button");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(" onclick=\"moveUp(false); return false;\"");

WriteAttribute ("title", " title=\"", "\""

#line 151 "ChecklistRazorView.cshtml"
                                            , Tuple.Create<string,object,bool> ("", Model.Language["checklist_move_up"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 151 "ChecklistRazorView.cshtml"
                                                                                                                           WriteLiteral(Model.Icon["arrow-up"]);

#line default
#line hidden
WriteLiteral("</button>\r\n");

WriteLiteral("            <button");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(" onclick=\"moveDown(false); return false;\"");

WriteAttribute ("title", " title=\"", "\""

#line 152 "ChecklistRazorView.cshtml"
                                              , Tuple.Create<string,object,bool> ("", Model.Language["checklist_move_down"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 152 "ChecklistRazorView.cshtml"
                                                                                                                               WriteLiteral(Model.Icon["arrow-down"]);

#line default
#line hidden
WriteLiteral("</button>\r\n");

WriteLiteral("            <button");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(" onclick=\"moveDown(true); return false;\"");

WriteAttribute ("title", " title=\"", "\""

#line 153 "ChecklistRazorView.cshtml"
                                             , Tuple.Create<string,object,bool> ("", Model.Language["checklist_move_to_bottom"]

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 153 "ChecklistRazorView.cshtml"
                                                                                                                                   WriteLiteral(Model.Icon["arrow-collapse-down"]);

#line default
#line hidden
WriteLiteral("</button>\r\n");


#line 154 "ChecklistRazorView.cshtml"
        }


#line default
#line hidden
WriteLiteral("\r\n        <span");

WriteLiteral(" id=\"quill-toolbar\"");

WriteLiteral(" class=\"d-inline-flex\"");

WriteLiteral(">\r\n");


#line 157 "ChecklistRazorView.cshtml"
            

#line default
#line hidden

#line 157 "ChecklistRazorView.cshtml"
             if (!Model.IsLocked)
            {


#line default
#line hidden
WriteLiteral("                <button");

WriteLiteral(" class=\"nav-item ql-header\"");

WriteLiteral(" value=\"1\"");

WriteAttribute ("title", " title=\"", "\""

#line 159 "ChecklistRazorView.cshtml"
                             , Tuple.Create<string,object,bool> ("", Model.Language["note_header1"]

#line default
#line hidden
, false)
);
WriteLiteral("></button>\r\n");


#line 160 "ChecklistRazorView.cshtml"
            }


#line default
#line hidden
WriteLiteral("        </span>\r\n\r\n        <!-- Color dropdown -->\r\n        <div");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n");


#line 165 "ChecklistRazorView.cshtml"
            

#line default
#line hidden

#line 165 "ChecklistRazorView.cshtml"
             if (!Model.IsLocked)
            {


#line default
#line hidden
WriteLiteral("                <button");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(" id=\"colorDropdownMenu\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteAttribute ("title", " title=\"", "\""

#line 167 "ChecklistRazorView.cshtml"
                                                                                                  , Tuple.Create<string,object,bool> ("", Model.Language["note_colors"]

#line default
#line hidden
, false)
);
WriteLiteral(">\r\n");


#line 168 "ChecklistRazorView.cshtml"
                    

#line default
#line hidden

#line 168 "ChecklistRazorView.cshtml"
                      WriteLiteral(Model.Icon["palette"]);

#line default
#line hidden
WriteLiteral("\r\n                </button>\r\n");


#line 170 "ChecklistRazorView.cshtml"
            }


#line default
#line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"dropdown-menu dropdown-menu-right\"");

WriteLiteral(" aria-labelledby=\"colorDropdownMenu\"");

WriteLiteral(">\r\n");


#line 172 "ChecklistRazorView.cshtml"
                

#line default
#line hidden

#line 172 "ChecklistRazorView.cshtml"
                 foreach (var backgroundColor in @Model.BackgroundColorsHex)
                {


#line default
#line hidden
WriteLiteral("                    <div");

WriteAttribute ("class", " class=\"", "\""
, Tuple.Create<string,object,bool> ("", "dropdown-item", true)
, Tuple.Create<string,object,bool> (" ", "color-btn", true)

#line 174 "ChecklistRazorView.cshtml"
                , Tuple.Create<string,object,bool> (" ", Model.GetDarkClass(backgroundColor)

#line default
#line hidden
, false)
);
WriteAttribute ("v-on:click", " v-on:click=\"", "\""
, Tuple.Create<string,object,bool> ("", "BackgroundColorHex=\'", true)

#line 174 "ChecklistRazorView.cshtml"
                                                                                        , Tuple.Create<string,object,bool> ("", backgroundColor

#line default
#line hidden
, false)
, Tuple.Create<string,object,bool> ("", "\'", true)
);
WriteAttribute ("style", " style=\"", "\""
, Tuple.Create<string,object,bool> ("", "background-color:", true)

#line 174 "ChecklistRazorView.cshtml"
                                                                                                                                    , Tuple.Create<string,object,bool> (" ", backgroundColor

#line default
#line hidden
, false)
);
WriteLiteral(">Lorem ipsum</div>\r\n");


#line 175 "ChecklistRazorView.cshtml"
                }


#line default
#line hidden
WriteLiteral("            </div>\r\n        </div>\r\n\r\n        <!-- Dropdown Menu -->\r\n");


#line 180 "ChecklistRazorView.cshtml"
        

#line default
#line hidden

#line 180 "ChecklistRazorView.cshtml"
         if (!Model.IsLocked)
        {


#line default
#line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n                <button");

WriteLiteral(" class=\"nav-item\"");

WriteLiteral(" id=\"navOverflowMenu\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" aria-haspopup=\"true\"");

WriteLiteral(" aria-expanded=\"false\"");

WriteLiteral(">\r\n");


#line 184 "ChecklistRazorView.cshtml"
                    

#line default
#line hidden

#line 184 "ChecklistRazorView.cshtml"
                      WriteLiteral(Model.Icon["dots-vertical"]);

#line default
#line hidden
WriteLiteral("\r\n                </button>\r\n                <div");

WriteLiteral(" class=\"dropdown-menu dropdown-menu-right\"");

WriteLiteral(" aria-labelledby=\"navOverflowMenu\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(" onclick=\"movePendingToTop(); return false;\"");

WriteLiteral(">");


#line 187 "ChecklistRazorView.cshtml"
                                                                                             WriteLiteral(Model.Icon["sort-bool-descending-variant"]);

#line default
#line hidden
WriteLiteral(" ");


#line 187 "ChecklistRazorView.cshtml"
                                                                                                                                                   Write(Model.Language["checklist_move_pending_to_top"]);


#line default
#line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(" onclick=\"setCheckedStateForAll(false, false); return false;\"");

WriteLiteral(">");


#line 188 "ChecklistRazorView.cshtml"
                                                                                                              WriteLiteral(Model.Icon["checkbox-multiple-blank-outline"]);

#line default
#line hidden
WriteLiteral(" ");


#line 188 "ChecklistRazorView.cshtml"
                                                                                                                                                                       Write(Model.Language["checklist_uncheck_all"]);


#line default
#line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(" onclick=\"setCheckedStateForAll(true, false); return false;\"");

WriteLiteral(">");


#line 189 "ChecklistRazorView.cshtml"
                                                                                                             WriteLiteral(Model.Icon["check-box-multiple-outline"]);

#line default
#line hidden
WriteLiteral(" ");


#line 189 "ChecklistRazorView.cshtml"
                                                                                                                                                                 Write(Model.Language["checklist_check_all"]);


#line default
#line hidden
WriteLiteral("</div>\r\n                    <div");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(" onclick=\"setCheckedStateForAll(false, true); return false;\"");

WriteLiteral(">");


#line 190 "ChecklistRazorView.cshtml"
                                                                                                             WriteLiteral(Model.Icon["checkbox-blank-off-outline"]);

#line default
#line hidden
WriteLiteral(" ");


#line 190 "ChecklistRazorView.cshtml"
                                                                                                                                                                 Write(Model.Language["checklist_disable_all"]);


#line default
#line hidden
WriteLiteral("</div>\r\n");


#line 191 "ChecklistRazorView.cshtml"
                    

#line default
#line hidden

#line 191 "ChecklistRazorView.cshtml"
                     if (Model.ShowManualSynchronization)
                    {


#line default
#line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"dropdown-divider\"");

WriteLiteral("></div>\r\n");

WriteLiteral("                        <div");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(" v-on:click=\"PushNoteToOnlineStorageCommand\"");

WriteLiteral(">");


#line 194 "ChecklistRazorView.cshtml"
                                                                                                 WriteLiteral(Model.Icon["cloud-upload"]);

#line default
#line hidden
WriteLiteral(" ");


#line 194 "ChecklistRazorView.cshtml"
                                                                                                                                       Write(Model.Language["note_push_to_server"]);


#line default
#line hidden
WriteLiteral("</div>\r\n");

WriteLiteral("                        <div");

WriteLiteral(" class=\"dropdown-item\"");

WriteLiteral(" v-on:click=\"PullNoteFromOnlineStorageCommand\"");

WriteLiteral(">");


#line 195 "ChecklistRazorView.cshtml"
                                                                                                   WriteLiteral(Model.Icon["cloud-download"]);

#line default
#line hidden
WriteLiteral(" ");


#line 195 "ChecklistRazorView.cshtml"
                                                                                                                                           Write(Model.Language["note_pull_from_server"]);


#line default
#line hidden
WriteLiteral("</div>\r\n");


#line 196 "ChecklistRazorView.cshtml"
                    }


#line default
#line hidden
WriteLiteral("                </div>\r\n            </div>\r\n");


#line 199 "ChecklistRazorView.cshtml"
        }


#line default
#line hidden
WriteLiteral("    </nav>\r\n\r\n    <div");

WriteLiteral(" id=\"content\"");

WriteLiteral(" v-bind:class=\"{ dark: IsDark }\"");

WriteLiteral(" v-bind:style=\"{ backgroundColor: BackgroundColorHex }\"");

WriteLiteral(">\r\n");


#line 203 "ChecklistRazorView.cshtml"
        

#line default
#line hidden

#line 203 "ChecklistRazorView.cshtml"
         if (Model.IsLocked)
        {


#line default
#line hidden
WriteLiteral("            <span");

WriteLiteral(" class=\"locked d-flex justify-content-center align-items-center\"");

WriteLiteral(" v-bind:class=\"{ dark: IsDark }\"");

WriteLiteral("><svg");

WriteLiteral(" width=\'128\'");

WriteLiteral(" height=\'128\'");

WriteLiteral(" viewBox=\'0 0 24 24\'");

WriteLiteral("><use");

WriteLiteral(" xlink:href=\"#svg-lock-outline\"");

WriteLiteral(" /></svg></span>\r\n");


#line 206 "ChecklistRazorView.cshtml"
        }
        else
        {


#line default
#line hidden
WriteLiteral("            <div");

WriteLiteral(" id=\"myeditor\"");

WriteAttribute ("class", " class=\"", "\""
, Tuple.Create<string,object,bool> ("", "note-viewer", true)
, Tuple.Create<string,object,bool> (" ", "detail-view", true)

#line 209 "ChecklistRazorView.cshtml"
                      , Tuple.Create<string,object,bool> (" ", Model.CssClassNoteType

#line default
#line hidden
, false)
);
WriteLiteral(">");


#line 209 "ChecklistRazorView.cshtml"
                                                                                         WriteLiteral(Model.UnlockedHtmlContent);

#line default
#line hidden
WriteLiteral("</div>\r\n");


#line 210 "ChecklistRazorView.cshtml"
        }


#line default
#line hidden
WriteLiteral("    </div>\r\n\r\n    <div");

WriteLiteral(" id=\"pretty-time-ago\"");

WriteLiteral(" v-if=\"PrettyTimeAgoVisible\"");

WriteLiteral(" v-bind:class=\"{ dark: IsDark }\"");

WriteLiteral(">{{ PrettyTimeAgo }}</div>\r\n\r\n    <div");

WriteLiteral(" id=\"search-dialog\"");

WriteLiteral(" class=\"hidden\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"nav-filter\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" id=\"TxtFilter\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(" />\r\n            <svg");

WriteLiteral(" id=\"filter-cancel-icon\"");

WriteLiteral(" width=\'24\'");

WriteLiteral(" height=\'24\'");

WriteLiteral(" viewBox=\'0 0 24 24\'");

WriteLiteral(" class=\"\"");

WriteLiteral(" onclick=\"showSearchDialog(false);\"");

WriteLiteral("><use");

WriteLiteral(" xlink:href=\"#svg-close-circle-outline\"");

WriteLiteral(" /></svg>\r\n        </div>\r\n    </div>\r\n\r\n    <div hidden>\r\n");


#line 223 "ChecklistRazorView.cshtml"
        

#line default
#line hidden

#line 223 "ChecklistRazorView.cshtml"
          WriteLiteral(Model.Icon.LoadIcon("lock-outline", new[] { new KeyValuePair<string, string>("id", "svg-lock-outline") }));

#line default
#line hidden
WriteLiteral("\r\n");


#line 224 "ChecklistRazorView.cshtml"
        

#line default
#line hidden

#line 224 "ChecklistRazorView.cshtml"
          WriteLiteral(Model.Icon.LoadIcon("delete", new[] { new KeyValuePair<string, string>("id", "svg-delete") }));

#line default
#line hidden
WriteLiteral("\r\n");


#line 225 "ChecklistRazorView.cshtml"
        

#line default
#line hidden

#line 225 "ChecklistRazorView.cshtml"
          WriteLiteral(Model.Icon.LoadIcon("close-circle-outline", new[] { new KeyValuePair<string, string>("id", "svg-close-circle-outline") }));

#line default
#line hidden
WriteLiteral("\r\n    </div>\r\n</div></body>\r\n</html>\r\n");

}
}

// NOTE: this is the default generated helper class. You may choose to extract it to a separate file 
// in order to customize it or share it between multiple templates, and specify the template's base 
// class via the @inherits directive.
public abstract class ChecklistRazorViewBase
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
