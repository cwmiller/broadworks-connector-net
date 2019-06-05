using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
        private BroadworksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl
        {
            get => _responsePagingControl;
            set
            {
                ResponsePagingControlSpecified = true;
                _responsePagingControl = value;
            }
        }

        [XmlIgnore]
        public bool ResponsePagingControlSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.SortByMobileDirectoryNumber _sortByMobileDirectoryNumber;

        [XmlElement(ElementName = "sortByMobileDirectoryNumber", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.SortByMobileDirectoryNumber SortByMobileDirectoryNumber
        {
            get => _sortByMobileDirectoryNumber;
            set
            {
                SortByMobileDirectoryNumberSpecified = true;
                _sortByMobileDirectoryNumber = value;
            }
        }

        [XmlIgnore]
        public bool SortByMobileDirectoryNumberSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaMobileSubscriberDirectoryNumber> _searchCriteriaMobileSubscriberDirectoryNumber;

        [XmlElement(ElementName = "searchCriteriaMobileSubscriberDirectoryNumber", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaMobileSubscriberDirectoryNumber> SearchCriteriaMobileSubscriberDirectoryNumber
        {
            get => _searchCriteriaMobileSubscriberDirectoryNumber;
            set
            {
                SearchCriteriaMobileSubscriberDirectoryNumberSpecified = true;
                _searchCriteriaMobileSubscriberDirectoryNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaMobileSubscriberDirectoryNumberSpecified { get; set; }
        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        public bool SearchCriteriaModeOr
        {
            get => _searchCriteriaModeOr;
            set
            {
                SearchCriteriaModeOrSpecified = true;
                _searchCriteriaModeOr = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaModeOrSpecified { get; set; }
    }
}
