using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCPEConfigParametersGetListRequest.
    /// Contains a list of system CPE Config parameters.
    /// Replaced By: SystemCPEConfigParametersGetResponse14sp6
    /// <see cref="SystemCPEConfigParametersGetListRequest"/>
    /// <see cref="SystemCPEConfigParametersGetResponse14sp6"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:25879""}]")]
    public class SystemCPEConfigParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableIPDeviceManagement;

        [XmlElement(ElementName = "enableIPDeviceManagement", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:25879")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:25879")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:25879")]
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

    }
}
