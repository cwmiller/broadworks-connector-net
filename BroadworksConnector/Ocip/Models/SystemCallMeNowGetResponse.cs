using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallMeNowGetRequest.
    /// <see cref="SystemCallMeNowGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1f0f230fee2817fe00157925859dc28e:60""}]")]
    public class SystemCallMeNowGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _passcodeLength;

        [XmlElement(ElementName = "passcodeLength", IsNullable = false, Namespace = "")]
        [Group(@"1f0f230fee2817fe00157925859dc28e:60")]
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

        private int _passcodeTimeoutSeconds;

        [XmlElement(ElementName = "passcodeTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"1f0f230fee2817fe00157925859dc28e:60")]
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
