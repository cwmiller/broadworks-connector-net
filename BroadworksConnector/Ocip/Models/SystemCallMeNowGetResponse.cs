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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""adf9583170c1dc9ec6c152ba1238437a:60""}]")]
    public class SystemCallMeNowGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _passcodeLength;

        [XmlElement(ElementName = "passcodeLength", IsNullable = false, Namespace = "")]
        [Group(@"adf9583170c1dc9ec6c152ba1238437a:60")]
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
        [Group(@"adf9583170c1dc9ec6c152ba1238437a:60")]
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
