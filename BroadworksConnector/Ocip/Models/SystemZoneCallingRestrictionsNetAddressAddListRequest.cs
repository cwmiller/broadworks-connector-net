using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Adds a list of IP addresses to a zone
    /// The response is SuccessResponse or an ErrorResponse.
    /// Replaced by: SystemZoneNetAddressAddListRequest
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemZoneNetAddressAddListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:39128""}]")]
    public class SystemZoneCallingRestrictionsNetAddressAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _zoneName;

        [XmlElement(ElementName = "zoneName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39128")]
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
        protected bool ZoneNameSpecified { get; set; }

        private List<string> _netAddress = new List<string>();

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39128")]
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
        protected bool NetAddressSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.IPAddressRange> _netAddressRange = new List<BroadWorksConnector.Ocip.Models.IPAddressRange>();

        [XmlElement(ElementName = "netAddressRange", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:39128")]
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
        protected bool NetAddressRangeSpecified { get; set; }

    }
}
