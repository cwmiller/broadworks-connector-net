using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a list of Call Pickup instances within a group.
    /// 
    /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
    /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
    /// It is possible to search by various criteria to restrict the number of rows returned.
    /// 
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
    /// Then the search criteria are logically ORed together.
    /// 
    /// The response is either GroupCallPickupGetInstancePagedSortedListResponse or ErrorResponse.
    /// <see cref="GroupCallPickupGetInstancePagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""045ce951b3e25dec090606af4ad50c63:229""}]")]
    public class GroupCallPickupGetInstancePagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"045ce951b3e25dec090606af4ad50c63:229")]
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
        public bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"045ce951b3e25dec090606af4ad50c63:229")]
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
        public bool GroupIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"045ce951b3e25dec090606af4ad50c63:229")]
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
        public bool ResponsePagingControlSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByCallPickupName _sortByCallPickupName;

        [XmlElement(ElementName = "sortByCallPickupName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"045ce951b3e25dec090606af4ad50c63:229")]
        public BroadWorksConnector.Ocip.Models.SortByCallPickupName SortByCallPickupName
        {
            get => _sortByCallPickupName;
            set
            {
                SortByCallPickupNameSpecified = true;
                _sortByCallPickupName = value;
            }
        }

        [XmlIgnore]
        public bool SortByCallPickupNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallPickupName> _searchCriteriaCallPickupName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallPickupName>();

        [XmlElement(ElementName = "searchCriteriaCallPickupName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"045ce951b3e25dec090606af4ad50c63:229")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaCallPickupName> SearchCriteriaCallPickupName
        {
            get => _searchCriteriaCallPickupName;
            set
            {
                SearchCriteriaCallPickupNameSpecified = true;
                _searchCriteriaCallPickupName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaCallPickupNameSpecified { get; set; }

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"045ce951b3e25dec090606af4ad50c63:229")]
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
