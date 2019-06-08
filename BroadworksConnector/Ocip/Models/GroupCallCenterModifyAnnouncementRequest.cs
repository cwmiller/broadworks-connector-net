using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyAnnouncementRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _entranceMessageSelection;

    [XmlElement(ElementName = "entranceMessageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection EntranceMessageSelection {
        get => _entranceMessageSelection;
        set {
            EntranceMessageSelectionSpecified = true;
            _entranceMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool EntranceMessageSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.LabeledFileResource _entranceMessageAudioFile;

    [XmlElement(ElementName = "entranceMessageAudioFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LabeledFileResource EntranceMessageAudioFile {
        get => _entranceMessageAudioFile;
        set {
            EntranceMessageAudioFileSpecified = true;
            _entranceMessageAudioFile = value;
        }
    }

    [XmlIgnore]
    public bool EntranceMessageAudioFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.LabeledFileResource _entranceMessageVideoFile;

    [XmlElement(ElementName = "entranceMessageVideoFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LabeledFileResource EntranceMessageVideoFile {
        get => _entranceMessageVideoFile;
        set {
            EntranceMessageVideoFileSpecified = true;
            _entranceMessageVideoFile = value;
        }
    }

    [XmlIgnore]
    public bool EntranceMessageVideoFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _periodicComfortMessageSelection;

    [XmlElement(ElementName = "periodicComfortMessageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection PeriodicComfortMessageSelection {
        get => _periodicComfortMessageSelection;
        set {
            PeriodicComfortMessageSelectionSpecified = true;
            _periodicComfortMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool PeriodicComfortMessageSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.LabeledFileResource _periodicComfortMessageAudioFile;

    [XmlElement(ElementName = "periodicComfortMessageAudioFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LabeledFileResource PeriodicComfortMessageAudioFile {
        get => _periodicComfortMessageAudioFile;
        set {
            PeriodicComfortMessageAudioFileSpecified = true;
            _periodicComfortMessageAudioFile = value;
        }
    }

    [XmlIgnore]
    public bool PeriodicComfortMessageAudioFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.LabeledFileResource _periodicComfortMessageVideoFile;

    [XmlElement(ElementName = "periodicComfortMessageVideoFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LabeledFileResource PeriodicComfortMessageVideoFile {
        get => _periodicComfortMessageVideoFile;
        set {
            PeriodicComfortMessageVideoFileSpecified = true;
            _periodicComfortMessageVideoFile = value;
        }
    }

    [XmlIgnore]
    public bool PeriodicComfortMessageVideoFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection _onHoldMessageSelection;

    [XmlElement(ElementName = "onHoldMessageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementSelection OnHoldMessageSelection {
        get => _onHoldMessageSelection;
        set {
            OnHoldMessageSelectionSpecified = true;
            _onHoldMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool OnHoldMessageSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.LabeledFileResource _onHoldMessageAudioFile;

    [XmlElement(ElementName = "onHoldMessageAudioFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LabeledFileResource OnHoldMessageAudioFile {
        get => _onHoldMessageAudioFile;
        set {
            OnHoldMessageAudioFileSpecified = true;
            _onHoldMessageAudioFile = value;
        }
    }

    [XmlIgnore]
    public bool OnHoldMessageAudioFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.LabeledFileResource _onHoldMessageVideoFile;

    [XmlElement(ElementName = "onHoldMessageVideoFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LabeledFileResource OnHoldMessageVideoFile {
        get => _onHoldMessageVideoFile;
        set {
            OnHoldMessageVideoFileSpecified = true;
            _onHoldMessageVideoFile = value;
        }
    }

    [XmlIgnore]
    public bool OnHoldMessageVideoFileSpecified { get; set; }
}
}
