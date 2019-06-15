using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a sip device type file.
    /// The response is either SuccessResponse or ErrorResponse.
    /// Replaced By: SystemSIPDeviceTypeFileModifyRequest14sp8
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemSIPDeviceTypeFileModifyRequest14sp8"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemSIPDeviceTypeFileModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        public string DeviceType {
            get => _deviceType;
            set {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        public bool DeviceTypeSpecified { get; set; }
        
        private string _fileType;

        [XmlElement(ElementName = "fileType", IsNullable = false, Namespace = "")]
        public string FileType {
            get => _fileType;
            set {
                FileTypeSpecified = true;
                _fileType = value;
            }
        }

        [XmlIgnore]
        public bool FileTypeSpecified { get; set; }
        
        private bool _allowFileCustomization;

        [XmlElement(ElementName = "allowFileCustomization", IsNullable = false, Namespace = "")]
        public bool AllowFileCustomization {
            get => _allowFileCustomization;
            set {
                AllowFileCustomizationSpecified = true;
                _allowFileCustomization = value;
            }
        }

        [XmlIgnore]
        public bool AllowFileCustomizationSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.DeviceTypeFileEnhancedConfigurationMode _fileSource;

        [XmlElement(ElementName = "fileSource", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DeviceTypeFileEnhancedConfigurationMode FileSource {
            get => _fileSource;
            set {
                FileSourceSpecified = true;
                _fileSource = value;
            }
        }

        [XmlIgnore]
        public bool FileSourceSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.FileResource _uploadFile;

        [XmlElement(ElementName = "uploadFile", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.FileResource UploadFile {
            get => _uploadFile;
            set {
                UploadFileSpecified = true;
                _uploadFile = value;
            }
        }

        [XmlIgnore]
        public bool UploadFileSpecified { get; set; }
        
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

        [XmlElement(ElementName = "macFormatInNonRequestURI", IsNullable = true, Namespace = "")]
        public string MacFormatInNonRequestURI {
            get => _macFormatInNonRequestURI;
            set {
                MacFormatInNonRequestURISpecified = true;
                _macFormatInNonRequestURI = value;
            }
        }

        [XmlIgnore]
        public bool MacFormatInNonRequestURISpecified { get; set; }
        
    }
}
