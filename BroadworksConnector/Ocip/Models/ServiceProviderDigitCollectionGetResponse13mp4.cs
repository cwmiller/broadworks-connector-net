using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDigitCollectionGetResponse13mp4 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _accessCode;

    [XmlElement(ElementName = "accessCode", IsNullable = false, Namespace = "")]
    public string AccessCode {
        get => _accessCode;
        set {
            AccessCodeSpecified = true;
            _accessCode = value;
        }
    }

    [XmlIgnore]
    public bool AccessCodeSpecified { get; set; }
    private string _publicDigitMap;

    [XmlElement(ElementName = "publicDigitMap", IsNullable = false, Namespace = "")]
    public string PublicDigitMap {
        get => _publicDigitMap;
        set {
            PublicDigitMapSpecified = true;
            _publicDigitMap = value;
        }
    }

    [XmlIgnore]
    public bool PublicDigitMapSpecified { get; set; }
    private string _privateDigitMap;

    [XmlElement(ElementName = "privateDigitMap", IsNullable = false, Namespace = "")]
    public string PrivateDigitMap {
        get => _privateDigitMap;
        set {
            PrivateDigitMapSpecified = true;
            _privateDigitMap = value;
        }
    }

    [XmlIgnore]
    public bool PrivateDigitMapSpecified { get; set; }
}
}
