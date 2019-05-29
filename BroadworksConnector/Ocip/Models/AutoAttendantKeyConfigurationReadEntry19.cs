using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AutoAttendantKeyConfigurationReadEntry19 
{
    [XmlElement(ElementName = "description", IsNullable = false)]
    public string Description { get; set; }
    [XmlElement(ElementName = "action", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AutoAttendantKeyAction Action { get; set; }
    [XmlElement(ElementName = "phoneNumber", IsNullable = false)]
    public string PhoneNumber { get; set; }
    [XmlElement(ElementName = "audioFileDescription", IsNullable = false)]
    public string AudioFileDescription { get; set; }
    [XmlElement(ElementName = "audioMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType AudioMediaType { get; set; }
    [XmlElement(ElementName = "videoFileDescription", IsNullable = false)]
    public string VideoFileDescription { get; set; }
    [XmlElement(ElementName = "videoMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType VideoMediaType { get; set; }
    [XmlElement(ElementName = "submenuId", IsNullable = false)]
    public string SubmenuId { get; set; }
 }
}
