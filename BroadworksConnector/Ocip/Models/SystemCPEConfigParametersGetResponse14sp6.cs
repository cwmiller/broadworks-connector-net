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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:25899"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:25906""}]}]")]
    public class SystemCPEConfigParametersGetResponse14sp6 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableIPDeviceManagement;

        [XmlElement(ElementName = "enableIPDeviceManagement", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:25899")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:25899")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:25899")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:25899")]
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

        protected int _maxBusyTimeMinutes;

        [XmlElement(ElementName = "maxBusyTimeMinutes", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:25899")]
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

        protected string _deviceAccessAppServerClusterName;

        [XmlElement(ElementName = "deviceAccessAppServerClusterName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:25899")]
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

        protected string _fileRebuildImmediate;

        [XmlElement(ElementName = "fileRebuildImmediate", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:25906")]
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

        protected BroadWorksConnector.Ocip.Models.SystemCPEConfigParametersGetResponse14sp6FileRebuildDaily _fileRebuildDaily;

        [XmlElement(ElementName = "fileRebuildDaily", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:25906")]
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
        protected bool FileRebuildDailySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemCPEConfigParametersGetResponse14sp6FileRebuildHourly _fileRebuildHourly;

        [XmlElement(ElementName = "fileRebuildHourly", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:25906")]
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
        protected bool FileRebuildHourlySpecified { get; set; }

    }
}
