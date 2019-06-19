using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Deletes a list of IP addresses from a zone
    /// The response is SuccessResponse or an ErrorResponse.
    /// Replaced by: SystemZoneNetAddressDeleteListRequest
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemZoneNetAddressDeleteListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:16623""}]")]
    public class SystemZoneCallingRestrictionsNetAddressDeleteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _zoneName;

        [XmlElement(ElementName = "zoneName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16623")]
        [MinLength(1)]
        [MaxLength(80)]
        public string ZoneName
        {
            get => _zoneName;
            set
            {
                ZoneNameSpecified = true;
                _zoneName = value;
            }
        }

        [XmlIgnore]
        public bool ZoneNameSpecified { get; set; }

        private List<string> _netAddress = new List<string>();

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16623")]
        [MinLength(1)]
        [MaxLength(39)]
        public List<string> NetAddress
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

        private List<BroadWorksConnector.Ocip.Models.IPAddressRange> _netAddressRange = new List<BroadWorksConnector.Ocip.Models.IPAddressRange>();

        [XmlElement(ElementName = "netAddressRange", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16623")]
        public List<BroadWorksConnector.Ocip.Models.IPAddressRange> NetAddressRange
        {
            get => _netAddressRange;
            set
            {
                NetAddressRangeSpecified = true;
                _netAddressRange = value;
            }
        }

        [XmlIgnore]
        public bool NetAddressRangeSpecified { get; set; }

    }
}
