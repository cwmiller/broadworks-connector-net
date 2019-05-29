using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCustomRingbackUserModifyCriteriaRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "criteriaName", IsNullable = false)]
    public string CriteriaName { get; set; }
    [XmlElement(ElementName = "newCriteriaName", IsNullable = false)]
    public string NewCriteriaName { get; set; }
    [XmlElement(ElementName = "timeSchedule", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.TimeSchedule TimeSchedule { get; set; }
    [XmlElement(ElementName = "fromDnCriteria", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CriteriaFromDnModify FromDnCriteria { get; set; }
    [XmlElement(ElementName = "audioSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection AudioSelection { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResource AudioFile { get; set; }
    [XmlElement(ElementName = "videoSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection VideoSelection { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResource VideoFile { get; set; }
    [XmlElement(ElementName = "callWaitingAudioSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection CallWaitingAudioSelection { get; set; }
    [XmlElement(ElementName = "callWaitingAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResource CallWaitingAudioFile { get; set; }
    [XmlElement(ElementName = "callWaitingVideoSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection CallWaitingVideoSelection { get; set; }
    [XmlElement(ElementName = "callWaitingVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResource CallWaitingVideoFile { get; set; }
 }
}
