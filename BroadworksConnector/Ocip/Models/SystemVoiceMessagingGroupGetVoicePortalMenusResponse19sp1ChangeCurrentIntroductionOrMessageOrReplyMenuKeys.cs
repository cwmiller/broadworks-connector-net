using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:38172""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19sp1ChangeCurrentIntroductionOrMessageOrReplyMenuKeys
    {

        private string _endRecording;

        [XmlElement(ElementName = "endRecording", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:38172")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string EndRecording
        {
            get => _endRecording;
            set
            {
                EndRecordingSpecified = true;
                _endRecording = value;
            }
        }

        [XmlIgnore]
        protected bool EndRecordingSpecified { get; set; }

    }
}
