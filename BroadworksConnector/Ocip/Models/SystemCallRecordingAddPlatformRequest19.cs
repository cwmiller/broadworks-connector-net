using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallRecordingAddPlatformRequest19 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private int _port;

    [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
    public int Port {
        get => _port;
        set {
            PortSpecified = true;
            _port = value;
        }
    }

    [XmlIgnore]
    public bool PortSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MediaStream _mediaStream;

    [XmlElement(ElementName = "mediaStream", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MediaStream MediaStream {
        get => _mediaStream;
        set {
            MediaStreamSpecified = true;
            _mediaStream = value;
        }
    }

    [XmlIgnore]
    public bool MediaStreamSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TransportProtocol _transportType;

    [XmlElement(ElementName = "transportType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TransportProtocol TransportType {
        get => _transportType;
        set {
            TransportTypeSpecified = true;
            _transportType = value;
        }
    }

    [XmlIgnore]
    public bool TransportTypeSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallRecordingPlatformSchemaVersion _schemaVersion;

    [XmlElement(ElementName = "schemaVersion", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallRecordingPlatformSchemaVersion SchemaVersion {
        get => _schemaVersion;
        set {
            SchemaVersionSpecified = true;
            _schemaVersion = value;
        }
    }

    [XmlIgnore]
    public bool SchemaVersionSpecified { get; set; }
}
}
