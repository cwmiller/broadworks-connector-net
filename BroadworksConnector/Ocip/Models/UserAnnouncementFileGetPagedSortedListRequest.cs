using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of announcement files for a user.
    /// If the responsePagingControl element is not provided,
    /// the paging startIndex will be set to 1 by default,
    /// and the responsePageSize will be set to the maximum responsePageSize by
    /// default.
    /// If no sortOrder is provided, the response is sorted by Name ascending by default.
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
    /// Then the search criteria are logically ORed together.
    /// The response is either a UserAnnouncementFileGetPagedSortedListResponse or an ErrorResponse.
    /// <see cref="UserAnnouncementFileGetPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:651"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""fb73488c2ef4ac4400ab213b637d79a9:654"",""optional"":true}]}]")]
    public class UserAnnouncementFileGetPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.UserAnnouncementFileGetPagedSortedListResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:651")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:651")]
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

        protected BroadWorksConnector.Ocip.Models.SortByAnnouncementFileName _sortByAnnouncementFileName;

        [XmlElement(ElementName = "sortByAnnouncementFileName", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:654")]
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
        protected bool SortByAnnouncementFileNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SortByAnnouncementFileSize _sortByAnnouncementFileSize;

        [XmlElement(ElementName = "sortByAnnouncementFileSize", IsNullable = false, Namespace = "")]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:654")]
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
        protected bool SortByAnnouncementFileSizeSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaAnnouncementFileName> _searchCriteriaAnnouncementFileName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaAnnouncementFileName>();

        [XmlElement(ElementName = "searchCriteriaAnnouncementFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:651")]
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
        protected bool SearchCriteriaAnnouncementFileNameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactAnnouncementFileType _searchCriteriaExactAnnouncementFileType;

        [XmlElement(ElementName = "searchCriteriaExactAnnouncementFileType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:651")]
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
        protected bool SearchCriteriaExactAnnouncementFileTypeSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactMediaFileType> _searchCriteriaExactMediaFileType = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactMediaFileType>();

        [XmlElement(ElementName = "searchCriteriaExactMediaFileType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:651")]
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
        protected bool SearchCriteriaExactMediaFileTypeSpecified { get; set; }

        protected bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb73488c2ef4ac4400ab213b637d79a9:651")]
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
