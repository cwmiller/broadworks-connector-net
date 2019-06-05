using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPushToTalkGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _allowAutoAnswer;

    [XmlElement(ElementName = "allowAutoAnswer", IsNullable = false, Namespace = "")]
    public bool AllowAutoAnswer {
        get => _allowAutoAnswer;
        set {
            AllowAutoAnswerSpecified = true;
            _allowAutoAnswer = value;
        }
    }

    [XmlIgnore]
    public bool AllowAutoAnswerSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.PushToTalkOutgoingConnectionSelection _outgoingConnectionSelection;

    [XmlElement(ElementName = "outgoingConnectionSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.PushToTalkOutgoingConnectionSelection OutgoingConnectionSelection {
        get => _outgoingConnectionSelection;
        set {
            OutgoingConnectionSelectionSpecified = true;
            _outgoingConnectionSelection = value;
        }
    }

    [XmlIgnore]
    public bool OutgoingConnectionSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.PushToTalkAccessListSelection _accessListSelection;

    [XmlElement(ElementName = "accessListSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.PushToTalkAccessListSelection AccessListSelection {
        get => _accessListSelection;
        set {
            AccessListSelectionSpecified = true;
            _accessListSelection = value;
        }
    }

    [XmlIgnore]
    public bool AccessListSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.C.OCITable _selectedUserTable;

    [XmlElement(ElementName = "selectedUserTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable SelectedUserTable {
        get => _selectedUserTable;
        set {
            SelectedUserTableSpecified = true;
            _selectedUserTable = value;
        }
    }

    [XmlIgnore]
    public bool SelectedUserTableSpecified { get; set; }
}
}
