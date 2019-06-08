using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccessDeviceAvailablePortGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<int> _portNumber;

    [XmlElement(ElementName = "portNumber", IsNullable = false, Namespace = "")]
    public List<int> PortNumber {
        get => _portNumber;
        set {
            PortNumberSpecified = true;
            _portNumber = value;
        }
    }

    [XmlIgnore]
    public bool PortNumberSpecified { get; set; }
}
}
