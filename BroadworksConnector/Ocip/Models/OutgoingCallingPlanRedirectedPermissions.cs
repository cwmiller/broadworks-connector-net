using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class OutgoingCallingPlanRedirectedPermissions 
{
    [XmlElement(ElementName = "outsideGroup", IsNullable = false)]
    public bool OutsideGroup { get; set; }
 }
}
