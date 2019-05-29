using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterHolidayServiceModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "action", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterScheduledServiceAction Action { get; set; }
    [XmlElement(ElementName = "holidaySchedule", IsNullable = true)]
    public string HolidaySchedule { get; set; }
    [XmlElement(ElementName = "transferPhoneNumber", IsNullable = true)]
    public string TransferPhoneNumber { get; set; }
    [XmlElement(ElementName = "playAnnouncementBeforeAction", IsNullable = false)]
    public bool PlayAnnouncementBeforeAction { get; set; }
    [XmlElement(ElementName = "audioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection AudioMessageSelection { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource AudioFile { get; set; }
    [XmlElement(ElementName = "videoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection VideoMessageSelection { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource VideoFile { get; set; }
 }
}
