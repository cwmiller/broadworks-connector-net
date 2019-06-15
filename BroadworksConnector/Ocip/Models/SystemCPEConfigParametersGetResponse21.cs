using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCPEConfigParametersGetRequest21.
    /// Contains a list of system CPE Config parameters.
    /// 
    /// The following elements are only used in AS data mode:
    /// allowDeviceCredentialsRetrieval, value "false" is returned in XS data mode
        /// <see cref="SystemCPEConfigParametersGetRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCPEConfigParametersGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _enableIPDeviceManagement;

        [XmlElement(ElementName = "enableIPDeviceManagement", IsNullable = false, Namespace = "")]
        public bool EnableIPDeviceManagement {
            get => _enableIPDeviceManagement;
            set {
                EnableIPDeviceManagementSpecified = true;
                _enableIPDeviceManagement = value;
            }
        }

        [XmlIgnore]
        public bool EnableIPDeviceManagementSpecified { get; set; }
        
        private int _ftpConnectTimeoutSeconds;

        [XmlElement(ElementName = "ftpConnectTimeoutSeconds", IsNullable = false, Namespace = "")]
        public int FtpConnectTimeoutSeconds {
            get => _ftpConnectTimeoutSeconds;
            set {
                FtpConnectTimeoutSecondsSpecified = true;
                _ftpConnectTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool FtpConnectTimeoutSecondsSpecified { get; set; }
        
        private int _ftpFileTransferTimeoutSeconds;

        [XmlElement(ElementName = "ftpFileTransferTimeoutSeconds", IsNullable = false, Namespace = "")]
        public int FtpFileTransferTimeoutSeconds {
            get => _ftpFileTransferTimeoutSeconds;
            set {
                FtpFileTransferTimeoutSecondsSpecified = true;
                _ftpFileTransferTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool FtpFileTransferTimeoutSecondsSpecified { get; set; }
        
        private int _pauseBetweenFileRebuildMilliseconds;

        [XmlElement(ElementName = "pauseBetweenFileRebuildMilliseconds", IsNullable = false, Namespace = "")]
        public int PauseBetweenFileRebuildMilliseconds {
            get => _pauseBetweenFileRebuildMilliseconds;
            set {
                PauseBetweenFileRebuildMillisecondsSpecified = true;
                _pauseBetweenFileRebuildMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool PauseBetweenFileRebuildMillisecondsSpecified { get; set; }
        
        private string _deviceAccessAppServerClusterName;

        [XmlElement(ElementName = "deviceAccessAppServerClusterName", IsNullable = false, Namespace = "")]
        public string DeviceAccessAppServerClusterName {
            get => _deviceAccessAppServerClusterName;
            set {
                DeviceAccessAppServerClusterNameSpecified = true;
                _deviceAccessAppServerClusterName = value;
            }
        }

        [XmlIgnore]
        public bool DeviceAccessAppServerClusterNameSpecified { get; set; }
        
        private int _minTimeBetweenResetMilliseconds;

        [XmlElement(ElementName = "minTimeBetweenResetMilliseconds", IsNullable = false, Namespace = "")]
        public int MinTimeBetweenResetMilliseconds {
            get => _minTimeBetweenResetMilliseconds;
            set {
                MinTimeBetweenResetMillisecondsSpecified = true;
                _minTimeBetweenResetMilliseconds = value;
            }
        }

        [XmlIgnore]
        public bool MinTimeBetweenResetMillisecondsSpecified { get; set; }
        
        private bool _alwaysPushFilesOnRebuild;

        [XmlElement(ElementName = "alwaysPushFilesOnRebuild", IsNullable = false, Namespace = "")]
        public bool AlwaysPushFilesOnRebuild {
            get => _alwaysPushFilesOnRebuild;
            set {
                AlwaysPushFilesOnRebuildSpecified = true;
                _alwaysPushFilesOnRebuild = value;
            }
        }

        [XmlIgnore]
        public bool AlwaysPushFilesOnRebuildSpecified { get; set; }
        
        private int _maxFileOperationRetryAttempts;

        [XmlElement(ElementName = "maxFileOperationRetryAttempts", IsNullable = false, Namespace = "")]
        public int MaxFileOperationRetryAttempts {
            get => _maxFileOperationRetryAttempts;
            set {
                MaxFileOperationRetryAttemptsSpecified = true;
                _maxFileOperationRetryAttempts = value;
            }
        }

        [XmlIgnore]
        public bool MaxFileOperationRetryAttemptsSpecified { get; set; }
        
        private bool _enableAutoRebuildConfig;

        [XmlElement(ElementName = "enableAutoRebuildConfig", IsNullable = false, Namespace = "")]
        public bool EnableAutoRebuildConfig {
            get => _enableAutoRebuildConfig;
            set {
                EnableAutoRebuildConfigSpecified = true;
                _enableAutoRebuildConfig = value;
            }
        }

        [XmlIgnore]
        public bool EnableAutoRebuildConfigSpecified { get; set; }
        
        private int _eventQueueSize;

        [XmlElement(ElementName = "eventQueueSize", IsNullable = false, Namespace = "")]
        public int EventQueueSize {
            get => _eventQueueSize;
            set {
                EventQueueSizeSpecified = true;
                _eventQueueSize = value;
            }
        }

        [XmlIgnore]
        public bool EventQueueSizeSpecified { get; set; }
        
        private bool _allowDeviceCredentialsRetrieval;

        [XmlElement(ElementName = "allowDeviceCredentialsRetrieval", IsNullable = false, Namespace = "")]
        public bool AllowDeviceCredentialsRetrieval {
            get => _allowDeviceCredentialsRetrieval;
            set {
                AllowDeviceCredentialsRetrievalSpecified = true;
                _allowDeviceCredentialsRetrieval = value;
            }
        }

        [XmlIgnore]
        public bool AllowDeviceCredentialsRetrievalSpecified { get; set; }
        
    }
}
