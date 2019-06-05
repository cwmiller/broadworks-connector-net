using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemConfigurableFileSystemGetResponseProtocolWebDAV 
{
    private bool _secure;

    [XmlElement(ElementName = "secure", IsNullable = false, Namespace = "")]
    public bool Secure {
        get => _secure;
        set {
            SecureSpecified = true;
            _secure = value;
        }
    }

    [XmlIgnore]
    public bool SecureSpecified { get; set; }
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
    private string _password;

    [XmlElement(ElementName = "password", IsNullable = false, Namespace = "")]
    public string Password {
        get => _password;
        set {
            PasswordSpecified = true;
            _password = value;
        }
    }

    [XmlIgnore]
    public bool PasswordSpecified { get; set; }
    private string _fileServerFQDN;

    [XmlElement(ElementName = "fileServerFQDN", IsNullable = false, Namespace = "")]
    public string FileServerFQDN {
        get => _fileServerFQDN;
        set {
            FileServerFQDNSpecified = true;
            _fileServerFQDN = value;
        }
    }

    [XmlIgnore]
    public bool FileServerFQDNSpecified { get; set; }
}
}
