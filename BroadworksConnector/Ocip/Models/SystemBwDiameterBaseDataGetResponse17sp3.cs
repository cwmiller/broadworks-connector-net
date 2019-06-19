using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemBwDiameterBaseDataGetRequest17sp3.
    /// Contains a list of System Diameter base parameters.
    /// <see cref="SystemBwDiameterBaseDataGetRequest17sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2217""}]")]
    public class SystemBwDiameterBaseDataGetResponse17sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _xsRealm;

        [XmlElement(ElementName = "xsRealm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2217")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2217")]
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

        private string _psRealm;

        [XmlElement(ElementName = "psRealm", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2217")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2217")]
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

        private bool _psRelayThroughXs;

        [XmlElement(ElementName = "psRelayThroughXs", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2217")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2217")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2217")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2217")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2217")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2217")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2217")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2217")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2217")]
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
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2217")]
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

    }
}
