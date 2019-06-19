using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the configuration of a specified group access device.
    /// The response is either GroupAccessDeviceGetUserListResponse or ErrorResponse.
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// searchCriteriaAccessDeviceEndpointPrivateIdentity
    /// 
    /// Replaced by: GroupAccessDeviceGetUserListRequest21sp1 in AS data mode.
    /// <see cref="GroupAccessDeviceGetUserListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupAccessDeviceGetUserListRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:3967""}]")]
    public class GroupAccessDeviceGetUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
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

        private string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceName
        {
            get => _deviceName;
            set
            {
                DeviceNameSpecified = true;
                _deviceName = value;
            }
        }

        [XmlIgnore]
        public bool DeviceNameSpecified { get; set; }

        private int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
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
        public bool ResponseSizeLimitSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaLinePortUserPart> _searchCriteriaLinePortUserPart = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaLinePortUserPart>();

        [XmlElement(ElementName = "searchCriteriaLinePortUserPart", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaLinePortUserPart> SearchCriteriaLinePortUserPart
        {
            get => _searchCriteriaLinePortUserPart;
            set
            {
                SearchCriteriaLinePortUserPartSpecified = true;
                _searchCriteriaLinePortUserPart = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaLinePortUserPartSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaLinePortDomain> _searchCriteriaLinePortDomain = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaLinePortDomain>();

        [XmlElement(ElementName = "searchCriteriaLinePortDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaLinePortDomain> SearchCriteriaLinePortDomain
        {
            get => _searchCriteriaLinePortDomain;
            set
            {
                SearchCriteriaLinePortDomainSpecified = true;
                _searchCriteriaLinePortDomain = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaLinePortDomainSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName>();

        [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
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
        public bool SearchCriteriaUserLastNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> _searchCriteriaUserFirstName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName>();

        [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
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
        public bool SearchCriteriaUserFirstNameSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn>();

        [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
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
        public bool SearchCriteriaDnSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId>();

        [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
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
        public bool SearchCriteriaUserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactEndpointType _searchCriteriaExactEndpointType;

        [XmlElement(ElementName = "searchCriteriaExactEndpointType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactEndpointType SearchCriteriaExactEndpointType
        {
            get => _searchCriteriaExactEndpointType;
            set
            {
                SearchCriteriaExactEndpointTypeSpecified = true;
                _searchCriteriaExactEndpointType = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactEndpointTypeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserType _searchCriteriaExactUserType;

        [XmlElement(ElementName = "searchCriteriaExactUserType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserType SearchCriteriaExactUserType
        {
            get => _searchCriteriaExactUserType;
            set
            {
                SearchCriteriaExactUserTypeSpecified = true;
                _searchCriteriaExactUserType = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactUserTypeSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension>();

        [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
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
        public bool SearchCriteriaExtensionSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment _searchCriteriaExactUserDepartment;

        [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
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
        public bool SearchCriteriaExactUserDepartmentSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SearchCriteriaExactPortNumber _searchCriteriaExactPortNumber;

        [XmlElement(ElementName = "searchCriteriaExactPortNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
        public BroadWorksConnector.Ocip.Models.SearchCriteriaExactPortNumber SearchCriteriaExactPortNumber
        {
            get => _searchCriteriaExactPortNumber;
            set
            {
                SearchCriteriaExactPortNumberSpecified = true;
                _searchCriteriaExactPortNumber = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaExactPortNumberSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.SearchCriteriaAccessDeviceEndpointPrivateIdentity> _searchCriteriaAccessDeviceEndpointPrivateIdentity = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaAccessDeviceEndpointPrivateIdentity>();

        [XmlElement(ElementName = "searchCriteriaAccessDeviceEndpointPrivateIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3967")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaAccessDeviceEndpointPrivateIdentity> SearchCriteriaAccessDeviceEndpointPrivateIdentity
        {
            get => _searchCriteriaAccessDeviceEndpointPrivateIdentity;
            set
            {
                SearchCriteriaAccessDeviceEndpointPrivateIdentitySpecified = true;
                _searchCriteriaAccessDeviceEndpointPrivateIdentity = value;
            }
        }

        [XmlIgnore]
        public bool SearchCriteriaAccessDeviceEndpointPrivateIdentitySpecified { get; set; }

    }
}
