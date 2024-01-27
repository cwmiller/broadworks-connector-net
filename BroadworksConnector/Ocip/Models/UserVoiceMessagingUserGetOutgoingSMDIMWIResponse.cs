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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:1878""}]")]
    public class UserVoiceMessagingUserGetOutgoingSMDIMWIResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1878")]
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
        protected bool IsActiveSpecified { get; set; }

        protected List<string> _outgoingSMDIMWIPhoneNumber = new List<string>();

        [XmlElement(ElementName = "outgoingSMDIMWIPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:1878")]
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
        protected bool OutgoingSMDIMWIPhoneNumberSpecified { get; set; }

    }
}
