using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of sip device types in the system.
    /// If includeSystemLevel is specified, all system level device types and the reseller device types matching search criteria
    /// are returned even when searchCriteriaResellerId is specified.
    /// If reseller administrator sends the request, searchCriteriaResellerId is ignored. All system level device
    /// types and the device types in the administrator's reseller meeting the search criteria are returned.
    /// See Also: SystemDeviceTypeGetAvailableListRequest22 in AS data mode, SystemDeviceTypeGetAvailableListRequest19 in XS data mode.
    /// The response is either SystemSIPDeviceTypeGetListResponse or ErrorResponse.
        /// <see cref="SystemDeviceTypeGetAvailableListRequest22"/>
        /// <see cref="SystemDeviceTypeGetAvailableListRequest19"/>
        /// <see cref="SystemSIPDeviceTypeGetListResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPDeviceTypeGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        public int ResponseSizeLimit {
            get => _responseSizeLimit;
            set {
                ResponseSizeLimitSpecified = true;
                _responseSizeLimit = value;
            }
        }

        [XmlIgnore]
        public bool ResponseSizeLimitSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceType> _searchCriteriaDeviceType;

        [XmlElement(ElementName = "searchCriteriaDeviceType", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceType> SearchCriteriaDeviceType {
            get => _searchCriteriaDeviceType;
            set {
                SearchCriteriaDeviceTypeSpecified = true;
                _searchCriteriaDeviceType = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaDeviceTypeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactSignalingAddressType _searchCriteriaExactSignalingAddressType;

        [XmlElement(ElementName = "searchCriteriaExactSignalingAddressType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactSignalingAddressType SearchCriteriaExactSignalingAddressType {
            get => _searchCriteriaExactSignalingAddressType;
            set {
                SearchCriteriaExactSignalingAddressTypeSpecified = true;
                _searchCriteriaExactSignalingAddressType = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactSignalingAddressTypeSpecified { get; set; }
        
        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> _searchCriteriaResellerId;

        [XmlElement(ElementName = "searchCriteriaResellerId", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaResellerId> SearchCriteriaResellerId {
            get => _searchCriteriaResellerId;
            set {
                SearchCriteriaResellerIdSpecified = true;
                _searchCriteriaResellerId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaResellerIdSpecified { get; set; }
        
        private bool _includeSystemLevel;

        [XmlElement(ElementName = "includeSystemLevel", IsNullable = false, Namespace = "")]
        public bool IncludeSystemLevel {
            get => _includeSystemLevel;
            set {
                IncludeSystemLevelSpecified = true;
                _includeSystemLevel = value;
            }
        }

        [XmlIgnore]
        public bool IncludeSystemLevelSpecified { get; set; }
        
    }
}
