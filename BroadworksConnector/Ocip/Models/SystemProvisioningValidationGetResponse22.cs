using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemProvisioningValidationGetResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "isNetworkServerQueryActive", IsNullable = false)]
    public bool IsNetworkServerQueryActive { get; set; }
    [XmlElement(ElementName = "timeoutSeconds", IsNullable = false)]
    public int TimeoutSeconds { get; set; }
    [XmlElement(ElementName = "denyMobilityNumberAsRedirectionDestination", IsNullable = false)]
    public bool DenyMobilityNumberAsRedirectionDestination { get; set; }
    [XmlElement(ElementName = "denyEnterpriseNumberAsNetworkLocationDestination", IsNullable = false)]
    public bool DenyEnterpriseNumberAsNetworkLocationDestination { get; set; }
 }
}
