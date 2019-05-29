using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressRedirectionWithException 
{
    [XmlElement(ElementName = "sendCallsToVoiceMailExceptExcludedNumbers", IsNullable = false)]
    public bool SendCallsToVoiceMailExceptExcludedNumbers { get; set; }
    [XmlElement(ElementName = "excludedPhoneNumber01", IsNullable = false)]
    public string ExcludedPhoneNumber01 { get; set; }
    [XmlElement(ElementName = "excludedPhoneNumber02", IsNullable = false)]
    public string ExcludedPhoneNumber02 { get; set; }
    [XmlElement(ElementName = "excludedPhoneNumber03", IsNullable = false)]
    public string ExcludedPhoneNumber03 { get; set; }
    [XmlElement(ElementName = "forwardExcludedNumbersTo", IsNullable = false)]
    public string ForwardExcludedNumbersTo { get; set; }
 }
}
