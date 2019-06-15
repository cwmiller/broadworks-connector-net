using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserPersonalAssistantGetRequest.
    /// The response contains the user Personal Assistant information".
    /// 
    /// Replaced by: UserPersonalAssistantGetResponse22
        /// <see cref="UserPersonalAssistantGetRequest"/>
        /// <see cref="UserPersonalAssistantGetResponse22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserPersonalAssistantGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.PersonalAssistantPresence _presence;

        [XmlElement(ElementName = "presence", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.PersonalAssistantPresence Presence {
            get => _presence;
            set {
                PresenceSpecified = true;
                _presence = value;
            }
        }

        [XmlIgnore]
        public bool PresenceSpecified { get; set; }
        
        private bool _enableTransferToAttendant;

        [XmlElement(ElementName = "enableTransferToAttendant", IsNullable = false, Namespace = "")]
        public bool EnableTransferToAttendant {
            get => _enableTransferToAttendant;
            set {
                EnableTransferToAttendantSpecified = true;
                _enableTransferToAttendant = value;
            }
        }

        [XmlIgnore]
        public bool EnableTransferToAttendantSpecified { get; set; }
        
        private string _attendantNumber;

        [XmlElement(ElementName = "attendantNumber", IsNullable = false, Namespace = "")]
        public string AttendantNumber {
            get => _attendantNumber;
            set {
                AttendantNumberSpecified = true;
                _attendantNumber = value;
            }
        }

        [XmlIgnore]
        public bool AttendantNumberSpecified { get; set; }
        
        private bool _enableRingSplash;

        [XmlElement(ElementName = "enableRingSplash", IsNullable = false, Namespace = "")]
        public bool EnableRingSplash {
            get => _enableRingSplash;
            set {
                EnableRingSplashSpecified = true;
                _enableRingSplash = value;
            }
        }

        [XmlIgnore]
        public bool EnableRingSplashSpecified { get; set; }
        
        private bool _enableExpirationTime;

        [XmlElement(ElementName = "enableExpirationTime", IsNullable = false, Namespace = "")]
        public bool EnableExpirationTime {
            get => _enableExpirationTime;
            set {
                EnableExpirationTimeSpecified = true;
                _enableExpirationTime = value;
            }
        }

        [XmlIgnore]
        public bool EnableExpirationTimeSpecified { get; set; }
        
        private string _expirationTime;

        [XmlElement(ElementName = "expirationTime", IsNullable = false, Namespace = "")]
        public string ExpirationTime {
            get => _expirationTime;
            set {
                ExpirationTimeSpecified = true;
                _expirationTime = value;
            }
        }

        [XmlIgnore]
        public bool ExpirationTimeSpecified { get; set; }
        
    }
}
