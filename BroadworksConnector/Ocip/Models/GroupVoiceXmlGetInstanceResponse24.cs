using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupVoiceXmlGetInstanceRequest24.
    /// Contains the service profile information and possibly access device information.
    /// <see cref="GroupVoiceXmlGetInstanceRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3e2fc6b9722da3741a8ba4a2c4a2d05:147""}]")]
    public class GroupVoiceXmlGetInstanceResponse24 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile24 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"f3e2fc6b9722da3741a8ba4a2c4a2d05:147")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile24 ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInstanceProfileSpecified { get; set; }

        protected string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3e2fc6b9722da3741a8ba4a2c4a2d05:147")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = (value != null);
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkClassOfServiceSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead22 _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3e2fc6b9722da3741a8ba4a2c4a2d05:147")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead22 AccessDeviceEndpoint
        {
            get => _accessDeviceEndpoint;
            set
            {
                AccessDeviceEndpointSpecified = (value != null);
                _accessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceEndpointSpecified { get; set; }

        protected bool _webexMeetingCallback;

        [XmlElement(ElementName = "webexMeetingCallback", IsNullable = false, Namespace = "")]
        [Group(@"f3e2fc6b9722da3741a8ba4a2c4a2d05:147")]
        public bool WebexMeetingCallback
        {
            get => _webexMeetingCallback;
            set
            {
                WebexMeetingCallbackSpecified = true;
                _webexMeetingCallback = value;
            }
        }

        [XmlIgnore]
        protected bool WebexMeetingCallbackSpecified { get; set; }

    }
}
