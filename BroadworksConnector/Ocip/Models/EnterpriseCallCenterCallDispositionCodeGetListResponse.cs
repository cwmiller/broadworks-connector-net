using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterCallDispositionCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _dispositionCodesTable;

    [XmlElement(ElementName = "dispositionCodesTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DispositionCodesTable {
        get => _dispositionCodesTable;
        set {
            DispositionCodesTableSpecified = true;
            _dispositionCodesTable = value;
        }
    }

    [XmlIgnore]
    public bool DispositionCodesTableSpecified { get; set; }
}
}
