using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCrInterfaceGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
 }
}
