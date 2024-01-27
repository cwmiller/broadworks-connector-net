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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2683""}]")]
    public class SystemBwDiameterBaseDataGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _xsRealm;

        [XmlElement(ElementName = "xsRealm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool XsRealmSpecified { get; set; }

        protected int _xsListeningPort;

        [XmlElement(ElementName = "xsListeningPort", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool XsListeningPortSpecified { get; set; }

        protected bool _xsListeningPortEnabled;

        [XmlElement(ElementName = "xsListeningPortEnabled", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool XsListeningPortEnabledSpecified { get; set; }

        protected int _xsListeningSecurePort;

        [XmlElement(ElementName = "xsListeningSecurePort", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool XsListeningSecurePortSpecified { get; set; }

        protected bool _xsListeningSecurePortEnabled;

        [XmlElement(ElementName = "xsListeningSecurePortEnabled", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool XsListeningSecurePortEnabledSpecified { get; set; }

        protected string _psRealm;

        [XmlElement(ElementName = "psRealm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool PsRealmSpecified { get; set; }

        protected int _psListeningPort;

        [XmlElement(ElementName = "psListeningPort", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool PsListeningPortSpecified { get; set; }

        protected bool _psListeningPortEnabled;

        [XmlElement(ElementName = "psListeningPortEnabled", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool PsListeningPortEnabledSpecified { get; set; }

        protected int _psListeningSecurePort;

        [XmlElement(ElementName = "psListeningSecurePort", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool PsListeningSecurePortSpecified { get; set; }

        protected bool _psListeningSecurePortEnabled;

        [XmlElement(ElementName = "psListeningSecurePortEnabled", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool PsListeningSecurePortEnabledSpecified { get; set; }

        protected bool _psRelayThroughXs;

        [XmlElement(ElementName = "psRelayThroughXs", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool PsRelayThroughXsSpecified { get; set; }

        protected int _xsRelayListeningPort;

        [XmlElement(ElementName = "xsRelayListeningPort", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool XsRelayListeningPortSpecified { get; set; }

        protected int _tcTimerSeconds;

        [XmlElement(ElementName = "tcTimerSeconds", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool TcTimerSecondsSpecified { get; set; }

        protected int _twTimerSeconds;

        [XmlElement(ElementName = "twTimerSeconds", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool TwTimerSecondsSpecified { get; set; }

        protected int _requestTimerSeconds;

        [XmlElement(ElementName = "requestTimerSeconds", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool RequestTimerSecondsSpecified { get; set; }

        protected int _busyPeerDetectionOutstandingTxnCount;

        [XmlElement(ElementName = "busyPeerDetectionOutstandingTxnCount", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool BusyPeerDetectionOutstandingTxnCountSpecified { get; set; }

        protected int _busyPeerRestoreOutstandingTxnCount;

        [XmlElement(ElementName = "busyPeerRestoreOutstandingTxnCount", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool BusyPeerRestoreOutstandingTxnCountSpecified { get; set; }

        protected int _dynamicEntryInactivityTimerHours;

        [XmlElement(ElementName = "dynamicEntryInactivityTimerHours", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool DynamicEntryInactivityTimerHoursSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.BwDiameterAdvertisedApplication _advertisedOfflineBillingApplication;

        [XmlElement(ElementName = "advertisedOfflineBillingApplication", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool AdvertisedOfflineBillingApplicationSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.BwDiameterAdvertisedApplication _advertisedOnlineBillingApplication;

        [XmlElement(ElementName = "advertisedOnlineBillingApplication", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool AdvertisedOnlineBillingApplicationSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DiameterPeerDiscoveryMode _peerDiscoveryMode;

        [XmlElement(ElementName = "peerDiscoveryMode", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool PeerDiscoveryModeSpecified { get; set; }

        protected int _defaultPort;

        [XmlElement(ElementName = "defaultPort", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool DefaultPortSpecified { get; set; }

        protected int _defaultSecurePort;

        [XmlElement(ElementName = "defaultSecurePort", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2683")]
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
        protected bool DefaultSecurePortSpecified { get; set; }

    }
}
