using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCPEConfigParametersGetListRequest14sp6.
    /// Contains a list of system CPE Config parameters.
    /// 
    /// Replaced by: SystemCPEConfigParametersGetResponse20
    /// <see cref="SystemCPEConfigParametersGetListRequest14sp6"/>
    /// <see cref="SystemCPEConfigParametersGetResponse20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:34520"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:34529""}]}]")]
    public class SystemCPEConfigParametersGetResponse14sp6 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableIPDeviceManagement;

        [XmlElement(ElementName = "enableIPDeviceManagement", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34520")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34520")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34520")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34520")]
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
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34520")]
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

        [XmlElement(ElementName = "deviceAccessAppServerClusterName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34520")]
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

        private string _fileRebuildImmediate;

        [XmlElement(ElementName = "fileRebuildImmediate", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34529")]
        public string FileRebuildImmediate
        {
            get => _fileRebuildImmediate;
            set
            {
                FileRebuildImmediateSpecified = true;
                _fileRebuildImmediate = value;
            }
        }

        [XmlIgnore]
        public bool FileRebuildImmediateSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemCPEConfigParametersGetResponse14sp6FileRebuildDaily _fileRebuildDaily;

        [XmlElement(ElementName = "fileRebuildDaily", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34529")]
        public BroadWorksConnector.Ocip.Models.SystemCPEConfigParametersGetResponse14sp6FileRebuildDaily FileRebuildDaily
        {
            get => _fileRebuildDaily;
            set
            {
                FileRebuildDailySpecified = true;
                _fileRebuildDaily = value;
            }
        }

        [XmlIgnore]
        public bool FileRebuildDailySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemCPEConfigParametersGetResponse14sp6FileRebuildHourly _fileRebuildHourly;

        [XmlElement(ElementName = "fileRebuildHourly", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34529")]
        public BroadWorksConnector.Ocip.Models.SystemCPEConfigParametersGetResponse14sp6FileRebuildHourly FileRebuildHourly
        {
            get => _fileRebuildHourly;
            set
            {
                FileRebuildHourlySpecified = true;
                _fileRebuildHourly = value;
            }
        }

        [XmlIgnore]
        public bool FileRebuildHourlySpecified { get; set; }

    }
}
