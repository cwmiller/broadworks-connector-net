using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemClientSessionParametersGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableInactivityTimeout", IsNullable = false)]
    public bool EnableInactivityTimeout { get; set; }
    [XmlElement(ElementName = "inactivityTimeoutMinutes", IsNullable = false)]
    public int InactivityTimeoutMinutes { get; set; }
 }
}
