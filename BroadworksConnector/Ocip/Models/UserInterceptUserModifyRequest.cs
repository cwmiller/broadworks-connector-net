using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserInterceptUserModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "announcementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource AudioFile { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource VideoFile { get; set; }
    [XmlElement(ElementName = "playNewPhoneNumber", IsNullable = false)]
    public bool PlayNewPhoneNumber { get; set; }
    [XmlElement(ElementName = "newPhoneNumber", IsNullable = true)]
    public string NewPhoneNumber { get; set; }
    [XmlElement(ElementName = "transferOnZeroToPhoneNumber", IsNullable = false)]
    public bool TransferOnZeroToPhoneNumber { get; set; }
    [XmlElement(ElementName = "transferPhoneNumber", IsNullable = true)]
    public string TransferPhoneNumber { get; set; }
 }
}
