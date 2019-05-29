using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "continueCallAsDialedOnTimeoutOrError", IsNullable = false)]
    public bool ContinueCallAsDialedOnTimeoutOrError { get; set; }
    [XmlElement(ElementName = "numberPortabilityNameLookupTimeoutMilliseconds", IsNullable = false)]
    public int NumberPortabilityNameLookupTimeoutMilliseconds { get; set; }
 }
}
