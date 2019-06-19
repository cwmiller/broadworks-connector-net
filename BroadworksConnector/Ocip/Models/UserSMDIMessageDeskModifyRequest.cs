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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ee7bb69368e23a56a82c5d9cf07b5433:324""}]")]
    public class UserSMDIMessageDeskModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ee7bb69368e23a56a82c5d9cf07b5433:324")]
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
        public bool UserIdSpecified { get; set; }

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ee7bb69368e23a56a82c5d9cf07b5433:324")]
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

        private string _messageDeskNumber;

        [XmlElement(ElementName = "messageDeskNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ee7bb69368e23a56a82c5d9cf07b5433:324")]
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
        public bool MessageDeskNumberSpecified { get; set; }

    }
}
