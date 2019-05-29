using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemIntegratedIMPModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceDomain", IsNullable = true)]
    public string ServiceDomain { get; set; }
    [XmlElement(ElementName = "servicePort", IsNullable = true)]
    public int? ServicePort { get; set; }
    [XmlElement(ElementName = "addServiceProviderInIMPUserId", IsNullable = false)]
    public bool AddServiceProviderInIMPUserId { get; set; }
    [XmlElement(ElementName = "boshURL", IsNullable = true)]
    public string BoshURL { get; set; }
    [XmlElement(ElementName = "allowImpPasswordRetrieval", IsNullable = false)]
    public bool AllowImpPasswordRetrieval { get; set; }
 }
}
