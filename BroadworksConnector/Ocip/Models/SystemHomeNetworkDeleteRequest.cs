using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemHomeNetworkDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _mscAddress;

    [XmlElement(ElementName = "mscAddress", IsNullable = false, Namespace = "")]
    public string MscAddress {
        get => _mscAddress;
        set {
            MscAddressSpecified = true;
            _mscAddress = value;
        }
    }

    [XmlIgnore]
    public bool MscAddressSpecified { get; set; }
}
}
