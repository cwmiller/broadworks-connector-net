using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a list of home zones and/or home zone ranges to the group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""993492ea5726d0f3ec8743f5cef40e23:49""}]")]
    public class GroupEmergencyZonesAddHomeZoneListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"993492ea5726d0f3ec8743f5cef40e23:49")]
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

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"993492ea5726d0f3ec8743f5cef40e23:49")]
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

        protected List<string> _homeZoneIpAddress = new List<string>();

        [XmlElement(ElementName = "homeZoneIpAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"993492ea5726d0f3ec8743f5cef40e23:49")]
        [MinLength(1)]
        [MaxLength(39)]
        public List<string> HomeZoneIpAddress
        {
            get => _homeZoneIpAddress;
            set
            {
                HomeZoneIpAddressSpecified = true;
                _homeZoneIpAddress = value;
            }
        }

        [XmlIgnore]
        protected bool HomeZoneIpAddressSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.IPAddressRange> _homeZoneIpAddressRange = new List<BroadWorksConnector.Ocip.Models.IPAddressRange>();

        [XmlElement(ElementName = "homeZoneIpAddressRange", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"993492ea5726d0f3ec8743f5cef40e23:49")]
        public List<BroadWorksConnector.Ocip.Models.IPAddressRange> HomeZoneIpAddressRange
        {
            get => _homeZoneIpAddressRange;
            set
            {
                HomeZoneIpAddressRangeSpecified = true;
                _homeZoneIpAddressRange = value;
            }
        }

        [XmlIgnore]
        protected bool HomeZoneIpAddressRangeSpecified { get; set; }

    }
}
