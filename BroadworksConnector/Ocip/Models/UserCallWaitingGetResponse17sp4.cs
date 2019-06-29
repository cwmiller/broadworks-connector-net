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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e12337fe0480db757507a0699bc195d9:108""}]")]
    public class UserCallWaitingGetResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"e12337fe0480db757507a0699bc195d9:108")]
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

        private bool _disableCallingLineIdDelivery;

        [XmlElement(ElementName = "disableCallingLineIdDelivery", IsNullable = false, Namespace = "")]
        [Group(@"e12337fe0480db757507a0699bc195d9:108")]
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
