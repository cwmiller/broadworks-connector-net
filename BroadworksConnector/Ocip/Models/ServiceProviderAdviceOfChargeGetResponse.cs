using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAdviceOfChargeGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _useSPLevelAoCSettings;

    [XmlElement(ElementName = "useSPLevelAoCSettings", IsNullable = false, Namespace = "")]
    public bool UseSPLevelAoCSettings {
        get => _useSPLevelAoCSettings;
        set {
            UseSPLevelAoCSettingsSpecified = true;
            _useSPLevelAoCSettings = value;
        }
    }

    [XmlIgnore]
    public bool UseSPLevelAoCSettingsSpecified { get; set; }
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
