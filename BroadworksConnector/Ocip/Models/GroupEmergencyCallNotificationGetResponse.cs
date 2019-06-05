using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEmergencyCallNotificationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _sendEmergencyCallNotificationEmail;

    [XmlElement(ElementName = "sendEmergencyCallNotificationEmail", IsNullable = false, Namespace = "")]
    public bool SendEmergencyCallNotificationEmail {
        get => _sendEmergencyCallNotificationEmail;
        set {
            SendEmergencyCallNotificationEmailSpecified = true;
            _sendEmergencyCallNotificationEmail = value;
        }
    }

    [XmlIgnore]
    public bool SendEmergencyCallNotificationEmailSpecified { get; set; }
    private string _emergencyCallNotifyEmailAddress;

    [XmlElement(ElementName = "emergencyCallNotifyEmailAddress", IsNullable = false, Namespace = "")]
    public string EmergencyCallNotifyEmailAddress {
        get => _emergencyCallNotifyEmailAddress;
        set {
            EmergencyCallNotifyEmailAddressSpecified = true;
            _emergencyCallNotifyEmailAddress = value;
        }
    }

    [XmlIgnore]
    public bool EmergencyCallNotifyEmailAddressSpecified { get; set; }
}
}
