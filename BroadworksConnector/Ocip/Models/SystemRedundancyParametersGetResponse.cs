using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRedundancyParametersGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _rollBackTimerMinutes;

    [XmlElement(ElementName = "rollBackTimerMinutes", IsNullable = false, Namespace = "")]
    public int RollBackTimerMinutes {
        get => _rollBackTimerMinutes;
        set {
            RollBackTimerMinutesSpecified = true;
            _rollBackTimerMinutes = value;
        }
    }

    [XmlIgnore]
    public bool RollBackTimerMinutesSpecified { get; set; }
}
}
