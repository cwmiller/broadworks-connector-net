using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressRedirectionWithExceptionModify 
{
    [XmlElement(ElementName = "sendCallsToVoiceMailExceptExcludedNumbers", IsNullable = false)]
    public bool SendCallsToVoiceMailExceptExcludedNumbers { get; set; }
    [XmlElement(ElementName = "excludedPhoneNumber01", IsNullable = true)]
    public string ExcludedPhoneNumber01 { get; set; }
    [XmlElement(ElementName = "excludedPhoneNumber02", IsNullable = true)]
    public string ExcludedPhoneNumber02 { get; set; }
    [XmlElement(ElementName = "excludedPhoneNumber03", IsNullable = true)]
    public string ExcludedPhoneNumber03 { get; set; }
    [XmlElement(ElementName = "forwardExcludedNumbersTo", IsNullable = true)]
    public string ForwardExcludedNumbersTo { get; set; }
 }
}
