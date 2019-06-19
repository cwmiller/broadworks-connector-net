using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Call Waiting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode:
    /// disableCallingLineIdDelivery
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e12337fe0480db757507a0699bc195d9:128""}]")]
    public class UserCallWaitingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"e12337fe0480db757507a0699bc195d9:128")]
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
        [Group(@"e12337fe0480db757507a0699bc195d9:128")]
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

        private bool _disableCallingLineIdDelivery;

        [XmlElement(ElementName = "disableCallingLineIdDelivery", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e12337fe0480db757507a0699bc195d9:128")]
        public bool DisableCallingLineIdDelivery
        {
            get => _disableCallingLineIdDelivery;
            set
            {
                DisableCallingLineIdDeliverySpecified = true;
                _disableCallingLineIdDelivery = value;
            }
        }

        [XmlIgnore]
        public bool DisableCallingLineIdDeliverySpecified { get; set; }

    }
}
