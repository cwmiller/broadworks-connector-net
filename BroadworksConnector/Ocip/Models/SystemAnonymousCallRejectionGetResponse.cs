using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAnonymousCallRejectionGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "paiRequired", IsNullable = false)]
    public bool PaiRequired { get; set; }
    [XmlElement(ElementName = "screenOnlyLocalCalls", IsNullable = false)]
    public bool ScreenOnlyLocalCalls { get; set; }
 }
}
