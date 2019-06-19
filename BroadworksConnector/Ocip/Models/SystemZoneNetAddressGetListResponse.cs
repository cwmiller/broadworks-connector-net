using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemZoneNetAddressGetListRequest.
    /// <see cref="SystemZoneNetAddressGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18438""}]")]
    public class SystemZoneNetAddressGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _netAddress = new List<string>();

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18438")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18438")]
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
