using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemHomeNetworkGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _mscAddress;

    [XmlElement(ElementName = "mscAddress", IsNullable = false, Namespace = "")]
    public List<string> MscAddress {
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
