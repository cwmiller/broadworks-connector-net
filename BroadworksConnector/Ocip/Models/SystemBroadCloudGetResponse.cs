using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadCloudGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "provisioningUrl", IsNullable = false)]
    public string ProvisioningUrl { get; set; }
    [XmlElement(ElementName = "provisioningUserId", IsNullable = false)]
    public string ProvisioningUserId { get; set; }
    [XmlElement(ElementName = "enableSynchronization", IsNullable = false)]
    public bool EnableSynchronization { get; set; }
 }
}
