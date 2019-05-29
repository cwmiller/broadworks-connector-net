using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringProfileGetCriteriaUsageListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "profileTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ProfileTable { get; set; }
 }
}
