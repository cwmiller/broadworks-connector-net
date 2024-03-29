using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Gets a list of IP Addresses and/or Ranges assigned to a zone
    /// The response is either a SystemZoneCallingRestrictionsNetAddressGetListResponse or ErrorResponse
    /// Replaced by: SystemZoneNetAddressGetListRequest
    /// <see cref="SystemZoneCallingRestrictionsNetAddressGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemZoneNetAddressGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:39923""}]")]
    public class SystemZoneCallingRestrictionsNetAddressGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemZoneCallingRestrictionsNetAddressGetListResponse>
    {

        protected string _zoneName;

        [XmlElement(ElementName = "zoneName", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:39923")]
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

        protected int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39923")]
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
        protected bool ResponseSizeLimitSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaZoneIPAddress> _searchCriteriaZoneIPAddress = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaZoneIPAddress>();

        [XmlElement(ElementName = "searchCriteriaZoneIPAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39923")]
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
        protected bool SearchCriteriaZoneIPAddressSpecified { get; set; }

    }
}
