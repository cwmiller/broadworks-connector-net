using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's voice messaging outgoing message waiting indicator service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:2059""}]")]
    public class UserVoiceMessagingUserModifyOutgoingSMDIMWIRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2059")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2059")]
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

        protected BroadWorksConnector.Ocip.Models.ReplacementOutgoingDNList _outgoingSMDIMWIPhoneNumberList;

        [XmlElement(ElementName = "outgoingSMDIMWIPhoneNumberList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2059")]
        public BroadWorksConnector.Ocip.Models.ReplacementOutgoingDNList OutgoingSMDIMWIPhoneNumberList
        {
            get => _outgoingSMDIMWIPhoneNumberList;
            set
            {
                OutgoingSMDIMWIPhoneNumberListSpecified = true;
                _outgoingSMDIMWIPhoneNumberList = value;
            }
        }

        [XmlIgnore]
        protected bool OutgoingSMDIMWIPhoneNumberListSpecified { get; set; }

    }
}
