using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderIntegratedIMPGetResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useSystemServiceDomain", IsNullable = false)]
    public bool UseSystemServiceDomain { get; set; }
    [XmlElement(ElementName = "serviceDomain", IsNullable = false)]
    public string ServiceDomain { get; set; }
    [XmlElement(ElementName = "servicePort", IsNullable = false)]
    public int ServicePort { get; set; }
    [XmlElement(ElementName = "useSystemMessagingServer", IsNullable = false)]
    public bool UseSystemMessagingServer { get; set; }
    [XmlElement(ElementName = "provisioningUrl", IsNullable = false)]
    public string ProvisioningUrl { get; set; }
    [XmlElement(ElementName = "provisioningUserId", IsNullable = false)]
    public string ProvisioningUserId { get; set; }
    [XmlElement(ElementName = "boshURL", IsNullable = false)]
    public string BoshURL { get; set; }
    [XmlElement(ElementName = "defaultImpIdType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.IntegratedIMPUserIDType DefaultImpIdType { get; set; }
 }
}
