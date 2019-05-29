using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDiversionReasonGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "diversionReasonTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DiversionReasonTable { get; set; }
 }
}
