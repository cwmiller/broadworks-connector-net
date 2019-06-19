using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a Network Server in the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// becomePreferred
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// order
    /// Replaced by SystemNetworkSynchingServerModifyRequest22
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemNetworkSynchingServerModifyRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:5317""}]")]
    public class SystemNetworkSynchingServerModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5317")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NetAddress
        {
            get => _netAddress;
            set
            {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        public bool NetAddressSpecified { get; set; }

        private int? _port;

        [XmlElement(ElementName = "port", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5317")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int? Port
        {
            get => _port;
            set
            {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        public bool PortSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5317")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }

        private bool _becomePreferred;

        [XmlElement(ElementName = "becomePreferred", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5317")]
        public bool BecomePreferred
        {
            get => _becomePreferred;
            set
            {
                BecomePreferredSpecified = true;
                _becomePreferred = value;
            }
        }

        [XmlIgnore]
        public bool BecomePreferredSpecified { get; set; }

        private int _order;

        [XmlElement(ElementName = "order", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5317")]
        [MinInclusive(1)]
        [MaxInclusive(32767)]
        public int Order
        {
            get => _order;
            set
            {
                OrderSpecified = true;
                _order = value;
            }
        }

        [XmlIgnore]
        public bool OrderSpecified { get; set; }

    }
}
