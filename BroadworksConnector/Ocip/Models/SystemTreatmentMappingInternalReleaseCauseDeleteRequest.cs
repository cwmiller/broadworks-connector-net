using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingInternalReleaseCauseDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private BroadworksConnector.Ocip.Models.InternalReleaseCause16 _internalReleaseCause;

    [XmlElement(ElementName = "internalReleaseCause", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.InternalReleaseCause16 InternalReleaseCause {
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
