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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""08ee5b5ec09321975436b908fd540e7f:128""}]")]
    public class UserCallWaitingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"08ee5b5ec09321975436b908fd540e7f:128")]
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
        [Group(@"08ee5b5ec09321975436b908fd540e7f:128")]
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

        protected bool _disableCallingLineIdDelivery;

        [XmlElement(ElementName = "disableCallingLineIdDelivery", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"08ee5b5ec09321975436b908fd540e7f:128")]
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
        protected bool DisableCallingLineIdDeliverySpecified { get; set; }

    }
}
