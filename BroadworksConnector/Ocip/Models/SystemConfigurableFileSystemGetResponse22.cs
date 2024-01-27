using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemConfigurableFileSystemGetRequest22.
    /// Contains the File System parameters.
    /// The following elements are only used in AS data mode:
    /// protocolFile-secure
    /// value "false" is returned in XS data mode
    /// <see cref="SystemConfigurableFileSystemGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9706"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9708""}]}]")]
    public class SystemConfigurableFileSystemGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _mediaDirectory;

        [XmlElement(ElementName = "mediaDirectory", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9706")]
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

        protected BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse22ProtocolFile _protocolFile;

        [XmlElement(ElementName = "protocolFile", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9708")]
        public BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse22ProtocolFile ProtocolFile
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

        protected BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse22ProtocolWebDAV _protocolWebDAV;

        [XmlElement(ElementName = "protocolWebDAV", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:9708")]
        public BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponse22ProtocolWebDAV ProtocolWebDAV
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
