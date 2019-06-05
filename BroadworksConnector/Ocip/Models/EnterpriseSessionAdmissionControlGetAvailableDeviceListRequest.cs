using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseSessionAdmissionControlGetAvailableDeviceListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
    {
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
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
        public bool ServiceProviderIdSpecified { get; set; }
        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
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
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceName> _searchCriteriaDeviceName;

        [XmlElement(ElementName = "searchCriteriaDeviceName", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceName> SearchCriteriaDeviceName
        {
            get => _searchCriteriaDeviceName;
            set
            {
                SearchCriteriaDeviceNameSpecified = true;
                _searchCriteriaDeviceName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaDeviceNameSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceMACAddress> _searchCriteriaDeviceMACAddress;

        [XmlElement(ElementName = "searchCriteriaDeviceMACAddress", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceMACAddress> SearchCriteriaDeviceMACAddress
        {
            get => _searchCriteriaDeviceMACAddress;
            set
            {
                SearchCriteriaDeviceMACAddressSpecified = true;
                _searchCriteriaDeviceMACAddress = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaDeviceMACAddressSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceNetAddress> _searchCriteriaDeviceNetAddress;

        [XmlElement(ElementName = "searchCriteriaDeviceNetAddress", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceNetAddress> SearchCriteriaDeviceNetAddress
        {
            get => _searchCriteriaDeviceNetAddress;
            set
            {
                SearchCriteriaDeviceNetAddressSpecified = true;
                _searchCriteriaDeviceNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaDeviceNetAddressSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId;

        [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId
        {
            get => _searchCriteriaGroupId;
            set
            {
                SearchCriteriaGroupIdSpecified = true;
                _searchCriteriaGroupId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaGroupIdSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceType _searchCriteriaExactDeviceType;

        [XmlElement(ElementName = "searchCriteriaExactDeviceType", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceType SearchCriteriaExactDeviceType
        {
            get => _searchCriteriaExactDeviceType;
            set
            {
                SearchCriteriaExactDeviceTypeSpecified = true;
                _searchCriteriaExactDeviceType = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactDeviceTypeSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceLevel _searchCriteriaExactDeviceLevel;

        [XmlElement(ElementName = "searchCriteriaExactDeviceLevel", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceLevel SearchCriteriaExactDeviceLevel
        {
            get => _searchCriteriaExactDeviceLevel;
            set
            {
                SearchCriteriaExactDeviceLevelSpecified = true;
                _searchCriteriaExactDeviceLevel = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactDeviceLevelSpecified { get; set; }
    }
}
