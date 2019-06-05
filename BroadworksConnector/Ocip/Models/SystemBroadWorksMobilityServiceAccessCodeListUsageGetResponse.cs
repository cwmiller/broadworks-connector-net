using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityServiceAccessCodeListUsageGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _mobileNetworkName;

    [XmlElement(ElementName = "mobileNetworkName", IsNullable = false, Namespace = "")]
    public List<string> MobileNetworkName {
        get => _mobileNetworkName;
        set {
            MobileNetworkNameSpecified = true;
            _mobileNetworkName = value;
        }
    }

    [XmlIgnore]
    public bool MobileNetworkNameSpecified { get; set; }
}
}
