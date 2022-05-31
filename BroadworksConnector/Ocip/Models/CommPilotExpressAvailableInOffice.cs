using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// CommPilot Express Available In Office Settings.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8c204d784d1904d9eeea996d46de69be:103""}]")]
    public class CommPilotExpressAvailableInOffice
    {

        protected string _additionalPhoneNumberToRing;

        [XmlElement(ElementName = "additionalPhoneNumberToRing", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"8c204d784d1904d9eeea996d46de69be:103")]
        [MinLength(1)]
        [MaxLength(161)]
        public string AdditionalPhoneNumberToRing
        {
            get => _additionalPhoneNumberToRing;
            set
            {
                AdditionalPhoneNumberToRingSpecified = true;
                _additionalPhoneNumberToRing = value;
            }
        }

        [XmlIgnore]
        protected bool AdditionalPhoneNumberToRingSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressRedirection _busySetting;

        [XmlElement(ElementName = "busySetting", IsNullable = false, Namespace = "")]
        [Group(@"8c204d784d1904d9eeea996d46de69be:103")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirection BusySetting
        {
            get => _busySetting;
            set
            {
                BusySettingSpecified = true;
                _busySetting = value;
            }
        }

        [XmlIgnore]
        protected bool BusySettingSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CommPilotExpressRedirection _noAnswerSetting;

        [XmlElement(ElementName = "noAnswerSetting", IsNullable = false, Namespace = "")]
        [Group(@"8c204d784d1904d9eeea996d46de69be:103")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirection NoAnswerSetting
        {
            get => _noAnswerSetting;
            set
            {
                NoAnswerSettingSpecified = true;
                _noAnswerSetting = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerSettingSpecified { get; set; }

    }
}
