using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterAnnouncementFileListModify20 
{
    [XmlElement(ElementName = "file1", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey File1 { get; set; }
    [XmlElement(ElementName = "file2", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey File2 { get; set; }
    [XmlElement(ElementName = "file3", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey File3 { get; set; }
    [XmlElement(ElementName = "file4", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey File4 { get; set; }
 }
}
