using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAnnouncementRepositoryGetSettingsResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "totalFileSize", IsNullable = false)]
    public int TotalFileSize { get; set; }
    [XmlElement(ElementName = "maxAudioFileSize", IsNullable = false)]
    public int MaxAudioFileSize { get; set; }
    [XmlElement(ElementName = "maxVideoFileSize", IsNullable = false)]
    public int MaxVideoFileSize { get; set; }
    [XmlElement(ElementName = "maxFileSize", IsNullable = false)]
    public int MaxFileSize { get; set; }
 }
}
