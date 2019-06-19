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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:44749""}]")]
    public class MusicOnHoldSourceRead19ExternalSource
    {

        private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44749")]
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
        public bool AccessDeviceEndpointSpecified { get; set; }

    }
}
