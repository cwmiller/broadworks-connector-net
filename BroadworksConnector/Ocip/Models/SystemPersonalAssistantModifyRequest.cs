using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify system Personal Assistant Parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6bd221784ebf8af2fe1169d36a6ac2dd:86""}]")]
    public class SystemPersonalAssistantModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _transferToAttendantKey;

        [XmlElement(ElementName = "transferToAttendantKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:86")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string TransferToAttendantKey
        {
            get => _transferToAttendantKey;
            set
            {
                TransferToAttendantKeySpecified = true;
                _transferToAttendantKey = value;
            }
        }

        [XmlIgnore]
        protected bool TransferToAttendantKeySpecified { get; set; }

        protected string _transferToVoiceMessagingKey;

        [XmlElement(ElementName = "transferToVoiceMessagingKey", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6bd221784ebf8af2fe1169d36a6ac2dd:86")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string TransferToVoiceMessagingKey
        {
            get => _transferToVoiceMessagingKey;
            set
            {
                TransferToVoiceMessagingKeySpecified = true;
                _transferToVoiceMessagingKey = value;
            }
        }

        [XmlIgnore]
        protected bool TransferToVoiceMessagingKeySpecified { get; set; }

    }
}
