using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressAvailableInOffice 
{
    [XmlElement(ElementName = "additionalPhoneNumberToRing", IsNullable = false)]
    public string AdditionalPhoneNumberToRing { get; set; }
    [XmlElement(ElementName = "busySetting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressRedirection BusySetting { get; set; }
    [XmlElement(ElementName = "noAnswerSetting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressRedirection NoAnswerSetting { get; set; }
 }
}
