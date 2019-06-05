using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupCallCenterCurrentAndPastCallCenterGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
        private bool _isPremiumOnly;

        [XmlElement(ElementName = "isPremiumOnly", IsNullable = false, Namespace = "")]
        public bool IsPremiumOnly
        {
            get => _isPremiumOnly;
            set
            {
                IsPremiumOnlySpecified = true;
                _isPremiumOnly = value;
            }
        }

        [XmlIgnore]
        public bool IsPremiumOnlySpecified { get; set; }
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
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
        public bool GroupIdSpecified { get; set; }
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
        private BroadworksConnector.Ocip.Models.SearchCriteriaCallCenterName _searchCriteriaCallCenterName;

        [XmlElement(ElementName = "searchCriteriaCallCenterName", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.SearchCriteriaCallCenterName SearchCriteriaCallCenterName
        {
            get => _searchCriteriaCallCenterName;
            set
            {
                SearchCriteriaCallCenterNameSpecified = true;
                _searchCriteriaCallCenterName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaCallCenterNameSpecified { get; set; }
    }
}
