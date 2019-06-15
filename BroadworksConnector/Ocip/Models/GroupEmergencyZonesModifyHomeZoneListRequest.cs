using System;
using System.Xml.Serialization;
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
     
    public class GroupEmergencyZonesModifyHomeZoneListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressList> _homeZoneIpAddressList;

        [XmlElement(ElementName = "homeZoneIpAddressList", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressList> HomeZoneIpAddressList {
            get => _homeZoneIpAddressList;
            set {
                HomeZoneIpAddressListSpecified = true;
                _homeZoneIpAddressList = value;
            }
        }

        [XmlIgnore]
        public bool HomeZoneIpAddressListSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressRangeList> _homeZoneIpAddressRangeList;

        [XmlElement(ElementName = "homeZoneIpAddressRangeList", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.GroupEmergencyZonesModifyHomeZoneListRequestHomeZoneIpAddressRangeList> HomeZoneIpAddressRangeList {
            get => _homeZoneIpAddressRangeList;
            set {
                HomeZoneIpAddressRangeListSpecified = true;
                _homeZoneIpAddressRangeList = value;
            }
        }

        [XmlIgnore]
        public bool HomeZoneIpAddressRangeListSpecified { get; set; }
        
    }
}
