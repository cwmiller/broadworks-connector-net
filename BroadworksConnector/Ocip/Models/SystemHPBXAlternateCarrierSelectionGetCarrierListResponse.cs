using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemHPBXAlternateCarrierSelectionGetCarrierListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "HPBXAlternateCarriersTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable HPBXAlternateCarriersTable { get; set; }
 }
}
