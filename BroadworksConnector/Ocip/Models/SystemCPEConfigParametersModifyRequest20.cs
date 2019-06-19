using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:34636""}]")]
    public class SystemCPEConfigParametersModifyRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _enableIPDeviceManagement;

        [XmlElement(ElementName = "enableIPDeviceManagement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34636")]
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
        public bool EnableIPDeviceManagementSpecified { get; set; }

        private int _ftpConnectTimeoutSeconds;

        [XmlElement(ElementName = "ftpConnectTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34636")]
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
        public bool FtpConnectTimeoutSecondsSpecified { get; set; }

        private int _ftpFileTransferTimeoutSeconds;

        [XmlElement(ElementName = "ftpFileTransferTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34636")]
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
        public bool FtpFileTransferTimeoutSecondsSpecified { get; set; }

        private int _pauseBetweenFileRebuildMilliseconds;

        [XmlElement(ElementName = "pauseBetweenFileRebuildMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34636")]
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
        public bool PauseBetweenFileRebuildMillisecondsSpecified { get; set; }

        private int _maxBusyTimeMinutes;

        [XmlElement(ElementName = "maxBusyTimeMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34636")]
        [MinInclusive(1)]
        [MaxInclusive(1440)]
        public int MaxBusyTimeMinutes
        {
            get => _maxBusyTimeMinutes;
            set
            {
                MaxBusyTimeMinutesSpecified = true;
                _maxBusyTimeMinutes = value;
            }
        }

        [XmlIgnore]
        public bool MaxBusyTimeMinutesSpecified { get; set; }

        private string _deviceAccessAppServerClusterName;

        [XmlElement(ElementName = "deviceAccessAppServerClusterName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34636")]
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
        public bool DeviceAccessAppServerClusterNameSpecified { get; set; }

    }
}
