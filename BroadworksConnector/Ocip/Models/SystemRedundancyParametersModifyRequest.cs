using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRedundancyParametersModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _sendSipOptionMessageUponMigration;

    [XmlElement(ElementName = "sendSipOptionMessageUponMigration", IsNullable = false, Namespace = "")]
    public bool SendSipOptionMessageUponMigration {
        get => _sendSipOptionMessageUponMigration;
        set {
            SendSipOptionMessageUponMigrationSpecified = true;
            _sendSipOptionMessageUponMigration = value;
        }
    }

    [XmlIgnore]
    public bool SendSipOptionMessageUponMigrationSpecified { get; set; }
}
}
