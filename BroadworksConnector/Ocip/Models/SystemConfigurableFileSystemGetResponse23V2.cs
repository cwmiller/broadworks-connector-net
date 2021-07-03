using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemConfigurableFileSystemGetRequest23V2.
    /// Contains the File System parameters.
    /// The following elements are only used in AS data mode:
    /// protocolFile-secure
    /// value "false" is returned in XS data mode
    /// <see cref="SystemConfigurableFileSystemGetRequest23V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6615"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:6617""}]}]")]
    public class SystemConfigurableFileSystemGetResponse23V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _mediaDirectory;

        [XmlElement(ElementName = "mediaDirectory", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6615")]
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
        protected bool MediaDirectorySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23V2ProtocolFile _protocolFile;

        [XmlElement(ElementName = "protocolFile", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6617")]
        public BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23V2ProtocolFile ProtocolFile
        {
            get => _protocolFile;
            set
            {
                ProtocolFileSpecified = true;
                _protocolFile = value;
            }
        }

        [XmlIgnore]
        protected bool ProtocolFileSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23V2ProtocolWebDAV _protocolWebDAV;

        [XmlElement(ElementName = "protocolWebDAV", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:6617")]
        public BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse23V2ProtocolWebDAV ProtocolWebDAV
        {
            get => _protocolWebDAV;
            set
            {
                ProtocolWebDAVSpecified = true;
                _protocolWebDAV = value;
            }
        }

        [XmlIgnore]
        protected bool ProtocolWebDAVSpecified { get; set; }

    }
}
