using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemSessionAuditGetRequest14sp3.
    /// <see cref="SystemSessionAuditGetRequest14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:29298""}]")]
    public class SystemSessionAuditGetResponse14sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isAuditActive;

        [XmlElement(ElementName = "isAuditActive", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29298")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29298")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29298")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29298")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29298")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29298")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29298")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29298")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29298")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29298")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29298")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29298")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:29298")]
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

    }
}
