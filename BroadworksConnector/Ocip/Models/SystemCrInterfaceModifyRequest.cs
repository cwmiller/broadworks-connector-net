using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCrInterfaceModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "crAuditEnabled", IsNullable = false)]
    public bool CrAuditEnabled { get; set; }
    [XmlElement(ElementName = "crAuditIntervalMilliseconds", IsNullable = false)]
    public int CrAuditIntervalMilliseconds { get; set; }
    [XmlElement(ElementName = "crAuditTimeoutMilliseconds", IsNullable = false)]
    public int CrAuditTimeoutMilliseconds { get; set; }
    [XmlElement(ElementName = "crConnectionEnabled", IsNullable = false)]
    public bool CrConnectionEnabled { get; set; }
    [XmlElement(ElementName = "crConnectionTimeoutMilliseconds", IsNullable = false)]
    public int CrConnectionTimeoutMilliseconds { get; set; }
    [XmlElement(ElementName = "crTcpConnectionTimeoutSeconds", IsNullable = false)]
    public int CrTcpConnectionTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "crNumberOfReconnectionAttempts", IsNullable = false)]
    public int CrNumberOfReconnectionAttempts { get; set; }
 }
}
