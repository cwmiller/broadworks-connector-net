using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMultimediaPolicyModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private bool _restrictNonAudioVideoMediaTypes;

    [XmlElement(ElementName = "restrictNonAudioVideoMediaTypes", IsNullable = false, Namespace = "")]
    public bool RestrictNonAudioVideoMediaTypes {
        get => _restrictNonAudioVideoMediaTypes;
        set {
            RestrictNonAudioVideoMediaTypesSpecified = true;
            _restrictNonAudioVideoMediaTypes = value;
        }
    }

    [XmlIgnore]
    public bool RestrictNonAudioVideoMediaTypesSpecified { get; set; }
}
}
