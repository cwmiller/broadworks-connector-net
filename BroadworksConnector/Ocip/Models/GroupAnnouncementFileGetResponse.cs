using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAnnouncementFileGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "filesize", IsNullable = false)]
    public int Filesize { get; set; }
    [XmlElement(ElementName = "lastUploaded", IsNullable = false)]
    public string LastUploaded { get; set; }
    [XmlElement(ElementName = "usageTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UsageTable { get; set; }
 }
}
