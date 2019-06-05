using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceTypeImportRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _file;

    [XmlElement(ElementName = "file", IsNullable = false, Namespace = "")]
    public string File {
        get => _file;
        set {
            FileSpecified = true;
            _file = value;
        }
    }

    [XmlIgnore]
    public bool FileSpecified { get; set; }
    private string _resellerId;

    [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
    public string ResellerId {
        get => _resellerId;
        set {
            ResellerIdSpecified = true;
            _resellerId = value;
        }
    }

    [XmlIgnore]
    public bool ResellerIdSpecified { get; set; }
}
}
