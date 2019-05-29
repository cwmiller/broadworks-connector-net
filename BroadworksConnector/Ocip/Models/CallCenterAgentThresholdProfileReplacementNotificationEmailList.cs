using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterAgentThresholdProfileReplacementNotificationEmailList 
{
    [XmlElement(ElementName = "emailAddress", IsNullable = false)]
    public List<string> EmailAddress { get; set; }
 }
}
