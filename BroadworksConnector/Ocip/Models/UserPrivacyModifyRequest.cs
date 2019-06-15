using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Privacy.
    /// This command is supported for regular users only.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserPrivacyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        public string UserId {
            get => _userId;
            set {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        public bool UserIdSpecified { get; set; }
        
        private bool _enableDirectoryPrivacy;

        [XmlElement(ElementName = "enableDirectoryPrivacy", IsNullable = false, Namespace = "")]
        public bool EnableDirectoryPrivacy {
            get => _enableDirectoryPrivacy;
            set {
                EnableDirectoryPrivacySpecified = true;
                _enableDirectoryPrivacy = value;
            }
        }

        [XmlIgnore]
        public bool EnableDirectoryPrivacySpecified { get; set; }
        
        private bool _enableAutoAttendantExtensionDialingPrivacy;

        [XmlElement(ElementName = "enableAutoAttendantExtensionDialingPrivacy", IsNullable = false, Namespace = "")]
        public bool EnableAutoAttendantExtensionDialingPrivacy {
            get => _enableAutoAttendantExtensionDialingPrivacy;
            set {
                EnableAutoAttendantExtensionDialingPrivacySpecified = true;
                _enableAutoAttendantExtensionDialingPrivacy = value;
            }
        }

        [XmlIgnore]
        public bool EnableAutoAttendantExtensionDialingPrivacySpecified { get; set; }
        
        private bool _enableAutoAttendantNameDialingPrivacy;

        [XmlElement(ElementName = "enableAutoAttendantNameDialingPrivacy", IsNullable = false, Namespace = "")]
        public bool EnableAutoAttendantNameDialingPrivacy {
            get => _enableAutoAttendantNameDialingPrivacy;
            set {
                EnableAutoAttendantNameDialingPrivacySpecified = true;
                _enableAutoAttendantNameDialingPrivacy = value;
            }
        }

        [XmlIgnore]
        public bool EnableAutoAttendantNameDialingPrivacySpecified { get; set; }
        
        private bool _enablePhoneStatusPrivacy;

        [XmlElement(ElementName = "enablePhoneStatusPrivacy", IsNullable = false, Namespace = "")]
        public bool EnablePhoneStatusPrivacy {
            get => _enablePhoneStatusPrivacy;
            set {
                EnablePhoneStatusPrivacySpecified = true;
                _enablePhoneStatusPrivacy = value;
            }
        }

        [XmlIgnore]
        public bool EnablePhoneStatusPrivacySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ReplacementUserIdList _permittedMonitorUserIdList;

        [XmlElement(ElementName = "permittedMonitorUserIdList", IsNullable = true, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList PermittedMonitorUserIdList {
            get => _permittedMonitorUserIdList;
            set {
                PermittedMonitorUserIdListSpecified = true;
                _permittedMonitorUserIdList = value;
            }
        }

        [XmlIgnore]
        public bool PermittedMonitorUserIdListSpecified { get; set; }
        
    }
}
