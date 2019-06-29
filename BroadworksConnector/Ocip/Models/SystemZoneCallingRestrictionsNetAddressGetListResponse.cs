using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemZoneCallingRestrictionsNetAddressGetListRequest.
    /// Replaced by: SystemZoneNetAddressGetListResponse
    /// <see cref="SystemZoneCallingRestrictionsNetAddressGetListRequest"/>
    /// <see cref="SystemZoneNetAddressGetListResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:16661""}]")]
    public class SystemZoneCallingRestrictionsNetAddressGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _netAddress = new List<string>();

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16661")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16661")]
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
