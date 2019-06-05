using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupAdminGetPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
        private List<BroadworksConnector.Ocip.Models.SortOrderGroupAdminGetPagedSortedList> _sortOrder;

        [XmlElement(ElementName = "sortOrder", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SortOrderGroupAdminGetPagedSortedList> SortOrder
        {
            get => _sortOrder;
            set
            {
                SortOrderSpecified = true;
                _sortOrder = value;
            }
        }

        [XmlIgnore]
        public bool SortOrderSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaAdminId> _searchCriteriaAdminId;

        [XmlElement(ElementName = "searchCriteriaAdminId", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaAdminId> SearchCriteriaAdminId
        {
            get => _searchCriteriaAdminId;
            set
            {
                SearchCriteriaAdminIdSpecified = true;
                _searchCriteriaAdminId = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaAdminIdSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaAdminLastName> _searchCriteriaAdminLastName;

        [XmlElement(ElementName = "searchCriteriaAdminLastName", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaAdminLastName> SearchCriteriaAdminLastName
        {
            get => _searchCriteriaAdminLastName;
            set
            {
                SearchCriteriaAdminLastNameSpecified = true;
                _searchCriteriaAdminLastName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaAdminLastNameSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaAdminFirstName> _searchCriteriaAdminFirstName;

        [XmlElement(ElementName = "searchCriteriaAdminFirstName", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaAdminFirstName> SearchCriteriaAdminFirstName
        {
            get => _searchCriteriaAdminFirstName;
            set
            {
                SearchCriteriaAdminFirstNameSpecified = true;
                _searchCriteriaAdminFirstName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaAdminFirstNameSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaExactGroupAdminType> _searchCriteriaExactGroupAdminType;

        [XmlElement(ElementName = "searchCriteriaExactGroupAdminType", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaExactGroupAdminType> SearchCriteriaExactGroupAdminType
        {
            get => _searchCriteriaExactGroupAdminType;
            set
            {
                SearchCriteriaExactGroupAdminTypeSpecified = true;
                _searchCriteriaExactGroupAdminType = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactGroupAdminTypeSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaLanguage> _searchCriteriaLanguage;

        [XmlElement(ElementName = "searchCriteriaLanguage", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaLanguage> SearchCriteriaLanguage
        {
            get => _searchCriteriaLanguage;
            set
            {
                SearchCriteriaLanguageSpecified = true;
                _searchCriteriaLanguage = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaLanguageSpecified { get; set; }
        private List<BroadworksConnector.Ocip.Models.SearchCriteriaDepartmentName> _searchCriteriaDepartmentName;

        [XmlElement(ElementName = "searchCriteriaDepartmentName", IsNullable = false, Namespace = "")]
        public List<BroadworksConnector.Ocip.Models.SearchCriteriaDepartmentName> SearchCriteriaDepartmentName
        {
            get => _searchCriteriaDepartmentName;
            set
            {
                SearchCriteriaDepartmentNameSpecified = true;
                _searchCriteriaDepartmentName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaDepartmentNameSpecified { get; set; }
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
