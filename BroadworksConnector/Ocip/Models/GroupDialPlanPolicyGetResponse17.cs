using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupDialPlanPolicyGetRequest17
        /// <see cref="GroupDialPlanPolicyGetRequest17"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupDialPlanPolicyGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.GroupDialPlanPolicySettingLevel _useSetting;

        [XmlElement(ElementName = "useSetting", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupDialPlanPolicySettingLevel UseSetting {
            get => _useSetting;
            set {
                UseSettingSpecified = true;
                _useSetting = value;
            }
        }

        [XmlIgnore]
        public bool UseSettingSpecified { get; set; }
        
        private bool _requiresAccessCodeForPublicCalls;

        [XmlElement(ElementName = "requiresAccessCodeForPublicCalls", IsNullable = false, Namespace = "")]
        public bool RequiresAccessCodeForPublicCalls {
            get => _requiresAccessCodeForPublicCalls;
            set {
                RequiresAccessCodeForPublicCallsSpecified = true;
                _requiresAccessCodeForPublicCalls = value;
            }
        }

        [XmlIgnore]
        public bool RequiresAccessCodeForPublicCallsSpecified { get; set; }
        
        private bool _allowE164PublicCalls;

        [XmlElement(ElementName = "allowE164PublicCalls", IsNullable = false, Namespace = "")]
        public bool AllowE164PublicCalls {
            get => _allowE164PublicCalls;
            set {
                AllowE164PublicCallsSpecified = true;
                _allowE164PublicCalls = value;
            }
        }

        [XmlIgnore]
        public bool AllowE164PublicCallsSpecified { get; set; }
        
        private bool _preferE164NumberFormatForCallbackServices;

        [XmlElement(ElementName = "preferE164NumberFormatForCallbackServices", IsNullable = false, Namespace = "")]
        public bool PreferE164NumberFormatForCallbackServices {
            get => _preferE164NumberFormatForCallbackServices;
            set {
                PreferE164NumberFormatForCallbackServicesSpecified = true;
                _preferE164NumberFormatForCallbackServices = value;
            }
        }

        [XmlIgnore]
        public bool PreferE164NumberFormatForCallbackServicesSpecified { get; set; }
        
        private string _publicDigitMap;

        [XmlElement(ElementName = "publicDigitMap", IsNullable = false, Namespace = "")]
        public string PublicDigitMap {
            get => _publicDigitMap;
            set {
                PublicDigitMapSpecified = true;
                _publicDigitMap = value;
            }
        }

        [XmlIgnore]
        public bool PublicDigitMapSpecified { get; set; }
        
        private string _privateDigitMap;

        [XmlElement(ElementName = "privateDigitMap", IsNullable = false, Namespace = "")]
        public string PrivateDigitMap {
            get => _privateDigitMap;
            set {
                PrivateDigitMapSpecified = true;
                _privateDigitMap = value;
            }
        }

        [XmlIgnore]
        public bool PrivateDigitMapSpecified { get; set; }
        
    }
}
