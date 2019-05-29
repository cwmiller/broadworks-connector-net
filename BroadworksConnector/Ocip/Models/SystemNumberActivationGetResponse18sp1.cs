using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberActivationGetResponse18sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "numberActivationMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NumberActivationMode NumberActivationMode { get; set; }
 }
}
