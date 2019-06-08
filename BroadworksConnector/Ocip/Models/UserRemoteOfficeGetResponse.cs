using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserRemoteOfficeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
    private string _remoteOfficePhoneNumber;

    [XmlElement(ElementName = "remoteOfficePhoneNumber", IsNullable = false, Namespace = "")]
    public string RemoteOfficePhoneNumber {
        get => _remoteOfficePhoneNumber;
        set {
            RemoteOfficePhoneNumberSpecified = true;
            _remoteOfficePhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool RemoteOfficePhoneNumberSpecified { get; set; }
}
}
