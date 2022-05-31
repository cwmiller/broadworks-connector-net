using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of registration contacts.
    /// This request handles all levels of administration privileges.  The content of the response will only contain
    /// items within the scope of the requester's login id.  At the system level any of the choice parameters may be
    /// specified to filter the registrations listed.  At the reseller level, the resellerId must be specified.
    /// ResellerId is not valid at service provider, group or user level. At the service provider level the
    /// serviceProviderId must be specified for the service provider and group options.  When using the userId or
    /// linePort options the specified value must be valid for that service provider login.  At the group level
    /// the servicProviderId and the groupId must be specified for the group option. When using the userId or linePort
    /// options the specified value must be valid for that group login.
    /// The serviceProviderId option is not valid at the group level.  At the user level when using the userId or
    /// linePort options the specified value must be valid for that user login.  The serviceProviderId and groupId
    /// options are not valid at the user level.
    /// The response is either SystemGetRegistrationContactListResponse21sp1 or ErrorResponse.
    /// The RegistrationEndpointType21sp1 is sent in response The Endpoint Type column contains one of the enumerated RegistrationEndpointType21sp1 values.
    /// The value Mobility in Endpoint Type column is only applicable in AS data mode.
    /// 
    /// The following elements are only used in AS data mode:
    /// resellerId
    /// <see cref="SystemGetRegistrationContactListResponse21sp1"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10719"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10720"",""optional"":true,""children"":[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10723""}]}]}]")]
    public class SystemGetRegistrationContactListRequest21sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemGetRegistrationContactListResponse21sp1>
    {

        protected string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10720")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10720")]
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

        protected string _svcProviderId;

        [XmlElement(ElementName = "svcProviderId", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10723")]
        [MinLength(1)]
        [MaxLength(30)]
        public string SvcProviderId
        {
            get => _svcProviderId;
            set
            {
                SvcProviderIdSpecified = true;
                _svcProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool SvcProviderIdSpecified { get; set; }

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10723")]
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

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10720")]
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

        protected string _linePort;

        [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10720")]
        [MinLength(1)]
        [MaxLength(161)]
        public string LinePort
        {
            get => _linePort;
            set
            {
                LinePortSpecified = true;
                _linePort = value;
            }
        }

        [XmlIgnore]
        protected bool LinePortSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AccessDeviceLevel _deviceLevel;

        [XmlElement(ElementName = "deviceLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10719")]
        public BroadWorksConnector.Ocip.Models.AccessDeviceLevel DeviceLevel
        {
            get => _deviceLevel;
            set
            {
                DeviceLevelSpecified = true;
                _deviceLevel = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceLevelSpecified { get; set; }

        protected string _deviceName;

        [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10719")]
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

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10719")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceType
        {
            get => _deviceType;
            set
            {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTypeSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaRegistrationURI> _searchCriteriaRegistrationURI = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaRegistrationURI>();

        [XmlElement(ElementName = "searchCriteriaRegistrationURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10719")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaRegistrationURI> SearchCriteriaRegistrationURI
        {
            get => _searchCriteriaRegistrationURI;
            set
            {
                SearchCriteriaRegistrationURISpecified = true;
                _searchCriteriaRegistrationURI = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaRegistrationURISpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.SearchCriteriaSIPContact> _searchCriteriaSIPContact = new List<BroadWorksConnector.Ocip.Models.SearchCriteriaSIPContact>();

        [XmlElement(ElementName = "searchCriteriaSIPContact", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10719")]
        public List<BroadWorksConnector.Ocip.Models.SearchCriteriaSIPContact> SearchCriteriaSIPContact
        {
            get => _searchCriteriaSIPContact;
            set
            {
                SearchCriteriaSIPContactSpecified = true;
                _searchCriteriaSIPContact = value;
            }
        }

        [XmlIgnore]
        protected bool SearchCriteriaSIPContactSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.RegistrationEndpointType21sp1 _endpointType;

        [XmlElement(ElementName = "endpointType", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10719")]
        public BroadWorksConnector.Ocip.Models.RegistrationEndpointType21sp1 EndpointType
        {
            get => _endpointType;
            set
            {
                EndpointTypeSpecified = true;
                _endpointType = value;
            }
        }

        [XmlIgnore]
        protected bool EndpointTypeSpecified { get; set; }

        protected bool _expired;

        [XmlElement(ElementName = "expired", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10719")]
        public bool Expired
        {
            get => _expired;
            set
            {
                ExpiredSpecified = true;
                _expired = value;
            }
        }

        [XmlIgnore]
        protected bool ExpiredSpecified { get; set; }

    }
}
