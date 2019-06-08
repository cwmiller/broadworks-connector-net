using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingInternalReleaseCauseDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.InternalReleaseCause16 _internalReleaseCause;

    [XmlElement(ElementName = "internalReleaseCause", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.InternalReleaseCause16 InternalReleaseCause {
        get => _internalReleaseCause;
        set {
            InternalReleaseCauseSpecified = true;
            _internalReleaseCause = value;
        }
    }

    [XmlIgnore]
    public bool InternalReleaseCauseSpecified { get; set; }
}
}
