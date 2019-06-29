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
    /// Replaced by: SystemCPEConfigParametersModifyRequest20.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCPEConfigParametersModifyRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:34589"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:34600"",""optional"":true}]}]")]
    public class SystemCPEConfigParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _enableIPDeviceManagement;

        [XmlElement(ElementName = "enableIPDeviceManagement", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34589")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34589")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34589")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34589")]
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
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34589")]
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

        [XmlElement(ElementName = "deviceAccessAppServerClusterName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34589")]
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

        private string _fileRebuildImmediate;

        [XmlElement(ElementName = "fileRebuildImmediate", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34600")]
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
        protected bool FileRebuildImmediateSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemCPEConfigParametersModifyRequestFileRebuildDaily _fileRebuildDaily;

        [XmlElement(ElementName = "fileRebuildDaily", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34600")]
        public BroadWorksConnector.Ocip.Models.SystemCPEConfigParametersModifyRequestFileRebuildDaily FileRebuildDaily
        {
            get => _fileRebuildDaily;
            set
            {
                FileRebuildDailySpecified = true;
                _fileRebuildDaily = value;
            }
        }

        [XmlIgnore]
        protected bool FileRebuildDailySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemCPEConfigParametersModifyRequestFileRebuildHourly _fileRebuildHourly;

        [XmlElement(ElementName = "fileRebuildHourly", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34600")]
        public BroadWorksConnector.Ocip.Models.SystemCPEConfigParametersModifyRequestFileRebuildHourly FileRebuildHourly
        {
            get => _fileRebuildHourly;
            set
            {
                FileRebuildHourlySpecified = true;
                _fileRebuildHourly = value;
            }
        }

        [XmlIgnore]
        protected bool FileRebuildHourlySpecified { get; set; }

    }
}
