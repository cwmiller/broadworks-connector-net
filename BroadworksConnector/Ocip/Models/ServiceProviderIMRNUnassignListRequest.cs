using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderIMRNUnassignListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "imrn", IsNullable = false)]
    public List<string> Imrn { get; set; }
    [XmlElement(ElementName = "imrnRange", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.DNRange> ImrnRange { get; set; }
 }
}
