using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMultimediaPolicyGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
