using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSelectiveServicesGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "scheduleCombination", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ScheduleCombinationType ScheduleCombination { get; set; }
 }
}
