﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LEDDisplay.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableTime {
            get {
                return ((bool)(this["EnableTime"]));
            }
            set {
                this["EnableTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("h:mm tt")]
        public string TimeFormat {
            get {
                return ((string)(this["TimeFormat"]));
            }
            set {
                this["TimeFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableWeather {
            get {
                return ((bool)(this["EnableWeather"]));
            }
            set {
                this["EnableWeather"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Temp: $temperature$`C Hum: $humidity$% Wind: $windSpeed$km/h $windDirection$ Clou" +
            "ds: $clouds$")]
        public string WeatherFormat {
            get {
                return ((string)(this["WeatherFormat"]));
            }
            set {
                this["WeatherFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableGMail {
            get {
                return ((bool)(this["EnableGMail"]));
            }
            set {
                this["EnableGMail"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("YOUR_GMAIL_USER_NAME_HERE")]
        public string GMailUserName {
            get {
                return ((string)(this["GMailUserName"]));
            }
            set {
                this["GMailUserName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("YOUR_APPLICATION_PASSWORD_HERE")]
        public string GMailApplicationPassword {
            get {
                return ((string)(this["GMailApplicationPassword"]));
            }
            set {
                this["GMailApplicationPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Edmonton,AB,Canada")]
        public string WeatherLocation {
            get {
                return ((string)(this["WeatherLocation"]));
            }
            set {
                this["WeatherLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("metric")]
        public string WeatherUnits {
            get {
                return ((string)(this["WeatherUnits"]));
            }
            set {
                this["WeatherUnits"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("New mail: $unread$")]
        public string GMailFormat {
            get {
                return ((string)(this["GMailFormat"]));
            }
            set {
                this["GMailFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool EnableStats {
            get {
                return ((bool)(this["EnableStats"]));
            }
            set {
                this["EnableStats"] = value;
            }
        }
    }
}
