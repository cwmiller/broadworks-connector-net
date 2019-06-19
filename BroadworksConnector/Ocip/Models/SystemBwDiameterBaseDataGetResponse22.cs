using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBwDiameterBaseDataGetRequest22.
    /// Contains a list of System Diameter base parameters.
    /// <see cref="SystemBwDiameterBaseDataGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2260""}]")]
    public class SystemBwDiameterBaseDataGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _xsRealm;

        [XmlElement(ElementName = "xsRealm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        [MinLength(1)]
        [MaxLength(80)]
        public string XsRealm
        {
            get => _xsRealm;
            set
            {
                XsRealmSpecified = true;
                _xsRealm = value;
            }
        }

        [XmlIgnore]
        public bool XsRealmSpecified { get; set; }

        private int _xsListeningPort;

        [XmlElement(ElementName = "xsListeningPort", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int XsListeningPort
        {
            get => _xsListeningPort;
            set
            {
                XsListeningPortSpecified = true;
                _xsListeningPort = value;
            }
        }

        [XmlIgnore]
        public bool XsListeningPortSpecified { get; set; }

        private bool _xsListeningPortEnabled;

        [XmlElement(ElementName = "xsListeningPortEnabled", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        public bool XsListeningPortEnabled
        {
            get => _xsListeningPortEnabled;
            set
            {
                XsListeningPortEnabledSpecified = true;
                _xsListeningPortEnabled = value;
            }
        }

        [XmlIgnore]
        public bool XsListeningPortEnabledSpecified { get; set; }

        private int _xsListeningSecurePort;

        [XmlElement(ElementName = "xsListeningSecurePort", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int XsListeningSecurePort
        {
            get => _xsListeningSecurePort;
            set
            {
                XsListeningSecurePortSpecified = true;
                _xsListeningSecurePort = value;
            }
        }

        [XmlIgnore]
        public bool XsListeningSecurePortSpecified { get; set; }

        private bool _xsListeningSecurePortEnabled;

        [XmlElement(ElementName = "xsListeningSecurePortEnabled", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        public bool XsListeningSecurePortEnabled
        {
            get => _xsListeningSecurePortEnabled;
            set
            {
                XsListeningSecurePortEnabledSpecified = true;
                _xsListeningSecurePortEnabled = value;
            }
        }

        [XmlIgnore]
        public bool XsListeningSecurePortEnabledSpecified { get; set; }

        private string _psRealm;

        [XmlElement(ElementName = "psRealm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        [MinLength(1)]
        [MaxLength(80)]
        public string PsRealm
        {
            get => _psRealm;
            set
            {
                PsRealmSpecified = true;
                _psRealm = value;
            }
        }

        [XmlIgnore]
        public bool PsRealmSpecified { get; set; }

        private int _psListeningPort;

        [XmlElement(ElementName = "psListeningPort", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int PsListeningPort
        {
            get => _psListeningPort;
            set
            {
                PsListeningPortSpecified = true;
                _psListeningPort = value;
            }
        }

        [XmlIgnore]
        public bool PsListeningPortSpecified { get; set; }

        private bool _psListeningPortEnabled;

        [XmlElement(ElementName = "psListeningPortEnabled", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        public bool PsListeningPortEnabled
        {
            get => _psListeningPortEnabled;
            set
            {
                PsListeningPortEnabledSpecified = true;
                _psListeningPortEnabled = value;
            }
        }

        [XmlIgnore]
        public bool PsListeningPortEnabledSpecified { get; set; }

        private int _psListeningSecurePort;

        [XmlElement(ElementName = "psListeningSecurePort", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int PsListeningSecurePort
        {
            get => _psListeningSecurePort;
            set
            {
                PsListeningSecurePortSpecified = true;
                _psListeningSecurePort = value;
            }
        }

        [XmlIgnore]
        public bool PsListeningSecurePortSpecified { get; set; }

        private bool _psListeningSecurePortEnabled;

        [XmlElement(ElementName = "psListeningSecurePortEnabled", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        public bool PsListeningSecurePortEnabled
        {
            get => _psListeningSecurePortEnabled;
            set
            {
                PsListeningSecurePortEnabledSpecified = true;
                _psListeningSecurePortEnabled = value;
            }
        }

        [XmlIgnore]
        public bool PsListeningSecurePortEnabledSpecified { get; set; }

        private bool _psRelayThroughXs;

        [XmlElement(ElementName = "psRelayThroughXs", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        public bool PsRelayThroughXs
        {
            get => _psRelayThroughXs;
            set
            {
                PsRelayThroughXsSpecified = true;
                _psRelayThroughXs = value;
            }
        }

        [XmlIgnore]
        public bool PsRelayThroughXsSpecified { get; set; }

        private int _xsRelayListeningPort;

        [XmlElement(ElementName = "xsRelayListeningPort", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int XsRelayListeningPort
        {
            get => _xsRelayListeningPort;
            set
            {
                XsRelayListeningPortSpecified = true;
                _xsRelayListeningPort = value;
            }
        }

        [XmlIgnore]
        public bool XsRelayListeningPortSpecified { get; set; }

        private int _tcTimerSeconds;

        [XmlElement(ElementName = "tcTimerSeconds", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        [MinInclusive(1)]
        [MaxInclusive(3600)]
        public int TcTimerSeconds
        {
            get => _tcTimerSeconds;
            set
            {
                TcTimerSecondsSpecified = true;
                _tcTimerSeconds = value;
            }
        }

        [XmlIgnore]
        public bool TcTimerSecondsSpecified { get; set; }

        private int _twTimerSeconds;

        [XmlElement(ElementName = "twTimerSeconds", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        [MinInclusive(6)]
        [MaxInclusive(60)]
        public int TwTimerSeconds
        {
            get => _twTimerSeconds;
            set
            {
                TwTimerSecondsSpecified = true;
                _twTimerSeconds = value;
            }
        }

        [XmlIgnore]
        public bool TwTimerSecondsSpecified { get; set; }

        private int _requestTimerSeconds;

        [XmlElement(ElementName = "requestTimerSeconds", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        [MinInclusive(1)]
        [MaxInclusive(600)]
        public int RequestTimerSeconds
        {
            get => _requestTimerSeconds;
            set
            {
                RequestTimerSecondsSpecified = true;
                _requestTimerSeconds = value;
            }
        }

        [XmlIgnore]
        public bool RequestTimerSecondsSpecified { get; set; }

        private int _busyPeerDetectionOutstandingTxnCount;

        [XmlElement(ElementName = "busyPeerDetectionOutstandingTxnCount", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        [MinInclusive(1)]
        [MaxInclusive(1000000)]
        public int BusyPeerDetectionOutstandingTxnCount
        {
            get => _busyPeerDetectionOutstandingTxnCount;
            set
            {
                BusyPeerDetectionOutstandingTxnCountSpecified = true;
                _busyPeerDetectionOutstandingTxnCount = value;
            }
        }

        [XmlIgnore]
        public bool BusyPeerDetectionOutstandingTxnCountSpecified { get; set; }

        private int _busyPeerRestoreOutstandingTxnCount;

        [XmlElement(ElementName = "busyPeerRestoreOutstandingTxnCount", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        [MinInclusive(1)]
        [MaxInclusive(1000000)]
        public int BusyPeerRestoreOutstandingTxnCount
        {
            get => _busyPeerRestoreOutstandingTxnCount;
            set
            {
                BusyPeerRestoreOutstandingTxnCountSpecified = true;
                _busyPeerRestoreOutstandingTxnCount = value;
            }
        }

        [XmlIgnore]
        public bool BusyPeerRestoreOutstandingTxnCountSpecified { get; set; }

        private int _dynamicEntryInactivityTimerHours;

        [XmlElement(ElementName = "dynamicEntryInactivityTimerHours", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        [MinInclusive(1)]
        [MaxInclusive(168)]
        public int DynamicEntryInactivityTimerHours
        {
            get => _dynamicEntryInactivityTimerHours;
            set
            {
                DynamicEntryInactivityTimerHoursSpecified = true;
                _dynamicEntryInactivityTimerHours = value;
            }
        }

        [XmlIgnore]
        public bool DynamicEntryInactivityTimerHoursSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.BwDiameterAdvertisedApplication _advertisedOfflineBillingApplication;

        [XmlElement(ElementName = "advertisedOfflineBillingApplication", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        public BroadWorksConnector.Ocip.Models.BwDiameterAdvertisedApplication AdvertisedOfflineBillingApplication
        {
            get => _advertisedOfflineBillingApplication;
            set
            {
                AdvertisedOfflineBillingApplicationSpecified = true;
                _advertisedOfflineBillingApplication = value;
            }
        }

        [XmlIgnore]
        public bool AdvertisedOfflineBillingApplicationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.BwDiameterAdvertisedApplication _advertisedOnlineBillingApplication;

        [XmlElement(ElementName = "advertisedOnlineBillingApplication", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        public BroadWorksConnector.Ocip.Models.BwDiameterAdvertisedApplication AdvertisedOnlineBillingApplication
        {
            get => _advertisedOnlineBillingApplication;
            set
            {
                AdvertisedOnlineBillingApplicationSpecified = true;
                _advertisedOnlineBillingApplication = value;
            }
        }

        [XmlIgnore]
        public bool AdvertisedOnlineBillingApplicationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DiameterPeerDiscoveryMode _peerDiscoveryMode;

        [XmlElement(ElementName = "peerDiscoveryMode", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        public BroadWorksConnector.Ocip.Models.DiameterPeerDiscoveryMode PeerDiscoveryMode
        {
            get => _peerDiscoveryMode;
            set
            {
                PeerDiscoveryModeSpecified = true;
                _peerDiscoveryMode = value;
            }
        }

        [XmlIgnore]
        public bool PeerDiscoveryModeSpecified { get; set; }

        private int _defaultPort;

        [XmlElement(ElementName = "defaultPort", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int DefaultPort
        {
            get => _defaultPort;
            set
            {
                DefaultPortSpecified = true;
                _defaultPort = value;
            }
        }

        [XmlIgnore]
        public bool DefaultPortSpecified { get; set; }

        private int _defaultSecurePort;

        [XmlElement(ElementName = "defaultSecurePort", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2260")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int DefaultSecurePort
        {
            get => _defaultSecurePort;
            set
            {
                DefaultSecurePortSpecified = true;
                _defaultSecurePort = value;
            }
        }

        [XmlIgnore]
        public bool DefaultSecurePortSpecified { get; set; }

    }
}
