﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seal.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.11.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection MRU {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["MRU"]));
            }
            set {
                this["MRU"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowScriptErrors {
            get {
                return ((bool)(this["ShowScriptErrors"]));
            }
            set {
                this["ShowScriptErrors"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool SchedulesWithCurrentUser {
            get {
                return ((bool)(this["SchedulesWithCurrentUser"]));
            }
            set {
                this["SchedulesWithCurrentUser"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\ProgramData\\Seal Report Repository")]
        public string RepositoryPath {
            get {
                return ((string)(this["RepositoryPath"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("140, 140")]
        public global::System.Drawing.Point FormLocation {
            get {
                return ((global::System.Drawing.Point)(this["FormLocation"]));
            }
            set {
                this["FormLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1400, 800")]
        public global::System.Drawing.Size FormSize {
            get {
                return ((global::System.Drawing.Size)(this["FormSize"]));
            }
            set {
                this["FormSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string FormState {
            get {
                return ((string)(this["FormState"]));
            }
            set {
                this["FormState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("150, 150")]
        public global::System.Drawing.Point ViewerFormLocation {
            get {
                return ((global::System.Drawing.Point)(this["ViewerFormLocation"]));
            }
            set {
                this["ViewerFormLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1200, 800")]
        public global::System.Drawing.Size ViewerFormSize {
            get {
                return ((global::System.Drawing.Size)(this["ViewerFormSize"]));
            }
            set {
                this["ViewerFormSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ViewerFormState {
            get {
                return ((string)(this["ViewerFormState"]));
            }
            set {
                this["ViewerFormState"] = value;
            }
        }
    }
}
