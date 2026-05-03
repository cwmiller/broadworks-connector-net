using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the System Diameter base parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2766""}]")]
    public class SystemBwDiameterBaseDataModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _xsRealm;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "xsRealm", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
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

        protected int? _xsListeningPort;

        [XmlElement(ElementName = "xsListeningPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int? XsListeningPort
        {
            get => _xsListeningPort;
            set
            {
                XsListeningPortSpecified = (value != null);
                _xsListeningPort = value;
            }
        }

        [XmlIgnore]
        protected bool XsListeningPortSpecified { get; set; }

        protected bool? _xsListeningPortEnabled;

        [XmlElement(ElementName = "xsListeningPortEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        public bool? XsListeningPortEnabled
        {
            get => _xsListeningPortEnabled;
            set
            {
                XsListeningPortEnabledSpecified = (value != null);
                _xsListeningPortEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool XsListeningPortEnabledSpecified { get; set; }

        protected int? _xsListeningSecurePort;

        [XmlElement(ElementName = "xsListeningSecurePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int? XsListeningSecurePort
        {
            get => _xsListeningSecurePort;
            set
            {
                XsListeningSecurePortSpecified = (value != null);
                _xsListeningSecurePort = value;
            }
        }

        [XmlIgnore]
        protected bool XsListeningSecurePortSpecified { get; set; }

        protected bool? _xsListeningSecurePortEnabled;

        [XmlElement(ElementName = "xsListeningSecurePortEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        public bool? XsListeningSecurePortEnabled
        {
            get => _xsListeningSecurePortEnabled;
            set
            {
                XsListeningSecurePortEnabledSpecified = (value != null);
                _xsListeningSecurePortEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool XsListeningSecurePortEnabledSpecified { get; set; }

        protected string _psRealm;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "psRealm", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
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

        protected int? _psListeningPort;

        [XmlElement(ElementName = "psListeningPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int? PsListeningPort
        {
            get => _psListeningPort;
            set
            {
                PsListeningPortSpecified = (value != null);
                _psListeningPort = value;
            }
        }

        [XmlIgnore]
        protected bool PsListeningPortSpecified { get; set; }

        protected bool? _psListeningPortEnabled;

        [XmlElement(ElementName = "psListeningPortEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        public bool? PsListeningPortEnabled
        {
            get => _psListeningPortEnabled;
            set
            {
                PsListeningPortEnabledSpecified = (value != null);
                _psListeningPortEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool PsListeningPortEnabledSpecified { get; set; }

        protected int? _psListeningSecurePort;

        [XmlElement(ElementName = "psListeningSecurePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int? PsListeningSecurePort
        {
            get => _psListeningSecurePort;
            set
            {
                PsListeningSecurePortSpecified = (value != null);
                _psListeningSecurePort = value;
            }
        }

        [XmlIgnore]
        protected bool PsListeningSecurePortSpecified { get; set; }

        protected bool? _psListeningSecurePortEnabled;

        [XmlElement(ElementName = "psListeningSecurePortEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        public bool? PsListeningSecurePortEnabled
        {
            get => _psListeningSecurePortEnabled;
            set
            {
                PsListeningSecurePortEnabledSpecified = (value != null);
                _psListeningSecurePortEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool PsListeningSecurePortEnabledSpecified { get; set; }

        protected bool? _psRelayThroughXs;

        [XmlElement(ElementName = "psRelayThroughXs", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        public bool? PsRelayThroughXs
        {
            get => _psRelayThroughXs;
            set
            {
                PsRelayThroughXsSpecified = (value != null);
                _psRelayThroughXs = value;
            }
        }

        [XmlIgnore]
        protected bool PsRelayThroughXsSpecified { get; set; }

        protected int? _xsRelayListeningPort;

        [XmlElement(ElementName = "xsRelayListeningPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int? XsRelayListeningPort
        {
            get => _xsRelayListeningPort;
            set
            {
                XsRelayListeningPortSpecified = (value != null);
                _xsRelayListeningPort = value;
            }
        }

        [XmlIgnore]
        protected bool XsRelayListeningPortSpecified { get; set; }

        protected int? _tcTimerSeconds;

        [XmlElement(ElementName = "tcTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        [MinInclusive(1)]
        [MaxInclusive(3600)]
        public int? TcTimerSeconds
        {
            get => _tcTimerSeconds;
            set
            {
                TcTimerSecondsSpecified = (value != null);
                _tcTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TcTimerSecondsSpecified { get; set; }

        protected int? _twTimerSeconds;

        [XmlElement(ElementName = "twTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        [MinInclusive(6)]
        [MaxInclusive(60)]
        public int? TwTimerSeconds
        {
            get => _twTimerSeconds;
            set
            {
                TwTimerSecondsSpecified = (value != null);
                _twTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TwTimerSecondsSpecified { get; set; }

        protected int? _requestTimerSeconds;

        [XmlElement(ElementName = "requestTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        [MinInclusive(1)]
        [MaxInclusive(600)]
        public int? RequestTimerSeconds
        {
            get => _requestTimerSeconds;
            set
            {
                RequestTimerSecondsSpecified = (value != null);
                _requestTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool RequestTimerSecondsSpecified { get; set; }

        protected int? _busyPeerDetectionOutstandingTxnCount;

        [XmlElement(ElementName = "busyPeerDetectionOutstandingTxnCount", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        [MinInclusive(1)]
        [MaxInclusive(1000000)]
        public int? BusyPeerDetectionOutstandingTxnCount
        {
            get => _busyPeerDetectionOutstandingTxnCount;
            set
            {
                BusyPeerDetectionOutstandingTxnCountSpecified = (value != null);
                _busyPeerDetectionOutstandingTxnCount = value;
            }
        }

        [XmlIgnore]
        protected bool BusyPeerDetectionOutstandingTxnCountSpecified { get; set; }

        protected int? _busyPeerRestoreOutstandingTxnCount;

        [XmlElement(ElementName = "busyPeerRestoreOutstandingTxnCount", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        [MinInclusive(1)]
        [MaxInclusive(1000000)]
        public int? BusyPeerRestoreOutstandingTxnCount
        {
            get => _busyPeerRestoreOutstandingTxnCount;
            set
            {
                BusyPeerRestoreOutstandingTxnCountSpecified = (value != null);
                _busyPeerRestoreOutstandingTxnCount = value;
            }
        }

        [XmlIgnore]
        protected bool BusyPeerRestoreOutstandingTxnCountSpecified { get; set; }

        protected int? _dynamicEntryInactivityTimerHours;

        [XmlElement(ElementName = "dynamicEntryInactivityTimerHours", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        [MinInclusive(1)]
        [MaxInclusive(168)]
        public int? DynamicEntryInactivityTimerHours
        {
            get => _dynamicEntryInactivityTimerHours;
            set
            {
                DynamicEntryInactivityTimerHoursSpecified = (value != null);
                _dynamicEntryInactivityTimerHours = value;
            }
        }

        [XmlIgnore]
        protected bool DynamicEntryInactivityTimerHoursSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.BwDiameterAdvertisedApplication? _advertisedOfflineBillingApplication;

        [XmlElement(ElementName = "advertisedOfflineBillingApplication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        public BroadWorksConnector.Ocip.Models.BwDiameterAdvertisedApplication? AdvertisedOfflineBillingApplication
        {
            get => _advertisedOfflineBillingApplication;
            set
            {
                AdvertisedOfflineBillingApplicationSpecified = (value != null);
                _advertisedOfflineBillingApplication = value;
            }
        }

        [XmlIgnore]
        protected bool AdvertisedOfflineBillingApplicationSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.BwDiameterAdvertisedApplication? _advertisedOnlineBillingApplication;

        [XmlElement(ElementName = "advertisedOnlineBillingApplication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        public BroadWorksConnector.Ocip.Models.BwDiameterAdvertisedApplication? AdvertisedOnlineBillingApplication
        {
            get => _advertisedOnlineBillingApplication;
            set
            {
                AdvertisedOnlineBillingApplicationSpecified = (value != null);
                _advertisedOnlineBillingApplication = value;
            }
        }

        [XmlIgnore]
        protected bool AdvertisedOnlineBillingApplicationSpecified { get; set; }

        protected int? _defaultPort;

        [XmlElement(ElementName = "defaultPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int? DefaultPort
        {
            get => _defaultPort;
            set
            {
                DefaultPortSpecified = (value != null);
                _defaultPort = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultPortSpecified { get; set; }

        protected int? _defaultSecurePort;

        [XmlElement(ElementName = "defaultSecurePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int? DefaultSecurePort
        {
            get => _defaultSecurePort;
            set
            {
                DefaultSecurePortSpecified = (value != null);
                _defaultSecurePort = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultSecurePortSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DiameterPeerDiscoveryMode? _peerDiscoveryMode;

        [XmlElement(ElementName = "peerDiscoveryMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:2766")]
        public BroadWorksConnector.Ocip.Models.DiameterPeerDiscoveryMode? PeerDiscoveryMode
        {
            get => _peerDiscoveryMode;
            set
            {
                PeerDiscoveryModeSpecified = (value != null);
                _peerDiscoveryMode = value;
            }
        }

        [XmlIgnore]
        protected bool PeerDiscoveryModeSpecified { get; set; }

    }
}
