using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get a list of agents assigned to a call center.
    /// 
    /// If the responsePagingControl element is not provided, the paging startIndex will be set to 1
    /// by default, and the responsePageSize will be set to the maximum ResponsePageSize by default.
    /// It is possible to search by various criteria to restrict the number of rows returned.
    /// 
    /// Multiple search criteria are logically ANDed together unless the searchCriteriaModeOr option is included.
    /// Then the search criteria are logically ORed together.
    /// 
    /// ErrorResponse is returned if searchCriteriaExactUserGroup or searchCriteriaExactSkillLevel have multiple entries and searchCriteriaModeOr is not included.
    /// 
    /// Sorting is done on either a priority basis or a skill basis depending on the type of call center.
    /// 
    /// The response is either a GroupCallCenterGetAgentPagedSortedListResponse or an ErrorResponse.
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupCallCenterGetAgentPagedSortedListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:4029""}]")]
    public class GroupCallCenterGetAgentPagedSortedListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4029")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

        [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4029")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId>();

        [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4029")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName>();

        [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4029")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4029")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn>();

        [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4029")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4029")]
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

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName> _searchCriteriaDepartmentName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName>();

        [XmlElement(ElementName = "searchCriteriaDepartmentName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4029")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDepartmentName> SearchCriteriaDepartmentName
        {
            get => _searchCriteriaDepartmentName;
            set
            {
                SearchCriteriaDepartmentNameSpecified = true;
                _searchCriteriaDepartmentName = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaDepartmentNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaEmailAddress> _searchCriteriaEmailAddress = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaEmailAddress>();

        [XmlElement(ElementName = "searchCriteriaEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4029")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaEmailAddress> SearchCriteriaEmailAddress
        {
            get => _searchCriteriaEmailAddress;
            set
            {
                SearchCriteriaEmailAddressSpecified = true;
                _searchCriteriaEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaEmailAddressSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactSkillLevel> _searchCriteriaExactSkillLevel = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactSkillLevel>();

        [XmlElement(ElementName = "searchCriteriaExactSkillLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4029")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactSkillLevel> SearchCriteriaExactSkillLevel
        {
            get => _searchCriteriaExactSkillLevel;
            set
            {
                SearchCriteriaExactSkillLevelSpecified = true;
                _searchCriteriaExactSkillLevel = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaExactSkillLevelSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup> _searchCriteriaExactUserGroup = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup>();

        [XmlElement(ElementName = "searchCriteriaExactUserGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4029")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserGroup> SearchCriteriaExactUserGroup
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

        private bool _searchCriteriaModeOr;

        [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4029")]
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
