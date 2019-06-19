using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserVoiceMessagingUserGetOutgoingSMDIMWIRequest.
    /// <see cref="UserVoiceMessagingUserGetOutgoingSMDIMWIRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1871""}]")]
    public class UserVoiceMessagingUserGetOutgoingSMDIMWIResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1871")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        public bool IsActiveSpecified { get; set; }

        private List<string> _outgoingSMDIMWIPhoneNumber = new List<string>();

        [XmlElement(ElementName = "outgoingSMDIMWIPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1871")]
        [MinLength(1)]
        [MaxLength(30)]
        public List<string> OutgoingSMDIMWIPhoneNumber
        {
            get => _outgoingSMDIMWIPhoneNumber;
            set
            {
                OutgoingSMDIMWIPhoneNumberSpecified = true;
                _outgoingSMDIMWIPhoneNumber = value;
            }
        }

        [XmlIgnore]
        public bool OutgoingSMDIMWIPhoneNumberSpecified { get; set; }

    }
}
