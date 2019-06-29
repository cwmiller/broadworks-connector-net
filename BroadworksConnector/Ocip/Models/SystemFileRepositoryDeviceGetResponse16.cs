using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemFileRepositoryDeviceGetRequest16.
    /// 
    /// Replaced by: SystemFileRepositoryDeviceGetResponse20 in AS data mode
    /// <see cref="SystemFileRepositoryDeviceGetRequest16"/>
    /// <see cref="SystemFileRepositoryDeviceGetResponse20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:41931"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:41934""}]}]")]
    public class SystemFileRepositoryDeviceGetResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _rootDirectory;

        [XmlElement(ElementName = "rootDirectory", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41931")]
        [MinLength(1)]
        [MaxLength(256)]
        public string RootDirectory
        {
            get => _rootDirectory;
            set
            {
                RootDirectorySpecified = true;
                _rootDirectory = value;
            }
        }

        [XmlIgnore]
        protected bool RootDirectorySpecified { get; set; }

        private int _port;

        [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41931")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int Port
        {
            get => _port;
            set
            {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        protected bool PortSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.FileRepositoryProtocolWebDAV _protocolWebDAV;

        [XmlElement(ElementName = "protocolWebDAV", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41934")]
        public BroadWorksConnector.Ocip.Models.FileRepositoryProtocolWebDAV ProtocolWebDAV
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

        private BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 _protocolFTP;

        [XmlElement(ElementName = "protocolFTP", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41934")]
        public BroadWorksConnector.Ocip.Models.FileRepositoryProtocolFTP16 ProtocolFTP
        {
            get => _protocolFTP;
            set
            {
                ProtocolFTPSpecified = true;
                _protocolFTP = value;
            }
        }

        [XmlIgnore]
        protected bool ProtocolFTPSpecified { get; set; }

    }
}
