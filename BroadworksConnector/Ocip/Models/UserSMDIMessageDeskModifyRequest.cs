using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's SMDI Message Desk service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""aa3a240fa755015613cfb9259eccafef:324""}]")]
    public class UserSMDIMessageDeskModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"aa3a240fa755015613cfb9259eccafef:324")]
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
        [Group(@"aa3a240fa755015613cfb9259eccafef:324")]
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

        protected string _messageDeskNumber;

        [XmlElement(ElementName = "messageDeskNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"aa3a240fa755015613cfb9259eccafef:324")]
        [MinLength(1)]
        [MaxLength(3)]
        public string MessageDeskNumber
        {
            get => _messageDeskNumber;
            set
            {
                MessageDeskNumberSpecified = true;
                _messageDeskNumber = value;
            }
        }

        [XmlIgnore]
        protected bool MessageDeskNumberSpecified { get; set; }

    }
}
