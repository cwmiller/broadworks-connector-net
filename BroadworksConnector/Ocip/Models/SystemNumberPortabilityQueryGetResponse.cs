using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "continueCallAsDialedOnTimeoutOrError", IsNullable = false)]
    public bool ContinueCallAsDialedOnTimeoutOrError { get; set; }
    [XmlElement(ElementName = "numberPortabilityNameLookupTimeoutMilliseconds", IsNullable = false)]
    public int NumberPortabilityNameLookupTimeoutMilliseconds { get; set; }
 }
}
