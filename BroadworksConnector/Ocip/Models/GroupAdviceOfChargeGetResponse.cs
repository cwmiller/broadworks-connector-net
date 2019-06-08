using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAdviceOfChargeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _useGroupLevelAoCSettings;

    [XmlElement(ElementName = "useGroupLevelAoCSettings", IsNullable = false, Namespace = "")]
    public bool UseGroupLevelAoCSettings {
        get => _useGroupLevelAoCSettings;
        set {
            UseGroupLevelAoCSettingsSpecified = true;
            _useGroupLevelAoCSettings = value;
        }
    }

    [XmlIgnore]
    public bool UseGroupLevelAoCSettingsSpecified { get; set; }
    private int _delayBetweenNotificationSeconds;

    [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false, Namespace = "")]
    public int DelayBetweenNotificationSeconds {
        get => _delayBetweenNotificationSeconds;
        set {
            DelayBetweenNotificationSecondsSpecified = true;
            _delayBetweenNotificationSeconds = value;
        }
    }

    [XmlIgnore]
    public bool DelayBetweenNotificationSecondsSpecified { get; set; }
}
}
