using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDiversionReasonModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "diversionReason", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SIPDiversionReason DiversionReason { get; set; }
    [XmlElement(ElementName = "causeValue", IsNullable = false)]
    public string CauseValue { get; set; }
 }
}
