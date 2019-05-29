using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallLogsClearRequest14sp4DeleteSpecifiedCallLogs 
{
    [XmlElement(ElementName = "placedCallLogId", IsNullable = false)]
    public List<string> PlacedCallLogId { get; set; }
    [XmlElement(ElementName = "receivedCallLogId", IsNullable = false)]
    public List<string> ReceivedCallLogId { get; set; }
    [XmlElement(ElementName = "missedCallLogId", IsNullable = false)]
    public List<string> MissedCallLogId { get; set; }
 }
}
