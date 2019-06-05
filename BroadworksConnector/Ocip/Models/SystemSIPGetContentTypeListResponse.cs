using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPGetContentTypeListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _contentTypeTable;

    [XmlElement(ElementName = "contentTypeTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ContentTypeTable {
        get => _contentTypeTable;
        set {
            ContentTypeTableSpecified = true;
            _contentTypeTable = value;
        }
    }

    [XmlIgnore]
    public bool ContentTypeTableSpecified { get; set; }
}
}
