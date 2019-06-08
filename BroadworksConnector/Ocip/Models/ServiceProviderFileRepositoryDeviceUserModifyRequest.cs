using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderFileRepositoryDeviceUserModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
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
    private bool _allowPut;

    [XmlElement(ElementName = "allowPut", IsNullable = false, Namespace = "")]
    public bool AllowPut {
        get => _allowPut;
        set {
            AllowPutSpecified = true;
            _allowPut = value;
        }
    }

    [XmlIgnore]
    public bool AllowPutSpecified { get; set; }
    private bool _allowDelete;

    [XmlElement(ElementName = "allowDelete", IsNullable = false, Namespace = "")]
    public bool AllowDelete {
        get => _allowDelete;
        set {
            AllowDeleteSpecified = true;
            _allowDelete = value;
        }
    }

    [XmlIgnore]
    public bool AllowDeleteSpecified { get; set; }
    private bool _allowGet;

    [XmlElement(ElementName = "allowGet", IsNullable = false, Namespace = "")]
    public bool AllowGet {
        get => _allowGet;
        set {
            AllowGetSpecified = true;
            _allowGet = value;
        }
    }

    [XmlIgnore]
    public bool AllowGetSpecified { get; set; }
}
}
