using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCallbackDeleteReleaseCauseListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "releaseCause", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AutomaticCallbackReleaseCause> ReleaseCause { get; set; }
 }
}
