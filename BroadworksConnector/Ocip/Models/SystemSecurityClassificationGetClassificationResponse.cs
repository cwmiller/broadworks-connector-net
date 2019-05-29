using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSecurityClassificationGetClassificationResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "audioAnnouncementFileDescription", IsNullable = false)]
    public string AudioAnnouncementFileDescription { get; set; }
    [XmlElement(ElementName = "audioAnnouncementFileType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType AudioAnnouncementFileType { get; set; }
 }
}
