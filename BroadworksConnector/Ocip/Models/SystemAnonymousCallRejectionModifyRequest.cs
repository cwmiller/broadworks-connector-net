using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAnonymousCallRejectionModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "paiRequired", IsNullable = false)]
    public bool PaiRequired { get; set; }
    [XmlElement(ElementName = "screenOnlyLocalCalls", IsNullable = false)]
    public bool ScreenOnlyLocalCalls { get; set; }
 }
}
