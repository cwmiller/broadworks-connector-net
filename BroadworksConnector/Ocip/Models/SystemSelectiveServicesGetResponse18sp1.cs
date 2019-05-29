using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSelectiveServicesGetResponse18sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "scheduleCombination", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ScheduleCombinationType ScheduleCombination { get; set; }
    [XmlElement(ElementName = "screenPrivateNumber", IsNullable = false)]
    public bool ScreenPrivateNumber { get; set; }
 }
}
