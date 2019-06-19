using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemConfigurableFileSystemGetRequest23.
    /// Contains the File System parameters.
    /// <see cref="SystemConfigurableFileSystemGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6278"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6280""}]}]")]
    public class SystemConfigurableFileSystemGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _mediaDirectory;

        [XmlElement(ElementName = "mediaDirectory", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6278")]
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

        private BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23ProtocolFile _protocolFile;

        [XmlElement(ElementName = "protocolFile", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6280")]
        public BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23ProtocolFile ProtocolFile
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

        private BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23ProtocolWebDAV _protocolWebDAV;

        [XmlElement(ElementName = "protocolWebDAV", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6280")]
        public BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23ProtocolWebDAV ProtocolWebDAV
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
