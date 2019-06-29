using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a list of home zones and/or home zone ranges.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e71c2205fb31894f87810b330a85ede2:155""}]")]
    public class GroupEmergencyZonesModifyHomeZoneListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"e71c2205fb31894f87810b330a85ede2:155")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"e71c2205fb31894f87810b330a85ede2:155")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressList> _homeZoneIpAddressList = new List<BroadWorksConnector.Ocip.Models.GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressList>();

        [XmlElement(ElementName = "homeZoneIpAddressList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e71c2205fb31894f87810b330a85ede2:155")]
        public List<BroadWorksConnector.Ocip.Models.GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressList> HomeZoneIpAddressList
        {
            get => _homeZoneIpAddressList;
            set
            {
                HomeZoneIpAddressListSpecified = true;
                _homeZoneIpAddressList = value;
            }
        }

        [XmlIgnore]
        protected bool HomeZoneIpAddressListSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressRangeList> _homeZoneIpAddressRangeList = new List<BroadWorksConnector.Ocip.Models.GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressRangeList>();

        [XmlElement(ElementName = "homeZoneIpAddressRangeList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e71c2205fb31894f87810b330a85ede2:155")]
        public List<BroadWorksConnector.Ocip.Models.GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressRangeList> HomeZoneIpAddressRangeList
        {
            get => _homeZoneIpAddressRangeList;
            set
            {
                HomeZoneIpAddressRangeListSpecified = true;
                _homeZoneIpAddressRangeList = value;
            }
        }

        [XmlIgnore]
        protected bool HomeZoneIpAddressRangeListSpecified { get; set; }

    }
}
