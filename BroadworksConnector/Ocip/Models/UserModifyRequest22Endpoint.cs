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

    [Groups(@"[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:2572""}]")]
    public class UserModifyRequest22Endpoint
    {

        protected BroadWorksConnector.Ocip.Models.AccessDeviceMultipleIdentityAndContactEndpointModify22 _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2572")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceMultipleIdentityAndContactEndpointModify22 AccessDeviceEndpoint
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

        protected BroadWorksConnector.Ocip.Models.TrunkAddressingMultipleContactModify22 _trunkAddressing;

        [XmlElement(ElementName = "trunkAddressing", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:2572")]
        public BroadWorksConnector.Ocip.Models.TrunkAddressingMultipleContactModify22 TrunkAddressing
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
