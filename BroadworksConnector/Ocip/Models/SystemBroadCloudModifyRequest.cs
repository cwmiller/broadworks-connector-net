using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadCloudModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _provisioningUrl;

    [XmlElement(ElementName = "provisioningUrl", IsNullable = true, Namespace = "")]
    public string ProvisioningUrl {
        get => _provisioningUrl;
        set {
            ProvisioningUrlSpecified = true;
            _provisioningUrl = value;
        }
    }

    [XmlIgnore]
    public bool ProvisioningUrlSpecified { get; set; }
    private string _provisioningUserId;

    [XmlElement(ElementName = "provisioningUserId", IsNullable = true, Namespace = "")]
    public string ProvisioningUserId {
        get => _provisioningUserId;
        set {
            ProvisioningUserIdSpecified = true;
            _provisioningUserId = value;
        }
    }

    [XmlIgnore]
    public bool ProvisioningUserIdSpecified { get; set; }
    private string _provisioningPassword;

    [XmlElement(ElementName = "provisioningPassword", IsNullable = true, Namespace = "")]
    public string ProvisioningPassword {
        get => _provisioningPassword;
        set {
            ProvisioningPasswordSpecified = true;
            _provisioningPassword = value;
        }
    }

    [XmlIgnore]
    public bool ProvisioningPasswordSpecified { get; set; }
    private bool _enableSynchronization;

    [XmlElement(ElementName = "enableSynchronization", IsNullable = false, Namespace = "")]
    public bool EnableSynchronization {
        get => _enableSynchronization;
        set {
            EnableSynchronizationSpecified = true;
            _enableSynchronization = value;
        }
    }

    [XmlIgnore]
    public bool EnableSynchronizationSpecified { get; set; }
}
}
