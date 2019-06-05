using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCallbackGetReleaseCauseListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.AutomaticCallbackReleaseCause> _releaseCause;

    [XmlElement(ElementName = "releaseCause", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.AutomaticCallbackReleaseCause> ReleaseCause {
        get => _releaseCause;
        set {
            ReleaseCauseSpecified = true;
            _releaseCause = value;
        }
    }

    [XmlIgnore]
    public bool ReleaseCauseSpecified { get; set; }
}
}
