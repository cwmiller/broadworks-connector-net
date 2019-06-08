using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
[Serializable]
[XmlRoot(Namespace = "C")]
public  class ErrorResponse : BroadWorksConnector.Ocip.Models.C.OCIResponse
{
    private int _errorCode;

    [XmlElement(ElementName = "errorCode", IsNullable = false, Namespace = "")]
    public int ErrorCode {
        get => _errorCode;
        set {
            ErrorCodeSpecified = true;
            _errorCode = value;
        }
    }

    [XmlIgnore]
    public bool ErrorCodeSpecified { get; set; }
    private string _summary;

    [XmlElement(ElementName = "summary", IsNullable = false, Namespace = "")]
    public string Summary {
        get => _summary;
        set {
            SummarySpecified = true;
            _summary = value;
        }
    }

    [XmlIgnore]
    public bool SummarySpecified { get; set; }
    private string _summaryEnglish;

    [XmlElement(ElementName = "summaryEnglish", IsNullable = false, Namespace = "")]
    public string SummaryEnglish {
        get => _summaryEnglish;
        set {
            SummaryEnglishSpecified = true;
            _summaryEnglish = value;
        }
    }

    [XmlIgnore]
    public bool SummaryEnglishSpecified { get; set; }
    private string _detail;

    [XmlElement(ElementName = "detail", IsNullable = false, Namespace = "")]
    public string Detail {
        get => _detail;
        set {
            DetailSpecified = true;
            _detail = value;
        }
    }

    [XmlIgnore]
    public bool DetailSpecified { get; set; }
}
}
