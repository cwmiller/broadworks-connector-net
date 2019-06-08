using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCallbackAddReleaseCauseListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private List<BroadWorksConnector.Ocip.Models.AutomaticCallbackReleaseCause> _releaseCause;

    [XmlElement(ElementName = "releaseCause", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.AutomaticCallbackReleaseCause> ReleaseCause {
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
