using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOCIReportingParametersGetResponse14sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serverPort", IsNullable = false)]
    public int ServerPort { get; set; }
    [XmlElement(ElementName = "enableConnectionPing", IsNullable = false)]
    public bool EnableConnectionPing { get; set; }
    [XmlElement(ElementName = "connectionPingIntervalSeconds", IsNullable = false)]
    public int ConnectionPingIntervalSeconds { get; set; }
    [XmlElement(ElementName = "alterPasswords", IsNullable = false)]
    public bool AlterPasswords { get; set; }
    [XmlElement(ElementName = "enablePublicIdentityReporting", IsNullable = false)]
    public bool EnablePublicIdentityReporting { get; set; }
 }
}
