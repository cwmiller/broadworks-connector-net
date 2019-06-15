using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify CPE Config system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemCPEConfigParametersModifyRequest21
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="SystemCPEConfigParametersModifyRequest21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCPEConfigParametersModifyRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
        
        private int _maxBusyTimeMinutes;

        [XmlElement(ElementName = "maxBusyTimeMinutes", IsNullable = false, Namespace = "")]
        public int MaxBusyTimeMinutes {
            get => _maxBusyTimeMinutes;
            set {
                MaxBusyTimeMinutesSpecified = true;
                _maxBusyTimeMinutes = value;
            }
        }

        [XmlIgnore]
        public bool MaxBusyTimeMinutesSpecified { get; set; }
        
        private string _deviceAccessAppServerClusterName;

        [XmlElement(ElementName = "deviceAccessAppServerClusterName", IsNullable = true, Namespace = "")]
        public string DeviceAccessAppServerClusterName {
            get => _deviceAccessAppServerClusterName;
            set {
                DeviceAccessAppServerClusterNameSpecified = true;
                _deviceAccessAppServerClusterName = value;
            }
        }

        [XmlIgnore]
        public bool DeviceAccessAppServerClusterNameSpecified { get; set; }
        
    }
}
