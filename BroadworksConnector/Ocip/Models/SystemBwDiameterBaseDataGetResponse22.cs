using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterBaseDataGetResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "xsRealm", IsNullable = false)]
    public string XsRealm { get; set; }
    [XmlElement(ElementName = "xsListeningPort", IsNullable = false)]
    public int XsListeningPort { get; set; }
    [XmlElement(ElementName = "xsListeningPortEnabled", IsNullable = false)]
    public bool XsListeningPortEnabled { get; set; }
    [XmlElement(ElementName = "xsListeningSecurePort", IsNullable = false)]
    public int XsListeningSecurePort { get; set; }
    [XmlElement(ElementName = "xsListeningSecurePortEnabled", IsNullable = false)]
    public bool XsListeningSecurePortEnabled { get; set; }
    [XmlElement(ElementName = "psRealm", IsNullable = false)]
    public string PsRealm { get; set; }
    [XmlElement(ElementName = "psListeningPort", IsNullable = false)]
    public int PsListeningPort { get; set; }
    [XmlElement(ElementName = "psListeningPortEnabled", IsNullable = false)]
    public bool PsListeningPortEnabled { get; set; }
    [XmlElement(ElementName = "psListeningSecurePort", IsNullable = false)]
    public int PsListeningSecurePort { get; set; }
    [XmlElement(ElementName = "psListeningSecurePortEnabled", IsNullable = false)]
    public bool PsListeningSecurePortEnabled { get; set; }
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
    [XmlElement(ElementName = "advertisedOfflineBillingApplication", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BwDiameterAdvertisedApplication AdvertisedOfflineBillingApplication { get; set; }
    [XmlElement(ElementName = "advertisedOnlineBillingApplication", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.BwDiameterAdvertisedApplication AdvertisedOnlineBillingApplication { get; set; }
    [XmlElement(ElementName = "peerDiscoveryMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DiameterPeerDiscoveryMode PeerDiscoveryMode { get; set; }
    [XmlElement(ElementName = "defaultPort", IsNullable = false)]
    public int DefaultPort { get; set; }
    [XmlElement(ElementName = "defaultSecurePort", IsNullable = false)]
    public int DefaultSecurePort { get; set; }
 }
}
