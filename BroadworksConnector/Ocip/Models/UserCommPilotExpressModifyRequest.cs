using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCommPilotExpressModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "profile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressProfile? Profile { get; set; }
    [XmlElement(ElementName = "availableInOffice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressAvailableInOfficeModify AvailableInOffice { get; set; }
    [XmlElement(ElementName = "availableOutOfOffice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressAvailableOutOfOfficeModify AvailableOutOfOffice { get; set; }
    [XmlElement(ElementName = "busy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressBusyModify Busy { get; set; }
    [XmlElement(ElementName = "unavailable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressUnavailableModify Unavailable { get; set; }
 }
}
