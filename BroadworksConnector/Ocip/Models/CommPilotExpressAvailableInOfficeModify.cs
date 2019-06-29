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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""8c204d784d1904d9eeea996d46de69be:116""}]")]
    public class CommPilotExpressAvailableInOfficeModify
    {

        private string _additionalPhoneNumberToRing;

        [XmlElement(ElementName = "additionalPhoneNumberToRing", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"8c204d784d1904d9eeea996d46de69be:116")]
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

        private BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionModify _busySetting;

        [XmlElement(ElementName = "busySetting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"8c204d784d1904d9eeea996d46de69be:116")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionModify BusySetting
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

        private BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionModify _noAnswerSetting;

        [XmlElement(ElementName = "noAnswerSetting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"8c204d784d1904d9eeea996d46de69be:116")]
        public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionModify NoAnswerSetting
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
