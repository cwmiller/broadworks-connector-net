using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
    private string _defaultDomain;

    [XmlElement(ElementName = "defaultDomain", IsNullable = false, Namespace = "")]
    public string DefaultDomain {
        get => _defaultDomain;
        set {
            DefaultDomainSpecified = true;
            _defaultDomain = value;
        }
    }

    [XmlIgnore]
    public bool DefaultDomainSpecified { get; set; }
    private int _userLimit;

    [XmlElement(ElementName = "userLimit", IsNullable = false, Namespace = "")]
    public int UserLimit {
        get => _userLimit;
        set {
            UserLimitSpecified = true;
            _userLimit = value;
        }
    }

    [XmlIgnore]
    public bool UserLimitSpecified { get; set; }
    private string _groupName;

    [XmlElement(ElementName = "groupName", IsNullable = true, Namespace = "")]
    public string GroupName {
        get => _groupName;
        set {
            GroupNameSpecified = true;
            _groupName = value;
        }
    }

    [XmlIgnore]
    public bool GroupNameSpecified { get; set; }
    private string _callingLineIdName;

    [XmlElement(ElementName = "callingLineIdName", IsNullable = true, Namespace = "")]
    public string CallingLineIdName {
        get => _callingLineIdName;
        set {
            CallingLineIdNameSpecified = true;
            _callingLineIdName = value;
        }
    }

    [XmlIgnore]
    public bool CallingLineIdNameSpecified { get; set; }
    private string _callingLineIdPhoneNumber;

    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = true, Namespace = "")]
    public string CallingLineIdPhoneNumber {
        get => _callingLineIdPhoneNumber;
        set {
            CallingLineIdPhoneNumberSpecified = true;
            _callingLineIdPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool CallingLineIdPhoneNumberSpecified { get; set; }
    private string _timeZone;

    [XmlElement(ElementName = "timeZone", IsNullable = false, Namespace = "")]
    public string TimeZone {
        get => _timeZone;
        set {
            TimeZoneSpecified = true;
            _timeZone = value;
        }
    }

    [XmlIgnore]
    public bool TimeZoneSpecified { get; set; }
    private string _locationDialingCode;

    [XmlElement(ElementName = "locationDialingCode", IsNullable = true, Namespace = "")]
    public string LocationDialingCode {
        get => _locationDialingCode;
        set {
            LocationDialingCodeSpecified = true;
            _locationDialingCode = value;
        }
    }

    [XmlIgnore]
    public bool LocationDialingCodeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.Contact _contact;

    [XmlElement(ElementName = "contact", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.Contact Contact {
        get => _contact;
        set {
            ContactSpecified = true;
            _contact = value;
        }
    }

    [XmlIgnore]
    public bool ContactSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.StreetAddress _address;

    [XmlElement(ElementName = "address", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.StreetAddress Address {
        get => _address;
        set {
            AddressSpecified = true;
            _address = value;
        }
    }

    [XmlIgnore]
    public bool AddressSpecified { get; set; }
    private string _servicePolicy;

    [XmlElement(ElementName = "servicePolicy", IsNullable = true, Namespace = "")]
    public string ServicePolicy {
        get => _servicePolicy;
        set {
            ServicePolicySpecified = true;
            _servicePolicy = value;
        }
    }

    [XmlIgnore]
    public bool ServicePolicySpecified { get; set; }
    private string _callProcessingSliceId;

    [XmlElement(ElementName = "callProcessingSliceId", IsNullable = true, Namespace = "")]
    public string CallProcessingSliceId {
        get => _callProcessingSliceId;
        set {
            CallProcessingSliceIdSpecified = true;
            _callProcessingSliceId = value;
        }
    }

    [XmlIgnore]
    public bool CallProcessingSliceIdSpecified { get; set; }
    private string _provisioningSliceId;

    [XmlElement(ElementName = "provisioningSliceId", IsNullable = true, Namespace = "")]
    public string ProvisioningSliceId {
        get => _provisioningSliceId;
        set {
            ProvisioningSliceIdSpecified = true;
            _provisioningSliceId = value;
        }
    }

    [XmlIgnore]
    public bool ProvisioningSliceIdSpecified { get; set; }
    private string _subscriberPartition;

    [XmlElement(ElementName = "subscriberPartition", IsNullable = true, Namespace = "")]
    public string SubscriberPartition {
        get => _subscriberPartition;
        set {
            SubscriberPartitionSpecified = true;
            _subscriberPartition = value;
        }
    }

    [XmlIgnore]
    public bool SubscriberPartitionSpecified { get; set; }
    private string _preferredDataCenter;

    [XmlElement(ElementName = "preferredDataCenter", IsNullable = true, Namespace = "")]
    public string PreferredDataCenter {
        get => _preferredDataCenter;
        set {
            PreferredDataCenterSpecified = true;
            _preferredDataCenter = value;
        }
    }

    [XmlIgnore]
    public bool PreferredDataCenterSpecified { get; set; }
    private string _defaultUserCallingLineIdPhoneNumber;

    [XmlElement(ElementName = "defaultUserCallingLineIdPhoneNumber", IsNullable = true, Namespace = "")]
    public string DefaultUserCallingLineIdPhoneNumber {
        get => _defaultUserCallingLineIdPhoneNumber;
        set {
            DefaultUserCallingLineIdPhoneNumberSpecified = true;
            _defaultUserCallingLineIdPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool DefaultUserCallingLineIdPhoneNumberSpecified { get; set; }
}
}
