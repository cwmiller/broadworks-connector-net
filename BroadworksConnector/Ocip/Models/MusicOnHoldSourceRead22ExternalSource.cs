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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:2824""}]")]
    public class MusicOnHoldSourceRead22ExternalSource
    {

        private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead _accessDeviceEndpoint;

        [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:2824")]
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
