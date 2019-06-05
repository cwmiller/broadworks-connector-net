using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSingleSignOnCreateDeviceTokenResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _deviceToken;

    [XmlElement(ElementName = "deviceToken", IsNullable = false, Namespace = "")]
    public string DeviceToken {
        get => _deviceToken;
        set {
            DeviceTokenSpecified = true;
            _deviceToken = value;
        }
    }

    [XmlIgnore]
    public bool DeviceTokenSpecified { get; set; }
}
}
