using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemFileRepositoryDeviceUserGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _allowPut;

    [XmlElement(ElementName = "allowPut", IsNullable = false, Namespace = "")]
    public bool AllowPut {
        get => _allowPut;
        set {
            AllowPutSpecified = true;
            _allowPut = value;
        }
    }

    [XmlIgnore]
    public bool AllowPutSpecified { get; set; }
    private bool _allowDelete;

    [XmlElement(ElementName = "allowDelete", IsNullable = false, Namespace = "")]
    public bool AllowDelete {
        get => _allowDelete;
        set {
            AllowDeleteSpecified = true;
            _allowDelete = value;
        }
    }

    [XmlIgnore]
    public bool AllowDeleteSpecified { get; set; }
    private bool _allowGet;

    [XmlElement(ElementName = "allowGet", IsNullable = false, Namespace = "")]
    public bool AllowGet {
        get => _allowGet;
        set {
            AllowGetSpecified = true;
            _allowGet = value;
        }
    }

    [XmlIgnore]
    public bool AllowGetSpecified { get; set; }
}
}
