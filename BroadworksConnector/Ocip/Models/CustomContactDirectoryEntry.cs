using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CustomContactDirectoryEntry 
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
    private string _virtualOnNetPhoneNumber;

    [XmlElement(ElementName = "virtualOnNetPhoneNumber", IsNullable = false, Namespace = "")]
    public string VirtualOnNetPhoneNumber {
        get => _virtualOnNetPhoneNumber;
        set {
            VirtualOnNetPhoneNumberSpecified = true;
            _virtualOnNetPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool VirtualOnNetPhoneNumberSpecified { get; set; }
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
}
}
