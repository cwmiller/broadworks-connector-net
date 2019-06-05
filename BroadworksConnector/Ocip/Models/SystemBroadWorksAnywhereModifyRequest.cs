using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksAnywhereModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private bool _enableTransferNotification;

    [XmlElement(ElementName = "enableTransferNotification", IsNullable = false, Namespace = "")]
    public bool EnableTransferNotification {
        get => _enableTransferNotification;
        set {
            EnableTransferNotificationSpecified = true;
            _enableTransferNotification = value;
        }
    }

    [XmlIgnore]
    public bool EnableTransferNotificationSpecified { get; set; }
}
}
