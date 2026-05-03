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
    /// 
    /// The following elements are ignored in XS data mode:
    /// bearerFileAuthentication
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:17520""}]")]
    public class SystemSIPDeviceTypeFileModifyRequest16sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
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

        protected string _fileFormat;

        [XmlElement(ElementName = "fileFormat", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
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

        protected BroadWorksConnector.Ocip.Models.DeviceManagementFileCustomization? _fileCustomization;

        [XmlElement(ElementName = "fileCustomization", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
        public BroadWorksConnector.Ocip.Models.DeviceManagementFileCustomization? FileCustomization
        {
            get => _fileCustomization;
            set
            {
                FileCustomizationSpecified = (value != null);
                _fileCustomization = value;
            }
        }

        [XmlIgnore]
        protected bool FileCustomizationSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DeviceTypeFileEnhancedConfigurationMode? _fileSource;

        [XmlElement(ElementName = "fileSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
        public BroadWorksConnector.Ocip.Models.DeviceTypeFileEnhancedConfigurationMode? FileSource
        {
            get => _fileSource;
            set
            {
                FileSourceSpecified = (value != null);
                _fileSource = value;
            }
        }

        [XmlIgnore]
        protected bool FileSourceSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.FileResource _uploadFile;

        [XmlElement(ElementName = "uploadFile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
        public BroadWorksConnector.Ocip.Models.FileResource UploadFile
        {
            get => _uploadFile;
            set
            {
                UploadFileSpecified = (value != null);
                _uploadFile = value;
            }
        }

        [XmlIgnore]
        protected bool UploadFileSpecified { get; set; }

        protected bool? _useHttpDigestAuthentication;

        [XmlElement(ElementName = "useHttpDigestAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
        public bool? UseHttpDigestAuthentication
        {
            get => _useHttpDigestAuthentication;
            set
            {
                UseHttpDigestAuthenticationSpecified = (value != null);
                _useHttpDigestAuthentication = value;
            }
        }

        [XmlIgnore]
        protected bool UseHttpDigestAuthenticationSpecified { get; set; }

        protected bool? _macBasedFileAuthentication;

        [XmlElement(ElementName = "macBasedFileAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
        public bool? MacBasedFileAuthentication
        {
            get => _macBasedFileAuthentication;
            set
            {
                MacBasedFileAuthenticationSpecified = (value != null);
                _macBasedFileAuthentication = value;
            }
        }

        [XmlIgnore]
        protected bool MacBasedFileAuthenticationSpecified { get; set; }

        protected bool? _userNamePasswordFileAuthentication;

        [XmlElement(ElementName = "userNamePasswordFileAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
        public bool? UserNamePasswordFileAuthentication
        {
            get => _userNamePasswordFileAuthentication;
            set
            {
                UserNamePasswordFileAuthenticationSpecified = (value != null);
                _userNamePasswordFileAuthentication = value;
            }
        }

        [XmlIgnore]
        protected bool UserNamePasswordFileAuthenticationSpecified { get; set; }

        protected bool? _macInNonRequestURI;

        [XmlElement(ElementName = "macInNonRequestURI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
        public bool? MacInNonRequestURI
        {
            get => _macInNonRequestURI;
            set
            {
                MacInNonRequestURISpecified = (value != null);
                _macInNonRequestURI = value;
            }
        }

        [XmlIgnore]
        protected bool MacInNonRequestURISpecified { get; set; }

        protected bool? _macInCert;

        [XmlElement(ElementName = "macInCert", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
        public bool? MacInCert
        {
            get => _macInCert;
            set
            {
                MacInCertSpecified = (value != null);
                _macInCert = value;
            }
        }

        [XmlIgnore]
        protected bool MacInCertSpecified { get; set; }

        protected string _macFormatInNonRequestURI;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
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

        protected bool? _allowHttp;

        [XmlElement(ElementName = "allowHttp", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
        public bool? AllowHttp
        {
            get => _allowHttp;
            set
            {
                AllowHttpSpecified = (value != null);
                _allowHttp = value;
            }
        }

        [XmlIgnore]
        protected bool AllowHttpSpecified { get; set; }

        protected bool? _allowHttps;

        [XmlElement(ElementName = "allowHttps", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
        public bool? AllowHttps
        {
            get => _allowHttps;
            set
            {
                AllowHttpsSpecified = (value != null);
                _allowHttps = value;
            }
        }

        [XmlIgnore]
        protected bool AllowHttpsSpecified { get; set; }

        protected bool? _allowTftp;

        [XmlElement(ElementName = "allowTftp", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
        public bool? AllowTftp
        {
            get => _allowTftp;
            set
            {
                AllowTftpSpecified = (value != null);
                _allowTftp = value;
            }
        }

        [XmlIgnore]
        protected bool AllowTftpSpecified { get; set; }

        protected bool? _enableCaching;

        [XmlElement(ElementName = "enableCaching", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
        public bool? EnableCaching
        {
            get => _enableCaching;
            set
            {
                EnableCachingSpecified = (value != null);
                _enableCaching = value;
            }
        }

        [XmlIgnore]
        protected bool EnableCachingSpecified { get; set; }

        protected bool? _allowUploadFromDevice;

        [XmlElement(ElementName = "allowUploadFromDevice", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
        public bool? AllowUploadFromDevice
        {
            get => _allowUploadFromDevice;
            set
            {
                AllowUploadFromDeviceSpecified = (value != null);
                _allowUploadFromDevice = value;
            }
        }

        [XmlIgnore]
        protected bool AllowUploadFromDeviceSpecified { get; set; }

        protected bool? _defaultExtendedFileCaptureMode;

        [XmlElement(ElementName = "defaultExtendedFileCaptureMode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
        public bool? DefaultExtendedFileCaptureMode
        {
            get => _defaultExtendedFileCaptureMode;
            set
            {
                DefaultExtendedFileCaptureModeSpecified = (value != null);
                _defaultExtendedFileCaptureMode = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultExtendedFileCaptureModeSpecified { get; set; }

        protected bool? _bearerFileAuthentication;

        [XmlElement(ElementName = "bearerFileAuthentication", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:17520")]
        public bool? BearerFileAuthentication
        {
            get => _bearerFileAuthentication;
            set
            {
                BearerFileAuthenticationSpecified = (value != null);
                _bearerFileAuthentication = value;
            }
        }

        [XmlIgnore]
        protected bool BearerFileAuthenticationSpecified { get; set; }

    }
}
