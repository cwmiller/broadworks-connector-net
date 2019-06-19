using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk group endpoint.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:4117""}]")]
    public class TrunkAddressingModify
    {

        private BroadWorksConnector.Ocip.Models.TrunkGroupDeviceEndpointModify _trunkGroupDeviceEndpoint;

        [XmlElement(ElementName = "trunkGroupDeviceEndpoint", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4117")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupDeviceEndpointModify TrunkGroupDeviceEndpoint
        {
            get => _trunkGroupDeviceEndpoint;
            set
            {
                TrunkGroupDeviceEndpointSpecified = true;
                _trunkGroupDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupDeviceEndpointSpecified { get; set; }

        private string _enterpriseTrunkName;

        [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4117")]
        [MinLength(1)]
        [MaxLength(30)]
        public string EnterpriseTrunkName
        {
            get => _enterpriseTrunkName;
            set
            {
                EnterpriseTrunkNameSpecified = true;
                _enterpriseTrunkName = value;
            }
        }

        [XmlIgnore]
        public bool EnterpriseTrunkNameSpecified { get; set; }

        private string _alternateTrunkIdentity;

        [XmlElement(ElementName = "alternateTrunkIdentity", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:4117")]
        [MinLength(1)]
        [MaxLength(80)]
        public string AlternateTrunkIdentity
        {
            get => _alternateTrunkIdentity;
            set
            {
                AlternateTrunkIdentitySpecified = true;
                _alternateTrunkIdentity = value;
            }
        }

        [XmlIgnore]
        public bool AlternateTrunkIdentitySpecified { get; set; }

    }
}
