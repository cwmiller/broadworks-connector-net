using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressAvailableOutOfOffice 
{
    private BroadWorksConnector.Ocip.Models.CommPilotExpressRedirection _incomingCalls;

    [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirection IncomingCalls {
        get => _incomingCalls;
        set {
            IncomingCallsSpecified = true;
            _incomingCalls = value;
        }
    }

    [XmlIgnore]
    public bool IncomingCallsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotify _incomingCallNotify;

    [XmlElement(ElementName = "incomingCallNotify", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommPilotExpressEmailNotify IncomingCallNotify {
        get => _incomingCallNotify;
        set {
            IncomingCallNotifySpecified = true;
            _incomingCallNotify = value;
        }
    }

    [XmlIgnore]
    public bool IncomingCallNotifySpecified { get; set; }
}
}
