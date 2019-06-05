using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallForwardingSelectiveGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _defaultForwardToPhoneNumber;

    [XmlElement(ElementName = "defaultForwardToPhoneNumber", IsNullable = false, Namespace = "")]
    public string DefaultForwardToPhoneNumber {
        get => _defaultForwardToPhoneNumber;
        set {
            DefaultForwardToPhoneNumberSpecified = true;
            _defaultForwardToPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool DefaultForwardToPhoneNumberSpecified { get; set; }
    private bool _playRingReminder;

    [XmlElement(ElementName = "playRingReminder", IsNullable = false, Namespace = "")]
    public bool PlayRingReminder {
        get => _playRingReminder;
        set {
            PlayRingReminderSpecified = true;
            _playRingReminder = value;
        }
    }

    [XmlIgnore]
    public bool PlayRingReminderSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _criteriaTable;

    [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable CriteriaTable {
        get => _criteriaTable;
        set {
            CriteriaTableSpecified = true;
            _criteriaTable = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaTableSpecified { get; set; }
}
}
