using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:18404""}]")]
    public class UserModifyRequest21Endpoint
    {

        protected BroadWorksConnector.Ocip.Models.AccessDeviceMultipleIdentityAndContactEndpointModify _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18404")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceMultipleIdentityAndContactEndpointModify AccessDeviceEndpoint
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

        protected BroadWorksConnector.Ocip.Models.TrunkAddressingMultipleContactModify _trunkAddressing;

        [XmlElement(ElementName = "trunkAddressing", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:18404")]
        public BroadWorksConnector.Ocip.Models.TrunkAddressingMultipleContactModify TrunkAddressing
        {
            get => _trunkAddressing;
            set
            {
                TrunkAddressingSpecified = true;
                _trunkAddressing = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkAddressingSpecified { get; set; }

    }
}
