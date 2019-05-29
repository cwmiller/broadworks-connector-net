using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRuntimeDataPublicationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "enableRuntimeDataSync", IsNullable = false)]
    public bool EnableRuntimeDataSync { get; set; }
    [XmlElement(ElementName = "runtimeDataSyncIntervalInMilliSeconds", IsNullable = false)]
    public int RuntimeDataSyncIntervalInMilliSeconds { get; set; }
 }
}
