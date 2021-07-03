using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk group endpoint that can have multiple contacts.
    /// Replaced by: TrunkAddressingMultipleContactRead21
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:49439""}]")]
    public class TrunkAddressingMultipleContactRead
    {

        private BroadWorksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointRead _trunkGroupDeviceEndpoint;

        [XmlElement(ElementName = "trunkGroupDeviceEndpoint", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:49439")]
        public BroadWorksConnector.Ocip.Models.TrunkGroupDeviceMultipleContactEndpointRead TrunkGroupDeviceEndpoint
        {
            get => _trunkGroupDeviceEndpoint;
            set
            {
                TrunkGroupDeviceEndpointSpecified = true;
                _trunkGroupDeviceEndpoint = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupDeviceEndpointSpecified { get; set; }

        private string _enterpriseTrunkName;

        [XmlElement(ElementName = "enterpriseTrunkName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:49439")]
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
        protected bool EnterpriseTrunkNameSpecified { get; set; }

        private string _alternateTrunkIdentity;

        [XmlElement(ElementName = "alternateTrunkIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:49439")]
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
        protected bool AlternateTrunkIdentitySpecified { get; set; }

    }
}
