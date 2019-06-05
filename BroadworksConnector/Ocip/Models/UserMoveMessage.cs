using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMoveMessage 
{
    private int _messageCode;

    [XmlElement(ElementName = "messageCode", IsNullable = false, Namespace = "")]
    public int MessageCode {
        get => _messageCode;
        set {
            MessageCodeSpecified = true;
            _messageCode = value;
        }
    }

    [XmlIgnore]
    public bool MessageCodeSpecified { get; set; }
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
}
}
