using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemFileGetContentResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _fileContent;

    [XmlElement(ElementName = "fileContent", IsNullable = false, Namespace = "")]
    public string FileContent {
        get => _fileContent;
        set {
            FileContentSpecified = true;
            _fileContent = value;
        }
    }

    [XmlIgnore]
    public bool FileContentSpecified { get; set; }
}
}
