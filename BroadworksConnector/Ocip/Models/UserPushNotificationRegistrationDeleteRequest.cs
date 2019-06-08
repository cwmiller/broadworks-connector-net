using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPushNotificationRegistrationDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _registrationId;

    [XmlElement(ElementName = "registrationId", IsNullable = false, Namespace = "")]
    public string RegistrationId {
        get => _registrationId;
        set {
            RegistrationIdSpecified = true;
            _registrationId = value;
        }
    }

    [XmlIgnore]
    public bool RegistrationIdSpecified { get; set; }
}
}
