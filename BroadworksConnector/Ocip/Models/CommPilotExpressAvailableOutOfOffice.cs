using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressAvailableOutOfOffice 
{
    [XmlElement(ElementName = "incomingCalls", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressRedirection IncomingCalls { get; set; }
    [XmlElement(ElementName = "incomingCallNotify", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressEmailNotify IncomingCallNotify { get; set; }
 }
}
