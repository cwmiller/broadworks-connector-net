using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderEmergencyCallNotificationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
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

    [XmlElement(ElementName = "emergencyCallNotifyEmailAddress", IsNullable = true, Namespace = "")]
    public string EmergencyCallNotifyEmailAddress {
        get => _emergencyCallNotifyEmailAddress;
        set {
            EmergencyCallNotifyEmailAddressSpecified = true;
            _emergencyCallNotifyEmailAddress = value;
        }
    }

    [XmlIgnore]
    public bool EmergencyCallNotifyEmailAddressSpecified { get; set; }
    private bool _allowGroupOverride;

    [XmlElement(ElementName = "allowGroupOverride", IsNullable = false, Namespace = "")]
    public bool AllowGroupOverride {
        get => _allowGroupOverride;
        set {
            AllowGroupOverrideSpecified = true;
            _allowGroupOverride = value;
        }
    }

    [XmlIgnore]
    public bool AllowGroupOverrideSpecified { get; set; }
}
}
