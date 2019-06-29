using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a sip device type file.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// The following logic applies to these elements:
    /// macInCert
    /// macInNonRequestURI
    /// The two elements are mutually exclusive.
    /// When both are set to true, the command fails.
    /// When macInCert is set to true, macInNonRequestURI will be reset to false.
    /// When macInNonRequestURI is set to true, macInCert will be reset to false.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="macInNonRequest"/>
    /// <see cref="macInNonRequest"/>
    /// <see cref="macInNonRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16021""}]")]
    public class SystemSIPDeviceTypeFileModifyRequest16sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceType
        {
            get => _deviceType;
            set
            {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTypeSpecified { get; set; }

        private string _fileFormat;

        [XmlElement(ElementName = "fileFormat", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
        [MinLength(1)]
        [MaxLength(128)]
        public string FileFormat
        {
            get => _fileFormat;
            set
            {
                FileFormatSpecified = true;
                _fileFormat = value;
            }
        }

        [XmlIgnore]
        protected bool FileFormatSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DeviceManagementFileCustomization _fileCustomization;

        [XmlElement(ElementName = "fileCustomization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementFileCustomization FileCustomization
        {
            get => _fileCustomization;
            set
            {
                FileCustomizationSpecified = true;
                _fileCustomization = value;
            }
        }

        [XmlIgnore]
        protected bool FileCustomizationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.DeviceTypeFileEnhancedConfigurationMode _fileSource;

        [XmlElement(ElementName = "fileSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
        public BroadWorksConnector.Ocip.Models.DeviceTypeFileEnhancedConfigurationMode FileSource
        {
            get => _fileSource;
            set
            {
                FileSourceSpecified = true;
                _fileSource = value;
            }
        }

        [XmlIgnore]
        protected bool FileSourceSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.FileResource _uploadFile;

        [XmlElement(ElementName = "uploadFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
        public BroadWorksConnector.Ocip.Models.FileResource UploadFile
        {
            get => _uploadFile;
            set
            {
                UploadFileSpecified = true;
                _uploadFile = value;
            }
        }

        [XmlIgnore]
        protected bool UploadFileSpecified { get; set; }

        private bool _useHttpDigestAuthentication;

        [XmlElement(ElementName = "useHttpDigestAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
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

        private bool _macBasedFileAuthentication;

        [XmlElement(ElementName = "macBasedFileAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
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

        private bool _userNamePasswordFileAuthentication;

        [XmlElement(ElementName = "userNamePasswordFileAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
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

        private bool _macInNonRequestURI;

        [XmlElement(ElementName = "macInNonRequestURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
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

        private bool _macInCert;

        [XmlElement(ElementName = "macInCert", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
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

        private string _macFormatInNonRequestURI;

        [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
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

        private bool _allowHttp;

        [XmlElement(ElementName = "allowHttp", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
        public bool AllowHttp
        {
            get => _allowHttp;
            set
            {
                AllowHttpSpecified = true;
                _allowHttp = value;
            }
        }

        [XmlIgnore]
        protected bool AllowHttpSpecified { get; set; }

        private bool _allowHttps;

        [XmlElement(ElementName = "allowHttps", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
        public bool AllowHttps
        {
            get => _allowHttps;
            set
            {
                AllowHttpsSpecified = true;
                _allowHttps = value;
            }
        }

        [XmlIgnore]
        protected bool AllowHttpsSpecified { get; set; }

        private bool _allowTftp;

        [XmlElement(ElementName = "allowTftp", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
        public bool AllowTftp
        {
            get => _allowTftp;
            set
            {
                AllowTftpSpecified = true;
                _allowTftp = value;
            }
        }

        [XmlIgnore]
        protected bool AllowTftpSpecified { get; set; }

        private bool _enableCaching;

        [XmlElement(ElementName = "enableCaching", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
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

        private bool _allowUploadFromDevice;

        [XmlElement(ElementName = "allowUploadFromDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
        public bool AllowUploadFromDevice
        {
            get => _allowUploadFromDevice;
            set
            {
                AllowUploadFromDeviceSpecified = true;
                _allowUploadFromDevice = value;
            }
        }

        [XmlIgnore]
        protected bool AllowUploadFromDeviceSpecified { get; set; }

        private bool _defaultExtendedFileCaptureMode;

        [XmlElement(ElementName = "defaultExtendedFileCaptureMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:16021")]
        public bool DefaultExtendedFileCaptureMode
        {
            get => _defaultExtendedFileCaptureMode;
            set
            {
                DefaultExtendedFileCaptureModeSpecified = true;
                _defaultExtendedFileCaptureMode = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultExtendedFileCaptureModeSpecified { get; set; }

    }
}
