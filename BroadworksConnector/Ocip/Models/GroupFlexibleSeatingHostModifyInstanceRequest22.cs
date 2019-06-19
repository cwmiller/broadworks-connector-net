using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a flexible seating host instance.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""43afb2158d313a1d1a148124d7caba1e:370""}]")]
    public class GroupFlexibleSeatingHostModifyInstanceRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:370")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfileFlexibleSeatingHost _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:370")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfileFlexibleSeatingHost ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInstanceProfileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDeviceMultipleContactEndpointModify22 _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:370")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceMultipleContactEndpointModify22 AccessDeviceEndpoint
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

        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"43afb2158d313a1d1a148124d7caba1e:370")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        public bool NetworkClassOfServiceSpecified { get; set; }

    }
}
