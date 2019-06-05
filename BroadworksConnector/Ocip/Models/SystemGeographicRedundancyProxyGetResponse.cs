using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGeographicRedundancyProxyGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enabled;

    [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
    public bool Enabled {
        get => _enabled;
        set {
            EnabledSpecified = true;
            _enabled = value;
        }
    }

    [XmlIgnore]
    public bool EnabledSpecified { get; set; }
}
}
