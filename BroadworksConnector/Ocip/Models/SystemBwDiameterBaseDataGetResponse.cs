using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterBaseDataGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "xsRealm", IsNullable = false)]
    public string XsRealm { get; set; }
    [XmlElement(ElementName = "xsListeningPort", IsNullable = false)]
    public int XsListeningPort { get; set; }
    [XmlElement(ElementName = "psRealm", IsNullable = false)]
    public string PsRealm { get; set; }
    [XmlElement(ElementName = "psListeningPort", IsNullable = false)]
    public int PsListeningPort { get; set; }
    [XmlElement(ElementName = "psRelayThroughXs", IsNullable = false)]
    public bool PsRelayThroughXs { get; set; }
    [XmlElement(ElementName = "xsRelayListeningPort", IsNullable = false)]
    public int XsRelayListeningPort { get; set; }
    [XmlElement(ElementName = "tcTimerSeconds", IsNullable = false)]
    public int TcTimerSeconds { get; set; }
    [XmlElement(ElementName = "twTimerSeconds", IsNullable = false)]
    public int TwTimerSeconds { get; set; }
    [XmlElement(ElementName = "requestTimerSeconds", IsNullable = false)]
    public int RequestTimerSeconds { get; set; }
    [XmlElement(ElementName = "busyPeerDetectionOutstandingTxnCount", IsNullable = false)]
    public int BusyPeerDetectionOutstandingTxnCount { get; set; }
    [XmlElement(ElementName = "busyPeerRestoreOutstandingTxnCount", IsNullable = false)]
    public int BusyPeerRestoreOutstandingTxnCount { get; set; }
    [XmlElement(ElementName = "dynamicEntryInactivityTimerHours", IsNullable = false)]
    public int DynamicEntryInactivityTimerHours { get; set; }
 }
}
