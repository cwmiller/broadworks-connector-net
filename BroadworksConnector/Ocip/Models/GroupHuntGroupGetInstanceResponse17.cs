using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupHuntGroupGetInstanceResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile17 _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile17 ServiceInstanceProfile {
        get => _serviceInstanceProfile;
        set {
            ServiceInstanceProfileSpecified = true;
            _serviceInstanceProfile = value;
        }
    }

    [XmlIgnore]
    public bool ServiceInstanceProfileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.HuntPolicy _policy;

    [XmlElement(ElementName = "policy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.HuntPolicy Policy {
        get => _policy;
        set {
            PolicySpecified = true;
            _policy = value;
        }
    }

    [XmlIgnore]
    public bool PolicySpecified { get; set; }
    private bool _huntAfterNoAnswer;

    [XmlElement(ElementName = "huntAfterNoAnswer", IsNullable = false, Namespace = "")]
    public bool HuntAfterNoAnswer {
        get => _huntAfterNoAnswer;
        set {
            HuntAfterNoAnswerSpecified = true;
            _huntAfterNoAnswer = value;
        }
    }

    [XmlIgnore]
    public bool HuntAfterNoAnswerSpecified { get; set; }
    private int _noAnswerNumberOfRings;

    [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
    public int NoAnswerNumberOfRings {
        get => _noAnswerNumberOfRings;
        set {
            NoAnswerNumberOfRingsSpecified = true;
            _noAnswerNumberOfRings = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerNumberOfRingsSpecified { get; set; }
    private bool _forwardAfterTimeout;

    [XmlElement(ElementName = "forwardAfterTimeout", IsNullable = false, Namespace = "")]
    public bool ForwardAfterTimeout {
        get => _forwardAfterTimeout;
        set {
            ForwardAfterTimeoutSpecified = true;
            _forwardAfterTimeout = value;
        }
    }

    [XmlIgnore]
    public bool ForwardAfterTimeoutSpecified { get; set; }
    private int _forwardTimeoutSeconds;

    [XmlElement(ElementName = "forwardTimeoutSeconds", IsNullable = false, Namespace = "")]
    public int ForwardTimeoutSeconds {
        get => _forwardTimeoutSeconds;
        set {
            ForwardTimeoutSecondsSpecified = true;
            _forwardTimeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool ForwardTimeoutSecondsSpecified { get; set; }
    private string _forwardToPhoneNumber;

    [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false, Namespace = "")]
    public string ForwardToPhoneNumber {
        get => _forwardToPhoneNumber;
        set {
            ForwardToPhoneNumberSpecified = true;
            _forwardToPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool ForwardToPhoneNumberSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _agentUserTable;

    [XmlElement(ElementName = "agentUserTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable AgentUserTable {
        get => _agentUserTable;
        set {
            AgentUserTableSpecified = true;
            _agentUserTable = value;
        }
    }

    [XmlIgnore]
    public bool AgentUserTableSpecified { get; set; }
    private bool _allowCallWaitingForAgents;

    [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false, Namespace = "")]
    public bool AllowCallWaitingForAgents {
        get => _allowCallWaitingForAgents;
        set {
            AllowCallWaitingForAgentsSpecified = true;
            _allowCallWaitingForAgents = value;
        }
    }

    [XmlIgnore]
    public bool AllowCallWaitingForAgentsSpecified { get; set; }
}
}
