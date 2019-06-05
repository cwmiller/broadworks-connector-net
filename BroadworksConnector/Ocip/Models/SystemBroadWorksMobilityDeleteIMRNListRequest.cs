using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityDeleteIMRNListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private List<string> _imrnNumber;

    [XmlElement(ElementName = "imrnNumber", IsNullable = false, Namespace = "")]
    public List<string> ImrnNumber {
        get => _imrnNumber;
        set {
            ImrnNumberSpecified = true;
            _imrnNumber = value;
        }
    }

    [XmlIgnore]
    public bool ImrnNumberSpecified { get; set; }
}
}
