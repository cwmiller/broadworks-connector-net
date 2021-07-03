using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of available announcement files for a Group.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// groupExternalId
    /// 
    /// The response is either a GroupAnnouncementFileGetListResponse or an ErrorResponse.
    /// <see cref="GroupAnnouncementFileGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:1885"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:1886"",""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:1887""}]}]}]")]
    public class GroupAnnouncementFileGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1887")]
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
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1887")]
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

        private string _groupExternalId;

        [XmlElement(ElementName = "groupExternalId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1886")]
        [MaxLength(36)]
        public string GroupExternalId
        {
            get => _groupExternalId;
            set
            {
                GroupExternalIdSpecified = true;
                _groupExternalId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupExternalIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AnnouncementFileType _announcementFileType;

        [XmlElement(ElementName = "announcementFileType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1885")]
        public BroadWorksConnector.Ocip.Models.AnnouncementFileType AnnouncementFileType
        {
            get => _announcementFileType;
            set
            {
                AnnouncementFileTypeSpecified = true;
                _announcementFileType = value;
            }
        }

        [XmlIgnore]
        protected bool AnnouncementFileTypeSpecified { get; set; }

        private bool _includeAnnouncementTable;

        [XmlElement(ElementName = "includeAnnouncementTable", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1885")]
        public bool IncludeAnnouncementTable
        {
            get => _includeAnnouncementTable;
            set
            {
                IncludeAnnouncementTableSpecified = true;
                _includeAnnouncementTable = value;
            }
        }

        [XmlIgnore]
        protected bool IncludeAnnouncementTableSpecified { get; set; }

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1885")]
        [MinInclusive(1)]
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
        protected bool ResponseSizeLimitSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaAnnouncementFileName> _searchCriteriaAnnouncementFileName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaAnnouncementFileName>();

        [XmlElement(ElementName = "searchCriteriaAnnouncementFileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1885")]
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

    }
}
