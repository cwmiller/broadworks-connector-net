using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserVideoAddOnGetRequest19.
    /// <see cref="UserVideoAddOnGetRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:46929""}]")]
    public class UserVideoAddOnGetResponse19 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:46929")]
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

        private BroadWorksConnector.Ocip.Models.VideoAddOnMaxOriginatingCallDelaySeconds _maxOriginatingCallDelaySeconds;

        [XmlElement(ElementName = "maxOriginatingCallDelaySeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:46929")]
        public BroadWorksConnector.Ocip.Models.VideoAddOnMaxOriginatingCallDelaySeconds MaxOriginatingCallDelaySeconds
        {
            get => _maxOriginatingCallDelaySeconds;
            set
            {
                MaxOriginatingCallDelaySecondsSpecified = true;
                _maxOriginatingCallDelaySeconds = value;
            }
        }

        [XmlIgnore]
        protected bool MaxOriginatingCallDelaySecondsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:46929")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead AccessDeviceEndpoint
        {
            get => _accessDeviceEndpoint;
            set
            {
                AccessDeviceEndpointSpecified = true;
                _accessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceEndpointSpecified { get; set; }

    }
}
