using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemExecutiveGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "treatVirtualOnNetCallsAsInternal", IsNullable = false)]
    public bool TreatVirtualOnNetCallsAsInternal { get; set; }
 }
}
