using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldUserSourceRead 
{
    private BroadWorksConnector.Ocip.Models.MusicOnHoldUserMessageSelection _messageSourceSelection;

    [XmlElement(ElementName = "messageSourceSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.MusicOnHoldUserMessageSelection MessageSourceSelection {
        get => _messageSourceSelection;
        set {
            MessageSourceSelectionSpecified = true;
            _messageSourceSelection = value;
        }
    }

    [XmlIgnore]
    public bool MessageSourceSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceReadCustomSource _customSource;

    [XmlElement(ElementName = "customSource", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.MusicOnHoldUserSourceReadCustomSource CustomSource {
        get => _customSource;
        set {
            CustomSourceSpecified = true;
            _customSource = value;
        }
    }

    [XmlIgnore]
    public bool CustomSourceSpecified { get; set; }
}
}
