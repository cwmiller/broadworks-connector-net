using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AutoAttendantKeyConfigurationModifyEntry20 
{
    [XmlElement(ElementName = "description", IsNullable = true)]
    public string Description { get; set; }
    [XmlElement(ElementName = "action", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantKeyAction Action { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = true)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey AudioFile { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey VideoFile { get; set; }
    [XmlElement(ElementName = "submenuId", IsNullable = true)]
    public string SubmenuId { get; set; }
 }
}
