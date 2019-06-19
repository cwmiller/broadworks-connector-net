using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's Video Add-On service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a7ae3767516578250f020b627d8fe972:107""}]")]
    public class UserVideoAddOnModifyRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"a7ae3767516578250f020b627d8fe972:107")]
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
        [Group(@"a7ae3767516578250f020b627d8fe972:107")]
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

        private BroadWorksConnector.Ocip.Models.VideoAddOnMaxOriginatingCallDelaySeconds _maxOriginatingCallDelaySeconds;

        [XmlElement(ElementName = "maxOriginatingCallDelaySeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a7ae3767516578250f020b627d8fe972:107")]
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
        public bool MaxOriginatingCallDelaySecondsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointModify _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"a7ae3767516578250f020b627d8fe972:107")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointModify AccessDeviceEndpoint
        {
            get => _accessDeviceEndpoint;
            set
            {
                AccessDeviceEndpointSpecified = true;
                _accessDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceEndpointSpecified { get; set; }

    }
}
