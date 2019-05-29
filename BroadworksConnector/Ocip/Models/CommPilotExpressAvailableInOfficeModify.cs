using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressAvailableInOfficeModify 
{
    [XmlElement(ElementName = "additionalPhoneNumberToRing", IsNullable = true)]
    public string AdditionalPhoneNumberToRing { get; set; }
    [XmlElement(ElementName = "busySetting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressRedirectionModify BusySetting { get; set; }
    [XmlElement(ElementName = "noAnswerSetting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CommPilotExpressRedirectionModify NoAnswerSetting { get; set; }
 }
}
