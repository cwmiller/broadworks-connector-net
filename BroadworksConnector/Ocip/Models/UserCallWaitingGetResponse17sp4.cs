using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallWaitingGetRequest17sp4.
    /// 
    /// The following elements are only used in AS data mode:
    /// disableCallingLineIdDelivery
    /// <see cref="UserCallWaitingGetRequest17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""08ee5b5ec09321975436b908fd540e7f:108""}]")]
    public class UserCallWaitingGetResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"08ee5b5ec09321975436b908fd540e7f:108")]
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
        [Group(@"08ee5b5ec09321975436b908fd540e7f:108")]
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
