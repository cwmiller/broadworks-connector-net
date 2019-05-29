using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExecutiveGetScreeningAlertingResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableScreening", IsNullable = false)]
    public bool EnableScreening { get; set; }
    [XmlElement(ElementName = "screeningAlertType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExecutiveScreeningAlertType ScreeningAlertType { get; set; }
    [XmlElement(ElementName = "alertBroadWorksMobilityLocation", IsNullable = false)]
    public bool AlertBroadWorksMobilityLocation { get; set; }
    [XmlElement(ElementName = "alertBroadWorksAnywhereLocations", IsNullable = false)]
    public bool AlertBroadWorksAnywhereLocations { get; set; }
    [XmlElement(ElementName = "alertSharedCallAppearanceLocations", IsNullable = false)]
    public bool AlertSharedCallAppearanceLocations { get; set; }
    [XmlElement(ElementName = "alertingMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExecutiveAlertingMode AlertingMode { get; set; }
    [XmlElement(ElementName = "alertingCallingLineIdNameMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExecutiveAlertingCallingLineIdNameMode AlertingCallingLineIdNameMode { get; set; }
    [XmlElement(ElementName = "alertingCustomCallingLineIdName", IsNullable = false)]
    public string AlertingCustomCallingLineIdName { get; set; }
    [XmlElement(ElementName = "unicodeAlertingCustomCallingLineIdName", IsNullable = false)]
    public string UnicodeAlertingCustomCallingLineIdName { get; set; }
    [XmlElement(ElementName = "alertingCallingLineIdPhoneNumberMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExecutiveAlertingCallingLineIdPhoneNumberMode AlertingCallingLineIdPhoneNumberMode { get; set; }
    [XmlElement(ElementName = "alertingCustomCallingLineIdPhoneNumber", IsNullable = false)]
    public string AlertingCustomCallingLineIdPhoneNumber { get; set; }
    [XmlElement(ElementName = "callPushRecallNumberOfRings", IsNullable = false)]
    public int CallPushRecallNumberOfRings { get; set; }
    [XmlElement(ElementName = "nextAssistantNumberOfRings", IsNullable = false)]
    public int NextAssistantNumberOfRings { get; set; }
    [XmlElement(ElementName = "enableRollover", IsNullable = false)]
    public bool EnableRollover { get; set; }
    [XmlElement(ElementName = "rolloverWaitTimeSeconds", IsNullable = false)]
    public int RolloverWaitTimeSeconds { get; set; }
    [XmlElement(ElementName = "rolloverAction", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExecutiveRolloverActionType RolloverAction { get; set; }
    [XmlElement(ElementName = "rolloverForwardToPhoneNumber", IsNullable = false)]
    public string RolloverForwardToPhoneNumber { get; set; }
 }
}
