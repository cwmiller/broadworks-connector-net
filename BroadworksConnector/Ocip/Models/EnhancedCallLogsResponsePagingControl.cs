using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnhancedCallLogsResponsePagingControl 
{
    [XmlElement(ElementName = "responseStartIndex", IsNullable = false)]
    public int ResponseStartIndex { get; set; }
    [XmlElement(ElementName = "responsePageSize", IsNullable = false)]
    public int ResponsePageSize { get; set; }
 }
}
