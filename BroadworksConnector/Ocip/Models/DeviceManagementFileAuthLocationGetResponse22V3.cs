using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// This is a response to DeviceManagementFileAuthLocationGetRequest22V3.
    /// Return the address and credentials of the File Repository hosting the requested access device file.
    /// Also return the file name and path on the File Repository.
    /// Also returns the status of the file authentication.
    /// <see cref="DeviceManagementFileAuthLocationGetRequest22V3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:1969""}]")]
    public class DeviceManagementFileAuthLocationGetResponse22V3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.DeviceManagementFileAuthenticationStatus _status;

        [XmlElement(ElementName = "status", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementFileAuthenticationStatus Status
        {
            get => _status;
            set
            {
                StatusSpecified = true;
                _status = value;
            }
        }

        [XmlIgnore]
        protected bool StatusSpecified { get; set; }

        protected string _fileRepositoryUserName;

        [XmlElement(ElementName = "fileRepositoryUserName", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        [MinLength(1)]
        [MaxLength(30)]
        public string FileRepositoryUserName
        {
            get => _fileRepositoryUserName;
            set
            {
                FileRepositoryUserNameSpecified = true;
                _fileRepositoryUserName = value;
            }
        }

        [XmlIgnore]
        protected bool FileRepositoryUserNameSpecified { get; set; }

        protected string _fileRepositoryPassword;

        [XmlElement(ElementName = "fileRepositoryPassword", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        [MinLength(1)]
        [MaxLength(30)]
        public string FileRepositoryPassword
        {
            get => _fileRepositoryPassword;
            set
            {
                FileRepositoryPasswordSpecified = true;
                _fileRepositoryPassword = value;
            }
        }

        [XmlIgnore]
        protected bool FileRepositoryPasswordSpecified { get; set; }

        protected string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NetAddress
        {
            get => _netAddress;
            set
            {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        protected bool NetAddressSpecified { get; set; }

        protected string _remoteFileFormat;

        [XmlElement(ElementName = "remoteFileFormat", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        [MinLength(1)]
        [MaxLength(128)]
        public string RemoteFileFormat
        {
            get => _remoteFileFormat;
            set
            {
                RemoteFileFormatSpecified = true;
                _remoteFileFormat = value;
            }
        }

        [XmlIgnore]
        protected bool RemoteFileFormatSpecified { get; set; }

        protected int _portNumber;

        [XmlElement(ElementName = "portNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int PortNumber
        {
            get => _portNumber;
            set
            {
                PortNumberSpecified = true;
                _portNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PortNumberSpecified { get; set; }

        protected string _rootDirectory;

        [XmlElement(ElementName = "rootDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        [MinLength(1)]
        [MaxLength(256)]
        public string RootDirectory
        {
            get => _rootDirectory;
            set
            {
                RootDirectorySpecified = true;
                _rootDirectory = value;
            }
        }

        [XmlIgnore]
        protected bool RootDirectorySpecified { get; set; }

        protected string _cpeFileDirectory;

        [XmlElement(ElementName = "cpeFileDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        [MinLength(1)]
        [MaxLength(256)]
        public string CpeFileDirectory
        {
            get => _cpeFileDirectory;
            set
            {
                CpeFileDirectorySpecified = true;
                _cpeFileDirectory = value;
            }
        }

        [XmlIgnore]
        protected bool CpeFileDirectorySpecified { get; set; }

        protected bool _secure;

        [XmlElement(ElementName = "secure", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        public bool Secure
        {
            get => _secure;
            set
            {
                SecureSpecified = true;
                _secure = value;
            }
        }

        [XmlIgnore]
        protected bool SecureSpecified { get; set; }

        protected bool _macInNonRequestURI;

        [XmlElement(ElementName = "macInNonRequestURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        public bool MacInNonRequestURI
        {
            get => _macInNonRequestURI;
            set
            {
                MacInNonRequestURISpecified = true;
                _macInNonRequestURI = value;
            }
        }

        [XmlIgnore]
        protected bool MacInNonRequestURISpecified { get; set; }

        protected bool _macInCert;

        [XmlElement(ElementName = "macInCert", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        public bool MacInCert
        {
            get => _macInCert;
            set
            {
                MacInCertSpecified = true;
                _macInCert = value;
            }
        }

        [XmlIgnore]
        protected bool MacInCertSpecified { get; set; }

        protected string _macFormatInNonRequestURI;

        [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        [MinLength(1)]
        [MaxLength(256)]
        public string MacFormatInNonRequestURI
        {
            get => _macFormatInNonRequestURI;
            set
            {
                MacFormatInNonRequestURISpecified = true;
                _macFormatInNonRequestURI = value;
            }
        }

        [XmlIgnore]
        protected bool MacFormatInNonRequestURISpecified { get; set; }

        protected bool _useHttpDigestAuthentication;

        [XmlElement(ElementName = "useHttpDigestAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        public bool UseHttpDigestAuthentication
        {
            get => _useHttpDigestAuthentication;
            set
            {
                UseHttpDigestAuthenticationSpecified = true;
                _useHttpDigestAuthentication = value;
            }
        }

        [XmlIgnore]
        protected bool UseHttpDigestAuthenticationSpecified { get; set; }

        protected bool _macBasedFileAuthentication;

        [XmlElement(ElementName = "macBasedFileAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        public bool MacBasedFileAuthentication
        {
            get => _macBasedFileAuthentication;
            set
            {
                MacBasedFileAuthenticationSpecified = true;
                _macBasedFileAuthentication = value;
            }
        }

        [XmlIgnore]
        protected bool MacBasedFileAuthenticationSpecified { get; set; }

        protected bool _userNamePasswordFileAuthentication;

        [XmlElement(ElementName = "userNamePasswordFileAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        public bool UserNamePasswordFileAuthentication
        {
            get => _userNamePasswordFileAuthentication;
            set
            {
                UserNamePasswordFileAuthenticationSpecified = true;
                _userNamePasswordFileAuthentication = value;
            }
        }

        [XmlIgnore]
        protected bool UserNamePasswordFileAuthenticationSpecified { get; set; }

        protected bool _completionNotification;

        [XmlElement(ElementName = "completionNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        public bool CompletionNotification
        {
            get => _completionNotification;
            set
            {
                CompletionNotificationSpecified = true;
                _completionNotification = value;
            }
        }

        [XmlIgnore]
        protected bool CompletionNotificationSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceManagementFileCategory22 _fileCategory;

        [XmlElement(ElementName = "fileCategory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementFileCategory22 FileCategory
        {
            get => _fileCategory;
            set
            {
                FileCategorySpecified = true;
                _fileCategory = value;
            }
        }

        [XmlIgnore]
        protected bool FileCategorySpecified { get; set; }

        protected bool _enableCaching;

        [XmlElement(ElementName = "enableCaching", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        public bool EnableCaching
        {
            get => _enableCaching;
            set
            {
                EnableCachingSpecified = true;
                _enableCaching = value;
            }
        }

        [XmlIgnore]
        protected bool EnableCachingSpecified { get; set; }

        protected bool _notifyFileUpload;

        [XmlElement(ElementName = "notifyFileUpload", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:1969")]
        public bool NotifyFileUpload
        {
            get => _notifyFileUpload;
            set
            {
                NotifyFileUploadSpecified = true;
                _notifyFileUpload = value;
            }
        }

        [XmlIgnore]
        protected bool NotifyFileUploadSpecified { get; set; }

    }
}
