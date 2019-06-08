using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupGetDefaultResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
}
}
