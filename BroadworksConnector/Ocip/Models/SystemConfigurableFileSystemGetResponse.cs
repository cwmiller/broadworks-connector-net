using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemConfigurableFileSystemGetRequest.
    /// Regardless of element password being there in the response, the request is never going
    /// to return the password in response.
    /// Contains the File System parameters.
    /// <see cref="SystemConfigurableFileSystemGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:1549"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:1551""}]}]")]
    public class SystemConfigurableFileSystemGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _mediaDirectory;

        [XmlElement(ElementName = "mediaDirectory", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1549")]
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

        private BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponseProtocolFile _protocolFile;

        [XmlElement(ElementName = "protocolFile", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1551")]
        public BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponseProtocolFile ProtocolFile
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

        private BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponseProtocolWebDAV _protocolWebDAV;

        [XmlElement(ElementName = "protocolWebDAV", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:1551")]
        public BroadWorksConnector.Ocip.Models.SystemConfigurableFileSystemGetResponseProtocolWebDAV ProtocolWebDAV
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
