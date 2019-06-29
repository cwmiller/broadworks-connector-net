using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This is the configuration parameters for Call Transfer service
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:4168""}]")]
    public class ProfileAndServiceCallWaitingInfo
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4168")]
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
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:4168")]
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
