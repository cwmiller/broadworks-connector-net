using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCPEConfigParametersGetListRequest20.
    /// Contains a list of system CPE Config parameters.
    /// Replaced by: SystemCPEConfigParametersGetResponse21
    /// <see cref="SystemCPEConfigParametersGetListRequest20"/>
    /// <see cref="SystemCPEConfigParametersGetResponse21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:34564""}]")]
    public class SystemCPEConfigParametersGetResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableIPDeviceManagement;

        [XmlElement(ElementName = "enableIPDeviceManagement", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34564")]
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

        private int _ftpConnectTimeoutSeconds;

        [XmlElement(ElementName = "ftpConnectTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34564")]
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

        private int _ftpFileTransferTimeoutSeconds;

        [XmlElement(ElementName = "ftpFileTransferTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34564")]
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

        private int _pauseBetweenFileRebuildMilliseconds;

        [XmlElement(ElementName = "pauseBetweenFileRebuildMilliseconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34564")]
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

        private int _maxBusyTimeMinutes;

        [XmlElement(ElementName = "maxBusyTimeMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34564")]
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
        protected bool MaxBusyTimeMinutesSpecified { get; set; }

        private string _deviceAccessAppServerClusterName;

        [XmlElement(ElementName = "deviceAccessAppServerClusterName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34564")]
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

    }
}
