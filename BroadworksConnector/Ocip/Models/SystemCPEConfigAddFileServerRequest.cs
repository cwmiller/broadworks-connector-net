using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a device CPE config file server.
    /// The response is either SuccessResponse or ErrorResponse.
    /// Replaced By: SystemCPEConfigAddFileServerRequest14sp6
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCPEConfigAddFileServerRequest14sp6"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:25756""}]")]
    public class SystemCPEConfigAddFileServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:25756")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DeviceType
        {
            get => _deviceType;
            set
            {
                DeviceTypeSpecified = true;
                _deviceType = value;
            }
        }

        [XmlIgnore]
        protected bool DeviceTypeSpecified { get; set; }

        protected string _ftpHostNetAddress;

        [XmlElement(ElementName = "ftpHostNetAddress", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:25756")]
        [MinLength(1)]
        [MaxLength(80)]
        public string FtpHostNetAddress
        {
            get => _ftpHostNetAddress;
            set
            {
                FtpHostNetAddressSpecified = true;
                _ftpHostNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool FtpHostNetAddressSpecified { get; set; }

        protected string _ftpUserId;

        [XmlElement(ElementName = "ftpUserId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:25756")]
        [MinLength(1)]
        [MaxLength(30)]
        public string FtpUserId
        {
            get => _ftpUserId;
            set
            {
                FtpUserIdSpecified = true;
                _ftpUserId = value;
            }
        }

        [XmlIgnore]
        protected bool FtpUserIdSpecified { get; set; }

        protected string _ftpUserPassword;

        [XmlElement(ElementName = "ftpUserPassword", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:25756")]
        [MinLength(1)]
        [MaxLength(40)]
        public string FtpUserPassword
        {
            get => _ftpUserPassword;
            set
            {
                FtpUserPasswordSpecified = true;
                _ftpUserPassword = value;
            }
        }

        [XmlIgnore]
        protected bool FtpUserPasswordSpecified { get; set; }

        protected string _cpeFileDirectory;

        [XmlElement(ElementName = "cpeFileDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:25756")]
        [MinLength(1)]
        [MaxLength(256)]
        public string CpeFileDirectory
        {
            get => _cpeFileDirectory;
            set
            {
                CpeFileDirectorySpecified = true;
                _cpeFileDirectory = value;
            }
        }

        [XmlIgnore]
        protected bool CpeFileDirectorySpecified { get; set; }

        protected bool _passiveFTP;

        [XmlElement(ElementName = "passiveFTP", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:25756")]
        public bool PassiveFTP
        {
            get => _passiveFTP;
            set
            {
                PassiveFTPSpecified = true;
                _passiveFTP = value;
            }
        }

        [XmlIgnore]
        protected bool PassiveFTPSpecified { get; set; }

    }
}
