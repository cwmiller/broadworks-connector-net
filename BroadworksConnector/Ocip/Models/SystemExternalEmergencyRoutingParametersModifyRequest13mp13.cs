using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemExternalEmergencyRoutingParametersModifyRequest13mp13 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceURI", IsNullable = true)]
    public string ServiceURI { get; set; }
    [XmlElement(ElementName = "defaultEmergencyNumber", IsNullable = true)]
    public string DefaultEmergencyNumber { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "supportsDNSSRV", IsNullable = false)]
    public bool SupportsDNSSRV { get; set; }
    [XmlElement(ElementName = "connectionTimeoutSeconds", IsNullable = false)]
    public int ConnectionTimeoutSeconds { get; set; }
 }
}
