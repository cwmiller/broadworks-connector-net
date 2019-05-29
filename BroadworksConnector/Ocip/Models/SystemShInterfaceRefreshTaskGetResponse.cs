using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemShInterfaceRefreshTaskGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isRunning", IsNullable = false)]
    public bool IsRunning { get; set; }
    [XmlElement(ElementName = "numberPublicIdentityRefreshesStarted", IsNullable = false)]
    public int NumberPublicIdentityRefreshesStarted { get; set; }
    [XmlElement(ElementName = "numberPublicIdentities", IsNullable = false)]
    public int NumberPublicIdentities { get; set; }
 }
}
