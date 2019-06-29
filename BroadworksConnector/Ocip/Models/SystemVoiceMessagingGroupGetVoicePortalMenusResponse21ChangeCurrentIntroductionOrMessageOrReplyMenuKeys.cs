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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1045""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21ChangeCurrentIntroductionOrMessageOrReplyMenuKeys
    {

        private string _endRecording;

        [XmlElement(ElementName = "endRecording", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1045")]
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
