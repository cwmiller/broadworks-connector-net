using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Call me now service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""adf9583170c1dc9ec6c152ba1238437a:77""}]")]
    public class SystemCallMeNowModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _passcodeLength;

        [XmlElement(ElementName = "passcodeLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf9583170c1dc9ec6c152ba1238437a:77")]
        [MinInclusive(2)]
        [MaxInclusive(30)]
        public int PasscodeLength
        {
            get => _passcodeLength;
            set
            {
                PasscodeLengthSpecified = true;
                _passcodeLength = value;
            }
        }

        [XmlIgnore]
        protected bool PasscodeLengthSpecified { get; set; }

        protected int _passcodeTimeoutSeconds;

        [XmlElement(ElementName = "passcodeTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"adf9583170c1dc9ec6c152ba1238437a:77")]
        [MinInclusive(30)]
        [MaxInclusive(180)]
        public int PasscodeTimeoutSeconds
        {
            get => _passcodeTimeoutSeconds;
            set
            {
                PasscodeTimeoutSecondsSpecified = true;
                _passcodeTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool PasscodeTimeoutSecondsSpecified { get; set; }

    }
}
