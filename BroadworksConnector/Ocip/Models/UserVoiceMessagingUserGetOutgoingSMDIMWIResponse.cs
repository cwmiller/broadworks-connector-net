using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserVoiceMessagingUserGetOutgoingSMDIMWIRequest.
        /// <see cref="UserVoiceMessagingUserGetOutgoingSMDIMWIRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserVoiceMessagingUserGetOutgoingSMDIMWIResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        public bool IsActive {
            get => _isActive;
            set {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }
        
        private List<string> _outgoingSMDIMWIPhoneNumber;

        [XmlElement(ElementName = "outgoingSMDIMWIPhoneNumber", IsNullable = false, Namespace = "")]
        public List<string> OutgoingSMDIMWIPhoneNumber {
            get => _outgoingSMDIMWIPhoneNumber;
            set {
                OutgoingSMDIMWIPhoneNumberSpecified = true;
                _outgoingSMDIMWIPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool OutgoingSMDIMWIPhoneNumberSpecified { get; set; }
        
    }
}
