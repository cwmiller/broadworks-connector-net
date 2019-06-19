using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify File System parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6314"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6316"",""optional"":true}]}]")]
    public class SystemConfigurableFileSystemModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _mediaDirectory;

        [XmlElement(ElementName = "mediaDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6314")]
        [MinLength(1)]
        [MaxLength(256)]
        public string MediaDirectory
        {
            get => _mediaDirectory;
            set
            {
                MediaDirectorySpecified = true;
                _mediaDirectory = value;
            }
        }

        [XmlIgnore]
        public bool MediaDirectorySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemModifyRequestProtocolFile _protocolFile;

        [XmlElement(ElementName = "protocolFile", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6316")]
        public BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemModifyRequestProtocolFile ProtocolFile
        {
            get => _protocolFile;
            set
            {
                ProtocolFileSpecified = true;
                _protocolFile = value;
            }
        }

        [XmlIgnore]
        public bool ProtocolFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemModifyRequestProtocolWebDAV _protocolWebDAV;

        [XmlElement(ElementName = "protocolWebDAV", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6316")]
        public BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemModifyRequestProtocolWebDAV ProtocolWebDAV
        {
            get => _protocolWebDAV;
            set
            {
                ProtocolWebDAVSpecified = true;
                _protocolWebDAV = value;
            }
        }

        [XmlIgnore]
        public bool ProtocolWebDAVSpecified { get; set; }

    }
}
