using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
}
}
