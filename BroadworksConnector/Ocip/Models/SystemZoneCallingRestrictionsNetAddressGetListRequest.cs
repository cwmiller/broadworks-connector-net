using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Gets a list of IP Addresses and/or Ranges assigned to a zone
    /// The response is SystemZoneCallingRestrictionsNetAddressGetListResponse.
    /// Replaced by: SystemZoneNetAddressGetListRequest
    /// <see cref="SystemZoneCallingRestrictionsNetAddressGetListResponse"/>
    /// <see cref="SystemZoneNetAddressGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:16642""}]")]
    public class SystemZoneCallingRestrictionsNetAddressGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _zoneName;

        [XmlElement(ElementName = "zoneName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16642")]
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

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16642")]
        [MinInclusive(1)]
        public int ResponseSizeLimit
        {
            get => _responseSizeLimit;
            set
            {
                ResponseSizeLimitSpecified = true;
                _responseSizeLimit = value;
            }
        }

        [XmlIgnore]
        public bool ResponseSizeLimitSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaZoneIPAddress> _searchCriteriaZoneIPAddress = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaZoneIPAddress>();

        [XmlElement(ElementName = "searchCriteriaZoneIPAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:16642")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaZoneIPAddress> SearchCriteriaZoneIPAddress
        {
            get => _searchCriteriaZoneIPAddress;
            set
            {
                SearchCriteriaZoneIPAddressSpecified = true;
                _searchCriteriaZoneIPAddress = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaZoneIPAddressSpecified { get; set; }

    }
}
