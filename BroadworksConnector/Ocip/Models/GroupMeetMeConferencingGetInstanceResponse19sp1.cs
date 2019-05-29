using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMeetMeConferencingGetInstanceResponse19sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile { get; set; }
    [XmlElement(ElementName = "allocatedPorts", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferencePorts AllocatedPorts { get; set; }
    [XmlElement(ElementName = "networkClassOfService", IsNullable = false)]
    public string NetworkClassOfService { get; set; }
    [XmlElement(ElementName = "securityPinLength", IsNullable = false)]
    public int SecurityPinLength { get; set; }
    [XmlElement(ElementName = "allowIndividualOutDial", IsNullable = false)]
    public bool AllowIndividualOutDial { get; set; }
    [XmlElement(ElementName = "operatorNumber", IsNullable = false)]
    public string OperatorNumber { get; set; }
    [XmlElement(ElementName = "conferenceHostUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ConferenceHostUserTable { get; set; }
    [XmlElement(ElementName = "playWarningPrompt", IsNullable = false)]
    public bool PlayWarningPrompt { get; set; }
    [XmlElement(ElementName = "conferenceEndWarningPromptMinutes", IsNullable = false)]
    public int ConferenceEndWarningPromptMinutes { get; set; }
    [XmlElement(ElementName = "enableMaxConferenceDuration", IsNullable = false)]
    public bool EnableMaxConferenceDuration { get; set; }
    [XmlElement(ElementName = "maxConferenceDurationMinutes", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceDuration MaxConferenceDurationMinutes { get; set; }
    [XmlElement(ElementName = "maxScheduledConferenceDurationMinutes", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceDuration MaxScheduledConferenceDurationMinutes { get; set; }
 }
}
