using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemRuntimeDataPublicationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableRuntimeDataSync", IsNullable = false)]
    public bool EnableRuntimeDataSync { get; set; }
    [XmlElement(ElementName = "runtimeDataSyncIntervalInMilliSeconds", IsNullable = false)]
    public int RuntimeDataSyncIntervalInMilliSeconds { get; set; }
 }
}
