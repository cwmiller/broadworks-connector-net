using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCPEConfigAddFileServerRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "deviceType", IsNullable = false)]
    public string DeviceType { get; set; }
    [XmlElement(ElementName = "ftpHostNetAddress", IsNullable = false)]
    public string FtpHostNetAddress { get; set; }
    [XmlElement(ElementName = "ftpUserId", IsNullable = false)]
    public string FtpUserId { get; set; }
    [XmlElement(ElementName = "ftpUserPassword", IsNullable = false)]
    public string FtpUserPassword { get; set; }
    [XmlElement(ElementName = "cpeFileDirectory", IsNullable = false)]
    public string CpeFileDirectory { get; set; }
    [XmlElement(ElementName = "passiveFTP", IsNullable = false)]
    public bool PassiveFTP { get; set; }
 }
}
