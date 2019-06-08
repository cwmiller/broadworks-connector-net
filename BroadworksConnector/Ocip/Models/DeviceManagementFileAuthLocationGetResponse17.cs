using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class DeviceManagementFileAuthLocationGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _fileRepositoryUserName;

    [XmlElement(ElementName = "fileRepositoryUserName", IsNullable = false, Namespace = "")]
    public string FileRepositoryUserName {
        get => _fileRepositoryUserName;
        set {
            FileRepositoryUserNameSpecified = true;
            _fileRepositoryUserName = value;
        }
    }

    [XmlIgnore]
    public bool FileRepositoryUserNameSpecified { get; set; }
    private string _fileRepositoryPassword;

    [XmlElement(ElementName = "fileRepositoryPassword", IsNullable = false, Namespace = "")]
    public string FileRepositoryPassword {
        get => _fileRepositoryPassword;
        set {
            FileRepositoryPasswordSpecified = true;
            _fileRepositoryPassword = value;
        }
    }

    [XmlIgnore]
    public bool FileRepositoryPasswordSpecified { get; set; }
    private string _netAddress;

    [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
    public string NetAddress {
        get => _netAddress;
        set {
            NetAddressSpecified = true;
            _netAddress = value;
        }
    }

    [XmlIgnore]
    public bool NetAddressSpecified { get; set; }
    private string _remoteFileFormat;

    [XmlElement(ElementName = "remoteFileFormat", IsNullable = false, Namespace = "")]
    public string RemoteFileFormat {
        get => _remoteFileFormat;
        set {
            RemoteFileFormatSpecified = true;
            _remoteFileFormat = value;
        }
    }

    [XmlIgnore]
    public bool RemoteFileFormatSpecified { get; set; }
    private int _portNumber;

    [XmlElement(ElementName = "portNumber", IsNullable = false, Namespace = "")]
    public int PortNumber {
        get => _portNumber;
        set {
            PortNumberSpecified = true;
            _portNumber = value;
        }
    }

    [XmlIgnore]
    public bool PortNumberSpecified { get; set; }
    private string _rootDirectory;

    [XmlElement(ElementName = "rootDirectory", IsNullable = false, Namespace = "")]
    public string RootDirectory {
        get => _rootDirectory;
        set {
            RootDirectorySpecified = true;
            _rootDirectory = value;
        }
    }

    [XmlIgnore]
    public bool RootDirectorySpecified { get; set; }
    private string _cpeFileDirectory;

    [XmlElement(ElementName = "cpeFileDirectory", IsNullable = false, Namespace = "")]
    public string CpeFileDirectory {
        get => _cpeFileDirectory;
        set {
            CpeFileDirectorySpecified = true;
            _cpeFileDirectory = value;
        }
    }

    [XmlIgnore]
    public bool CpeFileDirectorySpecified { get; set; }
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
    private bool _macInNonRequestURI;

    [XmlElement(ElementName = "macInNonRequestURI", IsNullable = false, Namespace = "")]
    public bool MacInNonRequestURI {
        get => _macInNonRequestURI;
        set {
            MacInNonRequestURISpecified = true;
            _macInNonRequestURI = value;
        }
    }

    [XmlIgnore]
    public bool MacInNonRequestURISpecified { get; set; }
    private string _macFormatInNonRequestURI;

    [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = false, Namespace = "")]
    public string MacFormatInNonRequestURI {
        get => _macFormatInNonRequestURI;
        set {
            MacFormatInNonRequestURISpecified = true;
            _macFormatInNonRequestURI = value;
        }
    }

    [XmlIgnore]
    public bool MacFormatInNonRequestURISpecified { get; set; }
    private bool _useHttpDigestAuthentication;

    [XmlElement(ElementName = "useHttpDigestAuthentication", IsNullable = false, Namespace = "")]
    public bool UseHttpDigestAuthentication {
        get => _useHttpDigestAuthentication;
        set {
            UseHttpDigestAuthenticationSpecified = true;
            _useHttpDigestAuthentication = value;
        }
    }

    [XmlIgnore]
    public bool UseHttpDigestAuthenticationSpecified { get; set; }
    private bool _macBasedFileAuthentication;

    [XmlElement(ElementName = "macBasedFileAuthentication", IsNullable = false, Namespace = "")]
    public bool MacBasedFileAuthentication {
        get => _macBasedFileAuthentication;
        set {
            MacBasedFileAuthenticationSpecified = true;
            _macBasedFileAuthentication = value;
        }
    }

    [XmlIgnore]
    public bool MacBasedFileAuthenticationSpecified { get; set; }
    private bool _userNamePasswordFileAuthentication;

    [XmlElement(ElementName = "userNamePasswordFileAuthentication", IsNullable = false, Namespace = "")]
    public bool UserNamePasswordFileAuthentication {
        get => _userNamePasswordFileAuthentication;
        set {
            UserNamePasswordFileAuthenticationSpecified = true;
            _userNamePasswordFileAuthentication = value;
        }
    }

    [XmlIgnore]
    public bool UserNamePasswordFileAuthenticationSpecified { get; set; }
    private bool _completionNotification;

    [XmlElement(ElementName = "completionNotification", IsNullable = false, Namespace = "")]
    public bool CompletionNotification {
        get => _completionNotification;
        set {
            CompletionNotificationSpecified = true;
            _completionNotification = value;
        }
    }

    [XmlIgnore]
    public bool CompletionNotificationSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DeviceManagementFileCategory _fileCategory;

    [XmlElement(ElementName = "fileCategory", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DeviceManagementFileCategory FileCategory {
        get => _fileCategory;
        set {
            FileCategorySpecified = true;
            _fileCategory = value;
        }
    }

    [XmlIgnore]
    public bool FileCategorySpecified { get; set; }
}
}