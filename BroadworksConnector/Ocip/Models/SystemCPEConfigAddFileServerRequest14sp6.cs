using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a device CPE config file server.
    /// The following elements are only used in AS data mode:
    /// extendedCaptureFileRepositoryName
    /// 
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6971""}]")]
    public class SystemCPEConfigAddFileServerRequest14sp6 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _deviceType;

        [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6971")]
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

        private string _fileRepositoryName;

        [XmlElement(ElementName = "fileRepositoryName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6971")]
        [MinLength(1)]
        [MaxLength(40)]
        public string FileRepositoryName
        {
            get => _fileRepositoryName;
            set
            {
                FileRepositoryNameSpecified = true;
                _fileRepositoryName = value;
            }
        }

        [XmlIgnore]
        protected bool FileRepositoryNameSpecified { get; set; }

        private string _cpeFileDirectory;

        [XmlElement(ElementName = "cpeFileDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6971")]
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

        private string _extendedCaptureFileRepositoryName;

        [XmlElement(ElementName = "extendedCaptureFileRepositoryName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6971")]
        [MinLength(1)]
        [MaxLength(40)]
        public string ExtendedCaptureFileRepositoryName
        {
            get => _extendedCaptureFileRepositoryName;
            set
            {
                ExtendedCaptureFileRepositoryNameSpecified = true;
                _extendedCaptureFileRepositoryName = value;
            }
        }

        [XmlIgnore]
        protected bool ExtendedCaptureFileRepositoryNameSpecified { get; set; }

    }
}
