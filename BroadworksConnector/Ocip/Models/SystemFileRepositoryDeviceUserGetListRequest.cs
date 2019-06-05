using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemFileRepositoryDeviceUserGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _fileRepositoryName;

    [XmlElement(ElementName = "fileRepositoryName", IsNullable = false, Namespace = "")]
    public string FileRepositoryName {
        get => _fileRepositoryName;
        set {
            FileRepositoryNameSpecified = true;
            _fileRepositoryName = value;
        }
    }

    [XmlIgnore]
    public bool FileRepositoryNameSpecified { get; set; }
}
}
