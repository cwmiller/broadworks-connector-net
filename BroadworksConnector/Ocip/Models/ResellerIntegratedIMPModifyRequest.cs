using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerIntegratedIMPModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "resellerId", IsNullable = false)]
    public string ResellerId { get; set; }
    [XmlElement(ElementName = "useSystemServiceDomain", IsNullable = false)]
    public bool UseSystemServiceDomain { get; set; }
    [XmlElement(ElementName = "serviceDomain", IsNullable = true)]
    public string ServiceDomain { get; set; }
    [XmlElement(ElementName = "servicePort", IsNullable = true)]
    public int? ServicePort { get; set; }
    [XmlElement(ElementName = "useSystemMessagingServer", IsNullable = false)]
    public bool UseSystemMessagingServer { get; set; }
    [XmlElement(ElementName = "provisioningUrl", IsNullable = true)]
    public string ProvisioningUrl { get; set; }
    [XmlElement(ElementName = "provisioningUserId", IsNullable = true)]
    public string ProvisioningUserId { get; set; }
    [XmlElement(ElementName = "provisioningPassword", IsNullable = true)]
    public string ProvisioningPassword { get; set; }
    [XmlElement(ElementName = "boshURL", IsNullable = true)]
    public string BoshURL { get; set; }
    [XmlElement(ElementName = "defaultImpIdType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.IntegratedIMPUserIDType DefaultImpIdType { get; set; }
 }
}
