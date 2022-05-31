using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterStrandedCallUnavailableGetRequest20.
    /// <see cref="GroupCallCenterStrandedCallUnavailableGetRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:5871""}]")]
    public class GroupCallCenterStrandedCallUnavailableGetResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _conditionPolicyOnNumberOfAgentsWithSpecifiedUnavailableCode;

        [XmlElement(ElementName = "conditionPolicyOnNumberOfAgentsWithSpecifiedUnavailableCode", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5871")]
        public bool ConditionPolicyOnNumberOfAgentsWithSpecifiedUnavailableCode
        {
            get => _conditionPolicyOnNumberOfAgentsWithSpecifiedUnavailableCode;
            set
            {
                ConditionPolicyOnNumberOfAgentsWithSpecifiedUnavailableCodeSpecified = true;
                _conditionPolicyOnNumberOfAgentsWithSpecifiedUnavailableCode = value;
            }
        }

        [XmlIgnore]
        protected bool ConditionPolicyOnNumberOfAgentsWithSpecifiedUnavailableCodeSpecified { get; set; }

        protected int _numberOfAgentsWithSpecifiedUnavailableCode;

        [XmlElement(ElementName = "numberOfAgentsWithSpecifiedUnavailableCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5871")]
        [MinInclusive(1)]
        [MaxInclusive(1000)]
        public int NumberOfAgentsWithSpecifiedUnavailableCode
        {
            get => _numberOfAgentsWithSpecifiedUnavailableCode;
            set
            {
                NumberOfAgentsWithSpecifiedUnavailableCodeSpecified = true;
                _numberOfAgentsWithSpecifiedUnavailableCode = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfAgentsWithSpecifiedUnavailableCodeSpecified { get; set; }

        protected string _agentsUnavailableCode;

        [XmlElement(ElementName = "agentsUnavailableCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5871")]
        [MinLength(1)]
        [MaxLength(10)]
        public string AgentsUnavailableCode
        {
            get => _agentsUnavailableCode;
            set
            {
                AgentsUnavailableCodeSpecified = true;
                _agentsUnavailableCode = value;
            }
        }

        [XmlIgnore]
        protected bool AgentsUnavailableCodeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterStrandedCallUnavailableProcessingAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5871")]
        public BroadWorksConnector.Ocip.Models.CallCenterStrandedCallUnavailableProcessingAction Action
        {
            get => _action;
            set
            {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        protected bool ActionSpecified { get; set; }

        protected string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5871")]
        [MinLength(1)]
        [MaxLength(161)]
        public string TransferPhoneNumber
        {
            get => _transferPhoneNumber;
            set
            {
                TransferPhoneNumberSpecified = true;
                _transferPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool TransferPhoneNumberSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioMessageSelection;

        [XmlElement(ElementName = "audioMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5871")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection AudioMessageSelection
        {
            get => _audioMessageSelection;
            set
            {
                AudioMessageSelectionSpecified = true;
                _audioMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool AudioMessageSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _audioUrlList;

        [XmlElement(ElementName = "audioUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5871")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList AudioUrlList
        {
            get => _audioUrlList;
            set
            {
                AudioUrlListSpecified = true;
                _audioUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool AudioUrlListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _audioFileList;

        [XmlElement(ElementName = "audioFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5871")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 AudioFileList
        {
            get => _audioFileList;
            set
            {
                AudioFileListSpecified = true;
                _audioFileList = value;
            }
        }

        [XmlIgnore]
        protected bool AudioFileListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoMessageSelection;

        [XmlElement(ElementName = "videoMessageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5871")]
        public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection VideoMessageSelection
        {
            get => _videoMessageSelection;
            set
            {
                VideoMessageSelectionSpecified = true;
                _videoMessageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool VideoMessageSelectionSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _videoUrlList;

        [XmlElement(ElementName = "videoUrlList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5871")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList VideoUrlList
        {
            get => _videoUrlList;
            set
            {
                VideoUrlListSpecified = true;
                _videoUrlList = value;
            }
        }

        [XmlIgnore]
        protected bool VideoUrlListSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _videoFileList;

        [XmlElement(ElementName = "videoFileList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:5871")]
        public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 VideoFileList
        {
            get => _videoFileList;
            set
            {
                VideoFileListSpecified = true;
                _videoFileList = value;
            }
        }

        [XmlIgnore]
        protected bool VideoFileListSpecified { get; set; }

    }
}
