﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XB1ControllerBatteryIndicator.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.9.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoStart {
            get {
                return ((bool)(this["AutoStart"]));
            }
            set {
                this["AutoStart"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UpdateCheck {
            get {
                return ((bool)(this["UpdateCheck"]));
            }
            set {
                this["UpdateCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en")]
        public string Language {
            get {
                return ((string)(this["Language"]));
            }
            set {
                this["Language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string wavFile {
            get {
                return ((string)(this["wavFile"]));
            }
            set {
                this["wavFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LowBatteryWarningSound_Enabled {
            get {
                return ((bool)(this["LowBatteryWarningSound_Enabled"]));
            }
            set {
                this["LowBatteryWarningSound_Enabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LowBatteryWarningSound_Loop_Enabled {
            get {
                return ((bool)(this["LowBatteryWarningSound_Loop_Enabled"]));
            }
            set {
                this["LowBatteryWarningSound_Loop_Enabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LowBatteryToast_Enabled {
            get {
                return ((bool)(this["LowBatteryToast_Enabled"]));
            }
            set {
                this["LowBatteryToast_Enabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LowBatteryPopup_Enabled {
            get {
                return ((bool)(this["LowBatteryPopup_Enabled"]));
            }
            set {
                this["LowBatteryPopup_Enabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool GuidePressPopup_Enabled {
            get {
                return ((bool)(this["GuidePressPopup_Enabled"]));
            }
            set {
                this["GuidePressPopup_Enabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"
          <SimpleBatteryPopupSettings xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
            <Size>
              <Width>300</Width>
              <Height>60</Height>
            </Size>
            <X>0.5</X>
            <AlignmentX>Left</AlignmentX>
            <Y>0.8</Y>
            <AlignmentY>Top</AlignmentY>
            <DisplayDuration>0:00:03</DisplayDuration>
            <BackgroundColor>#FFA9A9A9</BackgroundColor>
            <ForegroundColor>#FFF8F8FF</ForegroundColor>
            <FontSize>20</FontSize>
            <FontName>Segoe UI</FontName>
            <FontBold>false</FontBold>
            <FontItalic>false</FontItalic>
            <FontUnderline>false</FontUnderline>
          </SimpleBatteryPopupSettings>
        ")]
        public global::XB1ControllerBatteryIndicator.BatteryPopup.SimpleBatteryPopupSettings PopupSettings {
            get {
                return ((global::XB1ControllerBatteryIndicator.BatteryPopup.SimpleBatteryPopupSettings)(this["PopupSettings"]));
            }
            set {
                this["PopupSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MinorUpdateCheck {
            get {
                return ((bool)(this["MinorUpdateCheck"]));
            }
            set {
                this["MinorUpdateCheck"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowWirelessControllersWithKnownBatteryLevel {
            get {
                return ((bool)(this["ShowWirelessControllersWithKnownBatteryLevel"]));
            }
            set {
                this["ShowWirelessControllersWithKnownBatteryLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowWirelessControllersWithUnknownBatteryLevel {
            get {
                return ((bool)(this["ShowWirelessControllersWithUnknownBatteryLevel"]));
            }
            set {
                this["ShowWirelessControllersWithUnknownBatteryLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowWiredControllers {
            get {
                return ((bool)(this["ShowWiredControllers"]));
            }
            set {
                this["ShowWiredControllers"] = value;
            }
        }
    }
}
