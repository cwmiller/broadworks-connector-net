using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksAnywhereModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private bool _alertAllLocationsForClickToDialCalls;

    [XmlElement(ElementName = "alertAllLocationsForClickToDialCalls", IsNullable = false, Namespace = "")]
    public bool AlertAllLocationsForClickToDialCalls {
        get => _alertAllLocationsForClickToDialCalls;
        set {
            AlertAllLocationsForClickToDialCallsSpecified = true;
            _alertAllLocationsForClickToDialCalls = value;
        }
    }

    [XmlIgnore]
    public bool AlertAllLocationsForClickToDialCallsSpecified { get; set; }
    private bool _alertAllLocationsForGroupPagingCalls;

    [XmlElement(ElementName = "alertAllLocationsForGroupPagingCalls", IsNullable = false, Namespace = "")]
    public bool AlertAllLocationsForGroupPagingCalls {
        get => _alertAllLocationsForGroupPagingCalls;
        set {
            AlertAllLocationsForGroupPagingCallsSpecified = true;
            _alertAllLocationsForGroupPagingCalls = value;
        }
    }

    [XmlIgnore]
    public bool AlertAllLocationsForGroupPagingCallsSpecified { get; set; }
}
}
