using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _totalNumberOfRows;

    [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
    public int TotalNumberOfRows {
        get => _totalNumberOfRows;
        set {
            TotalNumberOfRowsSpecified = true;
            _totalNumberOfRows = value;
        }
    }

    [XmlIgnore]
    public bool TotalNumberOfRowsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse17sp4LegacyEntry _legacyEntry;

    [XmlElement(ElementName = "legacyEntry", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse17sp4LegacyEntry LegacyEntry {
        get => _legacyEntry;
        set {
            LegacyEntrySpecified = true;
            _legacyEntry = value;
        }
    }

    [XmlIgnore]
    public bool LegacyEntrySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse17sp4ExtendedEntry _extendedEntry;

    [XmlElement(ElementName = "extendedEntry", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse17sp4ExtendedEntry ExtendedEntry {
        get => _extendedEntry;
        set {
            ExtendedEntrySpecified = true;
            _extendedEntry = value;
        }
    }

    [XmlIgnore]
    public bool ExtendedEntrySpecified { get; set; }
}
}
