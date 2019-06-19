using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of available announcement files for
    /// a Group.
    /// If the responsePagingControl element is not provided,
    /// the paging startIndex will be set to 1 by default,
    /// and the responsePageSize will be set to the maximum responsePageSize by
    /// default.
    /// If no sortOrder is included, the response is sorted by Name ascending by default.
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
    /// Then the search criteria are logically ORed together.
    /// The response is either a GroupAnnouncementFileGetPagedSortedListResponse or an
    /// ErrorResponse.
    /// <see cref="GroupAnnouncementFileGetPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:1486"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:1490"",""optional"":true}]}]")]
    public class GroupAnnouncementFileGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1486")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1486")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1486")]
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

        private BroadWorksConnector.Ocip.Models.SortByAnnouncementFileName _sortByAnnouncementFileName;

        [XmlElement(ElementName = "sortByAnnouncementFileName", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1490")]
        public BroadWorksConnector.Ocip.Models.SortByAnnouncementFileName SortByAnnouncementFileName
        {
            get => _sortByAnnouncementFileName;
            set
            {
                SortByAnnouncementFileNameSpecified = true;
                _sortByAnnouncementFileName = value;
            }
        }

        [XmlIgnore]
        public bool SortByAnnouncementFileNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SortByAnnouncementFileSize _sortByAnnouncementFileSize;

        [XmlElement(ElementName = "sortByAnnouncementFileSize", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1490")]
        public BroadWorksConnector.Ocip.Models.SortByAnnouncementFileSize SortByAnnouncementFileSize
        {
            get => _sortByAnnouncementFileSize;
            set
            {
                SortByAnnouncementFileSizeSpecified = true;
                _sortByAnnouncementFileSize = value;
            }
        }

        [XmlIgnore]
        public bool SortByAnnouncementFileSizeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaAnnouncementFileName> _searchCriteriaAnnouncementFileName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaAnnouncementFileName>();

        [XmlElement(ElementName = "searchCriteriaAnnouncementFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1486")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaAnnouncementFileName> SearchCriteriaAnnouncementFileName
        {
            get => _searchCriteriaAnnouncementFileName;
            set
            {
                SearchCriteriaAnnouncementFileNameSpecified = true;
                _searchCriteriaAnnouncementFileName = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaAnnouncementFileNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactAnnouncementFileType _searchCriteriaExactAnnouncementFileType;

        [XmlElement(ElementName = "searchCriteriaExactAnnouncementFileType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1486")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactAnnouncementFileType SearchCriteriaExactAnnouncementFileType
        {
            get => _searchCriteriaExactAnnouncementFileType;
            set
            {
                SearchCriteriaExactAnnouncementFileTypeSpecified = true;
                _searchCriteriaExactAnnouncementFileType = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactAnnouncementFileTypeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactMediaFileType> _searchCriteriaExactMediaFileType = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactMediaFileType>();

        [XmlElement(ElementName = "searchCriteriaExactMediaFileType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1486")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactMediaFileType> SearchCriteriaExactMediaFileType
        {
            get => _searchCriteriaExactMediaFileType;
            set
            {
                SearchCriteriaExactMediaFileTypeSpecified = true;
                _searchCriteriaExactMediaFileType = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactMediaFileTypeSpecified { get; set; }

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1486")]
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
