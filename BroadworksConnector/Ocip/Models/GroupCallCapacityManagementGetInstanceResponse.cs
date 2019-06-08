using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCapacityManagementGetInstanceResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private int _maxActiveCallsAllowed;

    [XmlElement(ElementName = "maxActiveCallsAllowed", IsNullable = false, Namespace = "")]
    public int MaxActiveCallsAllowed {
        get => _maxActiveCallsAllowed;
        set {
            MaxActiveCallsAllowedSpecified = true;
            _maxActiveCallsAllowed = value;
        }
    }

    [XmlIgnore]
    public bool MaxActiveCallsAllowedSpecified { get; set; }
    private int _maxIncomingActiveCallsAllowed;

    [XmlElement(ElementName = "maxIncomingActiveCallsAllowed", IsNullable = false, Namespace = "")]
    public int MaxIncomingActiveCallsAllowed {
        get => _maxIncomingActiveCallsAllowed;
        set {
            MaxIncomingActiveCallsAllowedSpecified = true;
            _maxIncomingActiveCallsAllowed = value;
        }
    }

    [XmlIgnore]
    public bool MaxIncomingActiveCallsAllowedSpecified { get; set; }
    private int _maxOutgoingActiveCallsAllowed;

    [XmlElement(ElementName = "maxOutgoingActiveCallsAllowed", IsNullable = false, Namespace = "")]
    public int MaxOutgoingActiveCallsAllowed {
        get => _maxOutgoingActiveCallsAllowed;
        set {
            MaxOutgoingActiveCallsAllowedSpecified = true;
            _maxOutgoingActiveCallsAllowed = value;
        }
    }

    [XmlIgnore]
    public bool MaxOutgoingActiveCallsAllowedSpecified { get; set; }
    private bool _defaultGroupForNewUsers;

    [XmlElement(ElementName = "defaultGroupForNewUsers", IsNullable = false, Namespace = "")]
    public bool DefaultGroupForNewUsers {
        get => _defaultGroupForNewUsers;
        set {
            DefaultGroupForNewUsersSpecified = true;
            _defaultGroupForNewUsers = value;
        }
    }

    [XmlIgnore]
    public bool DefaultGroupForNewUsersSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _userTable;

    [XmlElement(ElementName = "userTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable UserTable {
        get => _userTable;
        set {
            UserTableSpecified = true;
            _userTable = value;
        }
    }

    [XmlIgnore]
    public bool UserTableSpecified { get; set; }
}
}
