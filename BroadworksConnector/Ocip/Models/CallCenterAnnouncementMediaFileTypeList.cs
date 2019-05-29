using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterAnnouncementMediaFileTypeList 
{
    [XmlElement(ElementName = "mediaType1", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType MediaType1 { get; set; }
    [XmlElement(ElementName = "mediaType2", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType MediaType2 { get; set; }
    [XmlElement(ElementName = "mediaType3", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType MediaType3 { get; set; }
    [XmlElement(ElementName = "mediaType4", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType MediaType4 { get; set; }
 }
}
