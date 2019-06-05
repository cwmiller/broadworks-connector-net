using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupIMRNGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _imrn;

    [XmlElement(ElementName = "imrn", IsNullable = false, Namespace = "")]
    public List<string> Imrn {
        get => _imrn;
        set {
            ImrnSpecified = true;
            _imrn = value;
        }
    }

    [XmlIgnore]
    public bool ImrnSpecified { get; set; }
}
}
