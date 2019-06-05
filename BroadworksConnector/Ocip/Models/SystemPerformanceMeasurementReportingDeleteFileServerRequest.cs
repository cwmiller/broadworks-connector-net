using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPerformanceMeasurementReportingDeleteFileServerRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _ftpHostNetAddress;

    [XmlElement(ElementName = "ftpHostNetAddress", IsNullable = false, Namespace = "")]
    public string FtpHostNetAddress {
        get => _ftpHostNetAddress;
        set {
            FtpHostNetAddressSpecified = true;
            _ftpHostNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool FtpHostNetAddressSpecified { get; set; }
}
}
