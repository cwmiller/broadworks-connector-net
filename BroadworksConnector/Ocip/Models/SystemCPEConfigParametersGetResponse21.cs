using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:7186""}]")]
    public class SystemCPEConfigParametersGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableIPDeviceManagement;

        [XmlElement(ElementName = "enableIPDeviceManagement", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7186")]
        public bool EnableIPDeviceManagement
        {
            get => _enableIPDeviceManagement;
            set
            {
                EnableIPDeviceManagementSpecified = true;
                _enableIPDeviceManagement = value;
            }
        }

        [XmlIgnore]
        protected bool EnableIPDeviceManagementSpecified { get; set; }

        protected int _ftpConnectTimeoutSeconds;

        [XmlElement(ElementName = "ftpConnectTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7186")]
        [MinInclusive(1)]
        [MaxInclusive(600)]
        public int FtpConnectTimeoutSeconds
        {
            get => _ftpConnectTimeoutSeconds;
            set
            {
                FtpConnectTimeoutSecondsSpecified = true;
                _ftpConnectTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool FtpConnectTimeoutSecondsSpecified { get; set; }

        protected int _ftpFileTransferTimeoutSeconds;

        [XmlElement(ElementName = "ftpFileTransferTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7186")]
        [MinInclusive(1)]
        [MaxInclusive(600)]
        public int FtpFileTransferTimeoutSeconds
        {
            get => _ftpFileTransferTimeoutSeconds;
            set
            {
                FtpFileTransferTimeoutSecondsSpecified = true;
                _ftpFileTransferTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool FtpFileTransferTimeoutSecondsSpecified { get; set; }

        protected int _pauseBetweenFileRebuildMilliseconds;

        [XmlElement(ElementName = "pauseBetweenFileRebuildMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7186")]
        [MinInclusive(0)]
        [MaxInclusive(10000)]
        public int PauseBetweenFileRebuildMilliseconds
        {
            get => _pauseBetweenFileRebuildMilliseconds;
            set
            {
                PauseBetweenFileRebuildMillisecondsSpecified = true;
                _pauseBetweenFileRebuildMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool PauseBetweenFileRebuildMillisecondsSpecified { get; set; }

        protected string _deviceAccessAppServerClusterName;

        [XmlElement(ElementName = "deviceAccessAppServerClusterName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:7186")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DeviceAccessAppServerClusterName
        {
            get => _deviceAccessAppServerClusterName;
            set
            {
                DeviceAccessAppServerClusterNameSpecified = true;
                _deviceAccessAppServerClusterName = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceAccessAppServerClusterNameSpecified { get; set; }

        protected int _minTimeBetweenResetMilliseconds;

        [XmlElement(ElementName = "minTimeBetweenResetMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7186")]
        [MinInclusive(0)]
        [MaxInclusive(86400000)]
        public int MinTimeBetweenResetMilliseconds
        {
            get => _minTimeBetweenResetMilliseconds;
            set
            {
                MinTimeBetweenResetMillisecondsSpecified = true;
                _minTimeBetweenResetMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool MinTimeBetweenResetMillisecondsSpecified { get; set; }

        protected bool _alwaysPushFilesOnRebuild;

        [XmlElement(ElementName = "alwaysPushFilesOnRebuild", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7186")]
        public bool AlwaysPushFilesOnRebuild
        {
            get => _alwaysPushFilesOnRebuild;
            set
            {
                AlwaysPushFilesOnRebuildSpecified = true;
                _alwaysPushFilesOnRebuild = value;
            }
        }

        [XmlIgnore]
        protected bool AlwaysPushFilesOnRebuildSpecified { get; set; }

        protected int _maxFileOperationRetryAttempts;

        [XmlElement(ElementName = "maxFileOperationRetryAttempts", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7186")]
        [MinInclusive(0)]
        [MaxInclusive(20)]
        public int MaxFileOperationRetryAttempts
        {
            get => _maxFileOperationRetryAttempts;
            set
            {
                MaxFileOperationRetryAttemptsSpecified = true;
                _maxFileOperationRetryAttempts = value;
            }
        }

        [XmlIgnore]
        protected bool MaxFileOperationRetryAttemptsSpecified { get; set; }

        protected bool _enableAutoRebuildConfig;

        [XmlElement(ElementName = "enableAutoRebuildConfig", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7186")]
        public bool EnableAutoRebuildConfig
        {
            get => _enableAutoRebuildConfig;
            set
            {
                EnableAutoRebuildConfigSpecified = true;
                _enableAutoRebuildConfig = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutoRebuildConfigSpecified { get; set; }

        protected int _eventQueueSize;

        [XmlElement(ElementName = "eventQueueSize", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7186")]
        [MinInclusive(0)]
        [MaxInclusive(100000000)]
        public int EventQueueSize
        {
            get => _eventQueueSize;
            set
            {
                EventQueueSizeSpecified = true;
                _eventQueueSize = value;
            }
        }

        [XmlIgnore]
        protected bool EventQueueSizeSpecified { get; set; }

        protected bool _allowDeviceCredentialsRetrieval;

        [XmlElement(ElementName = "allowDeviceCredentialsRetrieval", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:7186")]
        public bool AllowDeviceCredentialsRetrieval
        {
            get => _allowDeviceCredentialsRetrieval;
            set
            {
                AllowDeviceCredentialsRetrievalSpecified = true;
                _allowDeviceCredentialsRetrieval = value;
            }
        }

        [XmlIgnore]
        protected bool AllowDeviceCredentialsRetrievalSpecified { get; set; }

    }
}
