using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemIntegratedIMPGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceDomain", IsNullable = false)]
    public string ServiceDomain { get; set; }
    [XmlElement(ElementName = "servicePort", IsNullable = false)]
    public int ServicePort { get; set; }
    [XmlElement(ElementName = "addServiceProviderInIMPUserId", IsNullable = false)]
    public bool AddServiceProviderInIMPUserId { get; set; }
 }
}
