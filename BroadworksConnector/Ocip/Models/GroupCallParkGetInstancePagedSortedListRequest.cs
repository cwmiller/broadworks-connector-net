using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of Call Park group instances within a group.
    /// 
    /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
    /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
    /// It is possible to search by various criteria to restrict the number of rows returned.
    /// 
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
    /// Then the search criteria are logically ORed together.
    /// 
    /// The response is either GroupCallParkGetInstancePagedSortedListResponse or ErrorResponse.
    /// <see cref="GroupCallParkGetInstancePagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7a925e891158dfa3cb1319e045608894:326""}]")]
    public class GroupCallParkGetInstancePagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"7a925e891158dfa3cb1319e045608894:326")]
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
        [Group(@"7a925e891158dfa3cb1319e045608894:326")]
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

        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:326")]
        public BroadWorksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl
        {
            get => _responsePagingControl;
            set
            {
                ResponsePagingControlSpecified = true;
                _responsePagingControl = value;
            }
        }

        [XmlIgnore]
        protected bool ResponsePagingControlSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByCallParkName _sortByCallParkName;

        [XmlElement(ElementName = "sortByCallParkName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:326")]
        public BroadWorksConnector.Ocip.Models.SortByCallParkName SortByCallParkName
        {
            get => _sortByCallParkName;
            set
            {
                SortByCallParkNameSpecified = true;
                _sortByCallParkName = value;
            }
        }

        [XmlIgnore]
        protected bool SortByCallParkNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallParkName> _searchCriteriaCallParkName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallParkName>();

        [XmlElement(ElementName = "searchCriteriaCallParkName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:326")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallParkName> SearchCriteriaCallParkName
        {
            get => _searchCriteriaCallParkName;
            set
            {
                SearchCriteriaCallParkNameSpecified = true;
                _searchCriteriaCallParkName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaCallParkNameSpecified { get; set; }

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7a925e891158dfa3cb1319e045608894:326")]
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
        protected bool SearchCriteriaModeOrSpecified { get; set; }

    }
}
