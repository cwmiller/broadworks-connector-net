using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemEnhancedCallLogsModifyRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private int _maxNonPagedResponseSize;

    [XmlElement(ElementName = "maxNonPagedResponseSize", IsNullable = false, Namespace = "")]
    public int MaxNonPagedResponseSize {
        get => _maxNonPagedResponseSize;
        set {
            MaxNonPagedResponseSizeSpecified = true;
            _maxNonPagedResponseSize = value;
        }
    }

    [XmlIgnore]
    public bool MaxNonPagedResponseSizeSpecified { get; set; }
    private string _eclQueryApplicationURL;

    [XmlElement(ElementName = "eclQueryApplicationURL", IsNullable = true, Namespace = "")]
    public string EclQueryApplicationURL {
        get => _eclQueryApplicationURL;
        set {
            EclQueryApplicationURLSpecified = true;
            _eclQueryApplicationURL = value;
        }
    }

    [XmlIgnore]
    public bool EclQueryApplicationURLSpecified { get; set; }
    private string _eclQueryDataRepositoryURL;

    [XmlElement(ElementName = "eclQueryDataRepositoryURL", IsNullable = true, Namespace = "")]
    public string EclQueryDataRepositoryURL {
        get => _eclQueryDataRepositoryURL;
        set {
            EclQueryDataRepositoryURLSpecified = true;
            _eclQueryDataRepositoryURL = value;
        }
    }

    [XmlIgnore]
    public bool EclQueryDataRepositoryURLSpecified { get; set; }
}
}
