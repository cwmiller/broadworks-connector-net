using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupEmergencyZonesGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.EmergencyZonesProhibition _emergencyZonesProhibition;

    [XmlElement(ElementName = "emergencyZonesProhibition", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.EmergencyZonesProhibition EmergencyZonesProhibition {
        get => _emergencyZonesProhibition;
        set {
            EmergencyZonesProhibitionSpecified = true;
            _emergencyZonesProhibition = value;
        }
    }

    [XmlIgnore]
    public bool EmergencyZonesProhibitionSpecified { get; set; }
    private bool _sendEmergencyCallNotifyEmail;

    [XmlElement(ElementName = "sendEmergencyCallNotifyEmail", IsNullable = false, Namespace = "")]
    public bool SendEmergencyCallNotifyEmail {
        get => _sendEmergencyCallNotifyEmail;
        set {
            SendEmergencyCallNotifyEmailSpecified = true;
            _sendEmergencyCallNotifyEmail = value;
        }
    }

    [XmlIgnore]
    public bool SendEmergencyCallNotifyEmailSpecified { get; set; }
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
