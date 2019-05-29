using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadCloudModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "provisioningUrl", IsNullable = true)]
    public string ProvisioningUrl { get; set; }
    [XmlElement(ElementName = "provisioningUserId", IsNullable = true)]
    public string ProvisioningUserId { get; set; }
    [XmlElement(ElementName = "provisioningPassword", IsNullable = true)]
    public string ProvisioningPassword { get; set; }
    [XmlElement(ElementName = "enableSynchronization", IsNullable = false)]
    public bool EnableSynchronization { get; set; }
 }
}
