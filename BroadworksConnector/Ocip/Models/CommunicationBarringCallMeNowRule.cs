using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommunicationBarringCallMeNowRule 
{
    private string _criteria;

    [XmlElement(ElementName = "criteria", IsNullable = false, Namespace = "")]
    public string Criteria {
        get => _criteria;
        set {
            CriteriaSpecified = true;
            _criteria = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CommunicationBarringCallMeNowAction _action;

    [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommunicationBarringCallMeNowAction Action {
        get => _action;
        set {
            ActionSpecified = true;
            _action = value;
        }
    }

    [XmlIgnore]
    public bool ActionSpecified { get; set; }
    private int? _callTimeoutSeconds;

    [XmlElement(ElementName = "callTimeoutSeconds", IsNullable = true, Namespace = "")]
    public int? CallTimeoutSeconds {
        get => _callTimeoutSeconds;
        set {
            CallTimeoutSecondsSpecified = true;
            _callTimeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool CallTimeoutSecondsSpecified { get; set; }
}
}
