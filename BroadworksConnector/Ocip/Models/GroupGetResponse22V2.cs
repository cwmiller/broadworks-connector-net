using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGetResponse22V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private int _userCount;

    [XmlElement(ElementName = "userCount", IsNullable = false, Namespace = "")]
    public int UserCount {
        get => _userCount;
        set {
            UserCountSpecified = true;
            _userCount = value;
        }
    }

    [XmlIgnore]
    public bool UserCountSpecified { get; set; }
    private string _groupName;

    [XmlElement(ElementName = "groupName", IsNullable = false, Namespace = "")]
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

    [XmlElement(ElementName = "callingLineIdName", IsNullable = false, Namespace = "")]
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

    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = false, Namespace = "")]
    public string CallingLineIdPhoneNumber {
        get => _callingLineIdPhoneNumber;
        set {
            CallingLineIdPhoneNumberSpecified = true;
            _callingLineIdPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool CallingLineIdPhoneNumberSpecified { get; set; }
    private string _callingLineIdDisplayPhoneNumber;

    [XmlElement(ElementName = "callingLineIdDisplayPhoneNumber", IsNullable = false, Namespace = "")]
    public string CallingLineIdDisplayPhoneNumber {
        get => _callingLineIdDisplayPhoneNumber;
        set {
            CallingLineIdDisplayPhoneNumberSpecified = true;
            _callingLineIdDisplayPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool CallingLineIdDisplayPhoneNumberSpecified { get; set; }
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
    private string _timeZoneDisplayName;

    [XmlElement(ElementName = "timeZoneDisplayName", IsNullable = false, Namespace = "")]
    public string TimeZoneDisplayName {
        get => _timeZoneDisplayName;
        set {
            TimeZoneDisplayNameSpecified = true;
            _timeZoneDisplayName = value;
        }
    }

    [XmlIgnore]
    public bool TimeZoneDisplayNameSpecified { get; set; }
    private string _locationDialingCode;

    [XmlElement(ElementName = "locationDialingCode", IsNullable = false, Namespace = "")]
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

    [XmlElement(ElementName = "servicePolicy", IsNullable = false, Namespace = "")]
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

    [XmlElement(ElementName = "callProcessingSliceId", IsNullable = false, Namespace = "")]
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

    [XmlElement(ElementName = "provisioningSliceId", IsNullable = false, Namespace = "")]
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

    [XmlElement(ElementName = "subscriberPartition", IsNullable = false, Namespace = "")]
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

    [XmlElement(ElementName = "preferredDataCenter", IsNullable = false, Namespace = "")]
    public string PreferredDataCenter {
        get => _preferredDataCenter;
        set {
            PreferredDataCenterSpecified = true;
            _preferredDataCenter = value;
        }
    }

    [XmlIgnore]
    public bool PreferredDataCenterSpecified { get; set; }
    private string _resellerId;

    [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
    public string ResellerId {
        get => _resellerId;
        set {
            ResellerIdSpecified = true;
            _resellerId = value;
        }
    }

    [XmlIgnore]
    public bool ResellerIdSpecified { get; set; }
}
}
