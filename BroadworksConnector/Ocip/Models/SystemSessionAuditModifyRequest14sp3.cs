using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with session audit.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// alwaysAllowRefreshForMS
    /// msAuditIntervalSeconds
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16358""}]")]
    public class SystemSessionAuditModifyRequest14sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _isAuditActive;

        [XmlElement(ElementName = "isAuditActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        public bool IsAuditActive
        {
            get => _isAuditActive;
            set
            {
                IsAuditActiveSpecified = true;
                _isAuditActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsAuditActiveSpecified { get; set; }

        private int _auditIntervalSeconds;

        [XmlElement(ElementName = "auditIntervalSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        [MinInclusive(60)]
        [MaxInclusive(7200)]
        public int AuditIntervalSeconds
        {
            get => _auditIntervalSeconds;
            set
            {
                AuditIntervalSecondsSpecified = true;
                _auditIntervalSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool AuditIntervalSecondsSpecified { get; set; }

        private int _auditTimeoutSeconds;

        [XmlElement(ElementName = "auditTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        [MinInclusive(60)]
        [MaxInclusive(600)]
        public int AuditTimeoutSeconds
        {
            get => _auditTimeoutSeconds;
            set
            {
                AuditTimeoutSecondsSpecified = true;
                _auditTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool AuditTimeoutSecondsSpecified { get; set; }

        private bool _releaseCallOnAuditFailure;

        [XmlElement(ElementName = "releaseCallOnAuditFailure", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        public bool ReleaseCallOnAuditFailure
        {
            get => _releaseCallOnAuditFailure;
            set
            {
                ReleaseCallOnAuditFailureSpecified = true;
                _releaseCallOnAuditFailure = value;
            }
        }

        [XmlIgnore]
        protected bool ReleaseCallOnAuditFailureSpecified { get; set; }

        private bool _isSIPRefreshAllowedOnAudit;

        [XmlElement(ElementName = "isSIPRefreshAllowedOnAudit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        public bool IsSIPRefreshAllowedOnAudit
        {
            get => _isSIPRefreshAllowedOnAudit;
            set
            {
                IsSIPRefreshAllowedOnAuditSpecified = true;
                _isSIPRefreshAllowedOnAudit = value;
            }
        }

        [XmlIgnore]
        protected bool IsSIPRefreshAllowedOnAuditSpecified { get; set; }

        private bool _allowUpdateForSIPRefresh;

        [XmlElement(ElementName = "allowUpdateForSIPRefresh", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        public bool AllowUpdateForSIPRefresh
        {
            get => _allowUpdateForSIPRefresh;
            set
            {
                AllowUpdateForSIPRefreshSpecified = true;
                _allowUpdateForSIPRefresh = value;
            }
        }

        [XmlIgnore]
        protected bool AllowUpdateForSIPRefreshSpecified { get; set; }

        private bool _isSIPSessionTimerActive;

        [XmlElement(ElementName = "isSIPSessionTimerActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        public bool IsSIPSessionTimerActive
        {
            get => _isSIPSessionTimerActive;
            set
            {
                IsSIPSessionTimerActiveSpecified = true;
                _isSIPSessionTimerActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsSIPSessionTimerActiveSpecified { get; set; }

        private int _sipSessionExpiresMinimumSeconds;

        [XmlElement(ElementName = "sipSessionExpiresMinimumSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        [MinInclusive(30)]
        [MaxInclusive(3600)]
        public int SipSessionExpiresMinimumSeconds
        {
            get => _sipSessionExpiresMinimumSeconds;
            set
            {
                SipSessionExpiresMinimumSecondsSpecified = true;
                _sipSessionExpiresMinimumSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool SipSessionExpiresMinimumSecondsSpecified { get; set; }

        private bool _enforceSIPSessionExpiresMaximum;

        [XmlElement(ElementName = "enforceSIPSessionExpiresMaximum", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        public bool EnforceSIPSessionExpiresMaximum
        {
            get => _enforceSIPSessionExpiresMaximum;
            set
            {
                EnforceSIPSessionExpiresMaximumSpecified = true;
                _enforceSIPSessionExpiresMaximum = value;
            }
        }

        [XmlIgnore]
        protected bool EnforceSIPSessionExpiresMaximumSpecified { get; set; }

        private int _sipSessionExpiresMaximumSeconds;

        [XmlElement(ElementName = "sipSessionExpiresMaximumSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        [MinInclusive(3600)]
        [MaxInclusive(86400)]
        public int SipSessionExpiresMaximumSeconds
        {
            get => _sipSessionExpiresMaximumSeconds;
            set
            {
                SipSessionExpiresMaximumSecondsSpecified = true;
                _sipSessionExpiresMaximumSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool SipSessionExpiresMaximumSecondsSpecified { get; set; }

        private int _sipSessionExpiresTimerSeconds;

        [XmlElement(ElementName = "sipSessionExpiresTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        [MinInclusive(60)]
        [MaxInclusive(86400)]
        public int SipSessionExpiresTimerSeconds
        {
            get => _sipSessionExpiresTimerSeconds;
            set
            {
                SipSessionExpiresTimerSecondsSpecified = true;
                _sipSessionExpiresTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool SipSessionExpiresTimerSecondsSpecified { get; set; }

        private bool _alwaysUseSessionTimerWhenSupported;

        [XmlElement(ElementName = "alwaysUseSessionTimerWhenSupported", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        public bool AlwaysUseSessionTimerWhenSupported
        {
            get => _alwaysUseSessionTimerWhenSupported;
            set
            {
                AlwaysUseSessionTimerWhenSupportedSpecified = true;
                _alwaysUseSessionTimerWhenSupported = value;
            }
        }

        [XmlIgnore]
        protected bool AlwaysUseSessionTimerWhenSupportedSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SessionTimerRefresher _preferredSessionTimerRefresher;

        [XmlElement(ElementName = "preferredSessionTimerRefresher", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        public BroadWorksConnector.Ocip.Models.SessionTimerRefresher PreferredSessionTimerRefresher
        {
            get => _preferredSessionTimerRefresher;
            set
            {
                PreferredSessionTimerRefresherSpecified = true;
                _preferredSessionTimerRefresher = value;
            }
        }

        [XmlIgnore]
        protected bool PreferredSessionTimerRefresherSpecified { get; set; }

        private bool _enableEmergencyCallAlarmTimer;

        [XmlElement(ElementName = "enableEmergencyCallAlarmTimer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        public bool EnableEmergencyCallAlarmTimer
        {
            get => _enableEmergencyCallAlarmTimer;
            set
            {
                EnableEmergencyCallAlarmTimerSpecified = true;
                _enableEmergencyCallAlarmTimer = value;
            }
        }

        [XmlIgnore]
        protected bool EnableEmergencyCallAlarmTimerSpecified { get; set; }

        private int _emergencyCallAlarmMinutes;

        [XmlElement(ElementName = "emergencyCallAlarmMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        [MinInclusive(1)]
        [MaxInclusive(1440)]
        public int EmergencyCallAlarmMinutes
        {
            get => _emergencyCallAlarmMinutes;
            set
            {
                EmergencyCallAlarmMinutesSpecified = true;
                _emergencyCallAlarmMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencyCallAlarmMinutesSpecified { get; set; }

        private bool _enableEmergencyCallCleanupTimer;

        [XmlElement(ElementName = "enableEmergencyCallCleanupTimer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        public bool EnableEmergencyCallCleanupTimer
        {
            get => _enableEmergencyCallCleanupTimer;
            set
            {
                EnableEmergencyCallCleanupTimerSpecified = true;
                _enableEmergencyCallCleanupTimer = value;
            }
        }

        [XmlIgnore]
        protected bool EnableEmergencyCallCleanupTimerSpecified { get; set; }

        private int _emergencyCallCleanupMinutes;

        [XmlElement(ElementName = "emergencyCallCleanupMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        [MinInclusive(1)]
        [MaxInclusive(1440)]
        public int EmergencyCallCleanupMinutes
        {
            get => _emergencyCallCleanupMinutes;
            set
            {
                EmergencyCallCleanupMinutesSpecified = true;
                _emergencyCallCleanupMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencyCallCleanupMinutesSpecified { get; set; }

        private bool _alwaysAllowRefreshForMS;

        [XmlElement(ElementName = "alwaysAllowRefreshForMS", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        public bool AlwaysAllowRefreshForMS
        {
            get => _alwaysAllowRefreshForMS;
            set
            {
                AlwaysAllowRefreshForMSSpecified = true;
                _alwaysAllowRefreshForMS = value;
            }
        }

        [XmlIgnore]
        protected bool AlwaysAllowRefreshForMSSpecified { get; set; }

        private int _msAuditIntervalSeconds;

        [XmlElement(ElementName = "msAuditIntervalSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16358")]
        [MinInclusive(60)]
        [MaxInclusive(7200)]
        public int MsAuditIntervalSeconds
        {
            get => _msAuditIntervalSeconds;
            set
            {
                MsAuditIntervalSecondsSpecified = true;
                _msAuditIntervalSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool MsAuditIntervalSecondsSpecified { get; set; }

    }
}
