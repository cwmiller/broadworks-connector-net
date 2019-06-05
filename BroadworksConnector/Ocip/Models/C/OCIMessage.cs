using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models.C
{
[Serializable]
[XmlRoot(Namespace = "C")]
public  class OCIMessage 
{
    private string _sessionId;

    [XmlElement(ElementName = "sessionId", IsNullable = false, Namespace = "")]
    public string SessionId {
        get => _sessionId;
        set {
            SessionIdSpecified = true;
            _sessionId = value;
        }
    }

    [XmlIgnore]
    public bool SessionIdSpecified { get; set; }
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
    private string _phoneNumber;

    [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
    public string PhoneNumber {
        get => _phoneNumber;
        set {
            PhoneNumberSpecified = true;
            _phoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberSpecified { get; set; }
    private string _linePort;

    [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
    public string LinePort {
        get => _linePort;
        set {
            LinePortSpecified = true;
            _linePort = value;
        }
    }

    [XmlIgnore]
    public bool LinePortSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.C.OCICommand> _command;

    [XmlElement(ElementName = "command", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.C.OCICommand> Command {
        get => _command;
        set {
            CommandSpecified = true;
            _command = value;
        }
    }

    [XmlIgnore]
    public bool CommandSpecified { get; set; }
}
}
