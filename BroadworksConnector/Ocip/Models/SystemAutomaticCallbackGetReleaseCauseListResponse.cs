using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCallbackGetReleaseCauseListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "releaseCause", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AutomaticCallbackReleaseCause> ReleaseCause { get; set; }
 }
}
