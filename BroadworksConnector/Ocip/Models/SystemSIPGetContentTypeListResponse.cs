using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPGetContentTypeListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _contentTypeTable;

    [XmlElement(ElementName = "contentTypeTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ContentTypeTable {
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
