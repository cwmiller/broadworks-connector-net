using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMeetMeConferencingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "conferenceIdLength", IsNullable = false)]
    public int ConferenceIdLength { get; set; }
    [XmlElement(ElementName = "moderatorPinLength", IsNullable = false)]
    public int ModeratorPinLength { get; set; }
    [XmlElement(ElementName = "enableConferenceEndDateRestriction", IsNullable = false)]
    public bool EnableConferenceEndDateRestriction { get; set; }
    [XmlElement(ElementName = "conferenceEndDateRestrictionMonths", IsNullable = false)]
    public int ConferenceEndDateRestrictionMonths { get; set; }
    [XmlElement(ElementName = "deleteExpiredConferencesAfterHoldPeriod", IsNullable = false)]
    public bool DeleteExpiredConferencesAfterHoldPeriod { get; set; }
    [XmlElement(ElementName = "expiredConferenceHoldPeriodDays", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingExpiredConferenceHoldPeriodDays ExpiredConferenceHoldPeriodDays { get; set; }
    [XmlElement(ElementName = "recordingWebAppURL", IsNullable = false)]
    public string RecordingWebAppURL { get; set; }
 }
}
