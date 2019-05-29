using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCommPilotExpressGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "profile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressProfile Profile { get; set; }
    [XmlElement(ElementName = "availableInOffice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressAvailableInOffice AvailableInOffice { get; set; }
    [XmlElement(ElementName = "availableOutOfOffice", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressAvailableOutOfOffice AvailableOutOfOffice { get; set; }
    [XmlElement(ElementName = "busy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressBusy Busy { get; set; }
    [XmlElement(ElementName = "unavailable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressUnavailable Unavailable { get; set; }
 }
}
