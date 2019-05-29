using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSessionAuditGetResponse14sp3 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isAuditActive", IsNullable = false)]
    public bool IsAuditActive { get; set; }
    [XmlElement(ElementName = "auditIntervalSeconds", IsNullable = false)]
    public int AuditIntervalSeconds { get; set; }
    [XmlElement(ElementName = "auditTimeoutSeconds", IsNullable = false)]
    public int AuditTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "releaseCallOnAuditFailure", IsNullable = false)]
    public bool ReleaseCallOnAuditFailure { get; set; }
    [XmlElement(ElementName = "isSIPRefreshAllowedOnAudit", IsNullable = false)]
    public bool IsSIPRefreshAllowedOnAudit { get; set; }
    [XmlElement(ElementName = "allowUpdateForSIPRefresh", IsNullable = false)]
    public bool AllowUpdateForSIPRefresh { get; set; }
    [XmlElement(ElementName = "isSIPSessionTimerActive", IsNullable = false)]
    public bool IsSIPSessionTimerActive { get; set; }
    [XmlElement(ElementName = "sipSessionExpiresMinimumSeconds", IsNullable = false)]
    public int SipSessionExpiresMinimumSeconds { get; set; }
    [XmlElement(ElementName = "enforceSIPSessionExpiresMaximum", IsNullable = false)]
    public bool EnforceSIPSessionExpiresMaximum { get; set; }
    [XmlElement(ElementName = "sipSessionExpiresMaximumSeconds", IsNullable = false)]
    public int SipSessionExpiresMaximumSeconds { get; set; }
    [XmlElement(ElementName = "sipSessionExpiresTimerSeconds", IsNullable = false)]
    public int SipSessionExpiresTimerSeconds { get; set; }
    [XmlElement(ElementName = "alwaysUseSessionTimerWhenSupported", IsNullable = false)]
    public bool AlwaysUseSessionTimerWhenSupported { get; set; }
    [XmlElement(ElementName = "preferredSessionTimerRefresher", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SessionTimerRefresher PreferredSessionTimerRefresher { get; set; }
 }
}
