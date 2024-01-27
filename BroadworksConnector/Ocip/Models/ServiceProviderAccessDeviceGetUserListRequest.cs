using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of users on a specified device.
    /// The response is either ServiceProviderAccessDeviceGetUserListResponse or ErrorResponse.
    /// The following elements are only used in XS data mode and ignored in AS data mode:
    /// searchCriteriaAccessDeviceEndpointPrivateIdentity
    /// 
    /// Replaced by: ServiceProviderAccessDeviceGetUserListRequest21sp1 in AS data mode.
    /// <see cref="ServiceProviderAccessDeviceGetUserListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ServiceProviderAccessDeviceGetUserListRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:5805""}]")]
    public class ServiceProviderAccessDeviceGetUserListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.ServiceProviderAccessDeviceGetUserListResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
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

        protected string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
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
        protected bool DeviceNameSpecified { get; set; }

        protected int _responseSizeLimit;

        [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaLinePortUserPart> _searchCriteriaLinePortUserPart = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaLinePortUserPart>();

        [XmlElement(ElementName = "searchCriteriaLinePortUserPart", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
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
        protected bool SearchCriteriaLinePortUserPartSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaLinePortDomain> _searchCriteriaLinePortDomain = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaLinePortDomain>();

        [XmlElement(ElementName = "searchCriteriaLinePortDomain", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
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
        protected bool SearchCriteriaLinePortDomainSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserLastName>();

        [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName> _searchCriteriaUserFirstName = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserFirstName>();

        [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaDn>();

        [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserId>();

        [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
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

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId>();

        [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId
        {
            get => _searchCriteriaGroupId;
            set
            {
                SearchCriteriaGroupIdSpecified = true;
                _searchCriteriaGroupId = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaGroupIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactEndpointType _searchCriteriaExactEndpointType;

        [XmlElement(ElementName = "searchCriteriaExactEndpointType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
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
        protected bool SearchCriteriaExactEndpointTypeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserType _searchCriteriaExactUserType;

        [XmlElement(ElementName = "searchCriteriaExactUserType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
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
        protected bool SearchCriteriaExactUserTypeSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaExtension>();

        [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
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

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactUserDepartment _searchCriteriaExactUserDepartment;

        [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
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

        protected BroadWorksConnector.Ocip.Models.SearchCriteriaExactPortNumber _searchCriteriaExactPortNumber;

        [XmlElement(ElementName = "searchCriteriaExactPortNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
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
        protected bool SearchCriteriaExactPortNumberSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaAccessDeviceEndpointPrivateIdentity> _searchCriteriaAccessDeviceEndpointPrivateIdentity = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaAccessDeviceEndpointPrivateIdentity>();

        [XmlElement(ElementName = "searchCriteriaAccessDeviceEndpointPrivateIdentity", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:5805")]
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
        protected bool SearchCriteriaAccessDeviceEndpointPrivateIdentitySpecified { get; set; }

    }
}
