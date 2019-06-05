using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemExpensiveCallTypeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _alternateCallIndicator;

    [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false, Namespace = "")]
    public List<string> AlternateCallIndicator {
        get => _alternateCallIndicator;
        set {
            AlternateCallIndicatorSpecified = true;
            _alternateCallIndicator = value;
        }
    }

    [XmlIgnore]
    public bool AlternateCallIndicatorSpecified { get; set; }
}
}
