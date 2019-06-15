using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the setting for executive assistant.
    /// The response is either SuccessResponse or ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserExecutiveAssistantModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private bool _enableDivert;

        [XmlElement(ElementName = "enableDivert", IsNullable = false, Namespace = "")]
        public bool EnableDivert {
            get => _enableDivert;
            set {
                EnableDivertSpecified = true;
                _enableDivert = value;
            }
        }

        [XmlIgnore]
        public bool EnableDivertSpecified { get; set; }
        
        private string _divertToPhoneNumber;

        [XmlElement(ElementName = "divertToPhoneNumber", IsNullable = true, Namespace = "")]
        public string DivertToPhoneNumber {
            get => _divertToPhoneNumber;
            set {
                DivertToPhoneNumberSpecified = true;
                _divertToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool DivertToPhoneNumberSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.ExecutiveAssistantOptInStatus> _optInStatus;

        [XmlElement(ElementName = "optInStatus", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.ExecutiveAssistantOptInStatus> OptInStatus {
            get => _optInStatus;
            set {
                OptInStatusSpecified = true;
                _optInStatus = value;
            }
        }

        [XmlIgnore]
        public bool OptInStatusSpecified { get; set; }
        
    }
}
