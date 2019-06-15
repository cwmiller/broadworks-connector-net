using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the specified Call Recording platform.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallRecordingModifyPlatformRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        public string Name {
            get => _name;
            set {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        public bool NameSpecified { get; set; }
        
        private string _netAddress;

        [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
        public string NetAddress {
            get => _netAddress;
            set {
                NetAddressSpecified = true;
                _netAddress = value;
            }
        }

        [XmlIgnore]
        public bool NetAddressSpecified { get; set; }
        
        private int? _port;

        [XmlElement(ElementName = "port", IsNullable = true, Namespace = "")]
        public int? Port {
            get => _port;
            set {
                PortSpecified = true;
                _port = value;
            }
        }

        [XmlIgnore]
        public bool PortSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MediaStream _mediaStream;

        [XmlElement(ElementName = "mediaStream", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MediaStream MediaStream {
            get => _mediaStream;
            set {
                MediaStreamSpecified = true;
                _mediaStream = value;
            }
        }

        [XmlIgnore]
        public bool MediaStreamSpecified { get; set; }
        
        private bool _becomeSystemDefault;

        [XmlElement(ElementName = "becomeSystemDefault", IsNullable = false, Namespace = "")]
        public bool BecomeSystemDefault {
            get => _becomeSystemDefault;
            set {
                BecomeSystemDefaultSpecified = true;
                _becomeSystemDefault = value;
            }
        }

        [XmlIgnore]
        public bool BecomeSystemDefaultSpecified { get; set; }
        
        private string _becomeResellerDefault;

        [XmlElement(ElementName = "becomeResellerDefault", IsNullable = false, Namespace = "")]
        public string BecomeResellerDefault {
            get => _becomeResellerDefault;
            set {
                BecomeResellerDefaultSpecified = true;
                _becomeResellerDefault = value;
            }
        }

        [XmlIgnore]
        public bool BecomeResellerDefaultSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ExtendedTransportProtocol _transportType;

        [XmlElement(ElementName = "transportType", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ExtendedTransportProtocol TransportType {
            get => _transportType;
            set {
                TransportTypeSpecified = true;
                _transportType = value;
            }
        }

        [XmlIgnore]
        public bool TransportTypeSpecified { get; set; }
        
        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        public string Description {
            get => _description;
            set {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        public bool DescriptionSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallRecordingPlatformSchemaVersion _schemaVersion;

        [XmlElement(ElementName = "schemaVersion", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallRecordingPlatformSchemaVersion SchemaVersion {
            get => _schemaVersion;
            set {
                SchemaVersionSpecified = true;
                _schemaVersion = value;
            }
        }

        [XmlIgnore]
        public bool SchemaVersionSpecified { get; set; }
        
        private bool _supportVideoRecording;

        [XmlElement(ElementName = "supportVideoRecording", IsNullable = false, Namespace = "")]
        public bool SupportVideoRecording {
            get => _supportVideoRecording;
            set {
                SupportVideoRecordingSpecified = true;
                _supportVideoRecording = value;
            }
        }

        [XmlIgnore]
        public bool SupportVideoRecordingSpecified { get; set; }
        
        private string _route;

        [XmlElement(ElementName = "route", IsNullable = true, Namespace = "")]
        public string Route {
            get => _route;
            set {
                RouteSpecified = true;
                _route = value;
            }
        }

        [XmlIgnore]
        public bool RouteSpecified { get; set; }
        
    }
}
