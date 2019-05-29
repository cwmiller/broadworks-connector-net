using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTreatmentMappingInternalReleaseCauseDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "internalReleaseCause", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.InternalReleaseCause16 InternalReleaseCause { get; set; }
 }
}
