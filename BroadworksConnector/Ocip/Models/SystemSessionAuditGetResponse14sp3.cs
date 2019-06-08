using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSessionAuditGetResponse14sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _isAuditActive;

    [XmlElement(ElementName = "isAuditActive", IsNullable = false, Namespace = "")]
    public bool IsAuditActive {
        get => _isAuditActive;
        set {
            IsAuditActiveSpecified = true;
            _isAuditActive = value;
        }
    }

    [XmlIgnore]
    public bool IsAuditActiveSpecified { get; set; }
    private int _auditIntervalSeconds;

    [XmlElement(ElementName = "auditIntervalSeconds", IsNullable = false, Namespace = "")]
    public int AuditIntervalSeconds {
        get => _auditIntervalSeconds;
        set {
            AuditIntervalSecondsSpecified = true;
            _auditIntervalSeconds = value;
        }
    }

    [XmlIgnore]
    public bool AuditIntervalSecondsSpecified { get; set; }
    private int _auditTimeoutSeconds;

    [XmlElement(ElementName = "auditTimeoutSeconds", IsNullable = false, Namespace = "")]
    public int AuditTimeoutSeconds {
        get => _auditTimeoutSeconds;
        set {
            AuditTimeoutSecondsSpecified = true;
            _auditTimeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool AuditTimeoutSecondsSpecified { get; set; }
    private bool _releaseCallOnAuditFailure;

    [XmlElement(ElementName = "releaseCallOnAuditFailure", IsNullable = false, Namespace = "")]
    public bool ReleaseCallOnAuditFailure {
        get => _releaseCallOnAuditFailure;
        set {
            ReleaseCallOnAuditFailureSpecified = true;
            _releaseCallOnAuditFailure = value;
        }
    }

    [XmlIgnore]
    public bool ReleaseCallOnAuditFailureSpecified { get; set; }
    private bool _isSIPRefreshAllowedOnAudit;

    [XmlElement(ElementName = "isSIPRefreshAllowedOnAudit", IsNullable = false, Namespace = "")]
    public bool IsSIPRefreshAllowedOnAudit {
        get => _isSIPRefreshAllowedOnAudit;
        set {
            IsSIPRefreshAllowedOnAuditSpecified = true;
            _isSIPRefreshAllowedOnAudit = value;
        }
    }

    [XmlIgnore]
    public bool IsSIPRefreshAllowedOnAuditSpecified { get; set; }
    private bool _allowUpdateForSIPRefresh;

    [XmlElement(ElementName = "allowUpdateForSIPRefresh", IsNullable = false, Namespace = "")]
    public bool AllowUpdateForSIPRefresh {
        get => _allowUpdateForSIPRefresh;
        set {
            AllowUpdateForSIPRefreshSpecified = true;
            _allowUpdateForSIPRefresh = value;
        }
    }

    [XmlIgnore]
    public bool AllowUpdateForSIPRefreshSpecified { get; set; }
    private bool _isSIPSessionTimerActive;

    [XmlElement(ElementName = "isSIPSessionTimerActive", IsNullable = false, Namespace = "")]
    public bool IsSIPSessionTimerActive {
        get => _isSIPSessionTimerActive;
        set {
            IsSIPSessionTimerActiveSpecified = true;
            _isSIPSessionTimerActive = value;
        }
    }

    [XmlIgnore]
    public bool IsSIPSessionTimerActiveSpecified { get; set; }
    private int _sipSessionExpiresMinimumSeconds;

    [XmlElement(ElementName = "sipSessionExpiresMinimumSeconds", IsNullable = false, Namespace = "")]
    public int SipSessionExpiresMinimumSeconds {
        get => _sipSessionExpiresMinimumSeconds;
        set {
            SipSessionExpiresMinimumSecondsSpecified = true;
            _sipSessionExpiresMinimumSeconds = value;
        }
    }

    [XmlIgnore]
    public bool SipSessionExpiresMinimumSecondsSpecified { get; set; }
    private bool _enforceSIPSessionExpiresMaximum;

    [XmlElement(ElementName = "enforceSIPSessionExpiresMaximum", IsNullable = false, Namespace = "")]
    public bool EnforceSIPSessionExpiresMaximum {
        get => _enforceSIPSessionExpiresMaximum;
        set {
            EnforceSIPSessionExpiresMaximumSpecified = true;
            _enforceSIPSessionExpiresMaximum = value;
        }
    }

    [XmlIgnore]
    public bool EnforceSIPSessionExpiresMaximumSpecified { get; set; }
    private int _sipSessionExpiresMaximumSeconds;

    [XmlElement(ElementName = "sipSessionExpiresMaximumSeconds", IsNullable = false, Namespace = "")]
    public int SipSessionExpiresMaximumSeconds {
        get => _sipSessionExpiresMaximumSeconds;
        set {
            SipSessionExpiresMaximumSecondsSpecified = true;
            _sipSessionExpiresMaximumSeconds = value;
        }
    }

    [XmlIgnore]
    public bool SipSessionExpiresMaximumSecondsSpecified { get; set; }
    private int _sipSessionExpiresTimerSeconds;

    [XmlElement(ElementName = "sipSessionExpiresTimerSeconds", IsNullable = false, Namespace = "")]
    public int SipSessionExpiresTimerSeconds {
        get => _sipSessionExpiresTimerSeconds;
        set {
            SipSessionExpiresTimerSecondsSpecified = true;
            _sipSessionExpiresTimerSeconds = value;
        }
    }

    [XmlIgnore]
    public bool SipSessionExpiresTimerSecondsSpecified { get; set; }
    private bool _alwaysUseSessionTimerWhenSupported;

    [XmlElement(ElementName = "alwaysUseSessionTimerWhenSupported", IsNullable = false, Namespace = "")]
    public bool AlwaysUseSessionTimerWhenSupported {
        get => _alwaysUseSessionTimerWhenSupported;
        set {
            AlwaysUseSessionTimerWhenSupportedSpecified = true;
            _alwaysUseSessionTimerWhenSupported = value;
        }
    }

    [XmlIgnore]
    public bool AlwaysUseSessionTimerWhenSupportedSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SessionTimerRefresher _preferredSessionTimerRefresher;

    [XmlElement(ElementName = "preferredSessionTimerRefresher", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SessionTimerRefresher PreferredSessionTimerRefresher {
        get => _preferredSessionTimerRefresher;
        set {
            PreferredSessionTimerRefresherSpecified = true;
            _preferredSessionTimerRefresher = value;
        }
    }

    [XmlIgnore]
    public bool PreferredSessionTimerRefresherSpecified { get; set; }
}
}
