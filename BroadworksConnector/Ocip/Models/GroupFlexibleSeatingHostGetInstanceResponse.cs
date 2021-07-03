using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupFlexibleSeatingHostGetInstanceRequest.
    /// Contains the service profile and access device information.
    /// <see cref="GroupFlexibleSeatingHostGetInstanceRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:9907""}]")]
    public class GroupFlexibleSeatingHostGetInstanceResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9907")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile
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

        private string _defaultAlias;

        [XmlElement(ElementName = "defaultAlias", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9907")]
        [MinLength(1)]
        [MaxLength(161)]
        public string DefaultAlias
        {
            get => _defaultAlias;
            set
            {
                DefaultAliasSpecified = true;
                _defaultAlias = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultAliasSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AccessDeviceMultipleContactEndpointRead20 _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9907")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceMultipleContactEndpointRead20 AccessDeviceEndpoint
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

        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:9907")]
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
        protected bool NetworkClassOfServiceSpecified { get; set; }

    }
}
