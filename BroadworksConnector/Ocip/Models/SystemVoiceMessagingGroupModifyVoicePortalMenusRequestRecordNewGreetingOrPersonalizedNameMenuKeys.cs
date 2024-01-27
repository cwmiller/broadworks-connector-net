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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:39577""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestRecordNewGreetingOrPersonalizedNameMenuKeys
    {

        protected string _endRecording;

        [XmlElement(ElementName = "endRecording", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39577")]
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
