using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOutgoingCallingPlanModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "directTransferScreening", IsNullable = false)]
    public bool DirectTransferScreening { get; set; }
    [XmlElement(ElementName = "enableEnhancedTollCallTyping", IsNullable = false)]
    public bool EnableEnhancedTollCallTyping { get; set; }
 }
}
