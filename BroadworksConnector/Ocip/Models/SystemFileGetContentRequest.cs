using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemFileGetContentRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _fileName;

    [XmlElement(ElementName = "fileName", IsNullable = false, Namespace = "")]
    public string FileName {
        get => _fileName;
        set {
            FileNameSpecified = true;
            _fileName = value;
        }
    }

    [XmlIgnore]
    public bool FileNameSpecified { get; set; }
}
}
