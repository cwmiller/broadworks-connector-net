using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of available users for BroadWorks Receptionist - Enterprise monitoring.
    /// The response is either UserBroadWorksReceptionistEnterpriseGetAvailableUserListResponse or ErrorResponse.
    /// The Receptionist Note column is only populated, if the user sending the request is the owner of the
    /// Receptionist Note and a Note exists.
    /// <see cref="UserBroadWorksReceptionistEnterpriseGetAvailableUserListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""fb12998f4f9e45cedde01f08569f4c7c:133""}]")]
    public class UserBroadWorksReceptionistEnterpriseGetAvailableUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:133")]
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

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:133")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName>();

        [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:133")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> SearchCriteriaUserLastName
        {
            get => _searchCriteriaUserLastName;
            set
            {
                SearchCriteriaUserLastNameSpecified = true;
                _searchCriteriaUserLastName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserLastNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> _searchCriteriaUserFirstName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName>();

        [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:133")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> SearchCriteriaUserFirstName
        {
            get => _searchCriteriaUserFirstName;
            set
            {
                SearchCriteriaUserFirstNameSpecified = true;
                _searchCriteriaUserFirstName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserFirstNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment _searchCriteriaExactUserDepartment;

        [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:133")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment SearchCriteriaExactUserDepartment
        {
            get => _searchCriteriaExactUserDepartment;
            set
            {
                SearchCriteriaExactUserDepartmentSpecified = true;
                _searchCriteriaExactUserDepartment = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactUserDepartmentSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup _searchCriteriaExactUserGroup;

        [XmlElement(ElementName = "searchCriteriaExactUserGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:133")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup SearchCriteriaExactUserGroup
        {
            get => _searchCriteriaExactUserGroup;
            set
            {
                SearchCriteriaExactUserGroupSpecified = true;
                _searchCriteriaExactUserGroup = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactUserGroupSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId>();

        [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:133")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId
        {
            get => _searchCriteriaUserId;
            set
            {
                SearchCriteriaUserIdSpecified = true;
                _searchCriteriaUserId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaUserIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn>();

        [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:133")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn
        {
            get => _searchCriteriaDn;
            set
            {
                SearchCriteriaDnSpecified = true;
                _searchCriteriaDn = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDnSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension>();

        [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:133")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension
        {
            get => _searchCriteriaExtension;
            set
            {
                SearchCriteriaExtensionSpecified = true;
                _searchCriteriaExtension = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExtensionSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaImpId> _searchCriteriaImpId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaImpId>();

        [XmlElement(ElementName = "searchCriteriaImpId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:133")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaImpId> SearchCriteriaImpId
        {
            get => _searchCriteriaImpId;
            set
            {
                SearchCriteriaImpIdSpecified = true;
                _searchCriteriaImpId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaImpIdSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaReceptionistNote> _searchCriteriaReceptionistNote = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaReceptionistNote>();

        [XmlElement(ElementName = "searchCriteriaReceptionistNote", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"fb12998f4f9e45cedde01f08569f4c7c:133")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaReceptionistNote> SearchCriteriaReceptionistNote
        {
            get => _searchCriteriaReceptionistNote;
            set
            {
                SearchCriteriaReceptionistNoteSpecified = true;
                _searchCriteriaReceptionistNote = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaReceptionistNoteSpecified { get; set; }

    }
}
