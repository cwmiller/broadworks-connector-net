using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemExecutiveModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "treatVirtualOnNetCallsAsInternal", IsNullable = false)]
    public bool TreatVirtualOnNetCallsAsInternal { get; set; }
 }
}
