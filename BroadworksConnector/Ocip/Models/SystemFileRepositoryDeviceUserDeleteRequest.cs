using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemFileRepositoryDeviceUserDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private string _userName;

    [XmlElement(ElementName = "userName", IsNullable = false, Namespace = "")]
    public string UserName {
        get => _userName;
        set {
            UserNameSpecified = true;
            _userName = value;
        }
    }

    [XmlIgnore]
    public bool UserNameSpecified { get; set; }
}
}
