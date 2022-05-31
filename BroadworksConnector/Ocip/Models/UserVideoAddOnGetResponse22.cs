using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserVideoAddOnGetRequest22.
    /// <see cref="UserVideoAddOnGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a7ae3767516578250f020b627d8fe972:57""}]")]
    public class UserVideoAddOnGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"a7ae3767516578250f020b627d8fe972:57")]
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

        protected BroadWorksConnector.Ocip.Models.VideoAddOnMaxOriginatingCallDelaySeconds _maxOriginatingCallDelaySeconds;

        [XmlElement(ElementName = "maxOriginatingCallDelaySeconds", IsNullable = false, Namespace = "")]
        [Group(@"a7ae3767516578250f020b627d8fe972:57")]
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

        protected BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead22 _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a7ae3767516578250f020b627d8fe972:57")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead22 AccessDeviceEndpoint
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
