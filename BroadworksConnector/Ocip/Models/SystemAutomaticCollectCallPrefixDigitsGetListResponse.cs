using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCollectCallPrefixDigitsGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "prefixTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable PrefixTable { get; set; }
 }
}
