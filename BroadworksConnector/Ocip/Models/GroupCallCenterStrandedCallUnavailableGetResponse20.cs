using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterStrandedCallUnavailableGetResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _conditionPolicyOnNumberOfAgentsWithSpecifiedUnavailableCode;

    [XmlElement(ElementName = "conditionPolicyOnNumberOfAgentsWithSpecifiedUnavailableCode", IsNullable = false, Namespace = "")]
    public bool ConditionPolicyOnNumberOfAgentsWithSpecifiedUnavailableCode {
        get => _conditionPolicyOnNumberOfAgentsWithSpecifiedUnavailableCode;
        set {
            ConditionPolicyOnNumberOfAgentsWithSpecifiedUnavailableCodeSpecified = true;
            _conditionPolicyOnNumberOfAgentsWithSpecifiedUnavailableCode = value;
        }
    }

    [XmlIgnore]
    public bool ConditionPolicyOnNumberOfAgentsWithSpecifiedUnavailableCodeSpecified { get; set; }
    private int _numberOfAgentsWithSpecifiedUnavailableCode;

    [XmlElement(ElementName = "numberOfAgentsWithSpecifiedUnavailableCode", IsNullable = false, Namespace = "")]
    public int NumberOfAgentsWithSpecifiedUnavailableCode {
        get => _numberOfAgentsWithSpecifiedUnavailableCode;
        set {
            NumberOfAgentsWithSpecifiedUnavailableCodeSpecified = true;
            _numberOfAgentsWithSpecifiedUnavailableCode = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfAgentsWithSpecifiedUnavailableCodeSpecified { get; set; }
    private string _agentsUnavailableCode;

    [XmlElement(ElementName = "agentsUnavailableCode", IsNullable = false, Namespace = "")]
    public string AgentsUnavailableCode {
        get => _agentsUnavailableCode;
        set {
            AgentsUnavailableCodeSpecified = true;
            _agentsUnavailableCode = value;
        }
    }

    [XmlIgnore]
    public bool AgentsUnavailableCodeSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterStrandedCallUnavailableProcessingAction _action;

    [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterStrandedCallUnavailableProcessingAction Action {
        get => _action;
        set {
            ActionSpecified = true;
            _action = value;
        }
    }

    [XmlIgnore]
    public bool ActionSpecified { get; set; }
    private string _transferPhoneNumber;

    [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false, Namespace = "")]
    public string TransferPhoneNumber {
        get => _transferPhoneNumber;
        set {
            TransferPhoneNumberSpecified = true;
            _transferPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool TransferPhoneNumberSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _audioMessageSelection;

    [XmlElement(ElementName = "audioMessageSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection AudioMessageSelection {
        get => _audioMessageSelection;
        set {
            AudioMessageSelectionSpecified = true;
            _audioMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool AudioMessageSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList _audioUrlList;

    [XmlElement(ElementName = "audioUrlList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList AudioUrlList {
        get => _audioUrlList;
        set {
            AudioUrlListSpecified = true;
            _audioUrlList = value;
        }
    }

    [XmlIgnore]
    public bool AudioUrlListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _audioFileList;

    [XmlElement(ElementName = "audioFileList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 AudioFileList {
        get => _audioFileList;
        set {
            AudioFileListSpecified = true;
            _audioFileList = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _videoMessageSelection;

    [XmlElement(ElementName = "videoMessageSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection VideoMessageSelection {
        get => _videoMessageSelection;
        set {
            VideoMessageSelectionSpecified = true;
            _videoMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool VideoMessageSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList _videoUrlList;

    [XmlElement(ElementName = "videoUrlList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList VideoUrlList {
        get => _videoUrlList;
        set {
            VideoUrlListSpecified = true;
            _videoUrlList = value;
        }
    }

    [XmlIgnore]
    public bool VideoUrlListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _videoFileList;

    [XmlElement(ElementName = "videoFileList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 VideoFileList {
        get => _videoFileList;
        set {
            VideoFileListSpecified = true;
            _videoFileList = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileListSpecified { get; set; }
}
}
