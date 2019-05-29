using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSecurityClassificationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "meetMeAnncThreshold", IsNullable = false)]
    public int MeetMeAnncThreshold { get; set; }
    [XmlElement(ElementName = "SecurityClassificationTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SecurityClassificationTable { get; set; }
 }
}
