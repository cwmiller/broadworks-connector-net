using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterCallDispositionCodeModifyActiveListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "callDispositionCodeActivation", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallDispositionCodeActivation> CallDispositionCodeActivation { get; set; }
 }
}
