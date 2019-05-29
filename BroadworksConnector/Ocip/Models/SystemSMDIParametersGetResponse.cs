using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSMDIParametersGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableSMDI", IsNullable = false)]
    public bool EnableSMDI { get; set; }
    [XmlElement(ElementName = "listeningPort", IsNullable = false)]
    public int ListeningPort { get; set; }
    [XmlElement(ElementName = "maxConnections", IsNullable = false)]
    public int MaxConnections { get; set; }
 }
}
