using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CommPilotExpressAvailableInOffice
    {
        private string _additionalPhoneNumberToRing;

        [XmlElement(ElementName = "additionalPhoneNumberToRing", IsNullable = false, Namespace = "")]
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
        public bool AdditionalPhoneNumberToRingSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CommPilotExpressRedirection _busySetting;

        [XmlElement(ElementName = "busySetting", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CommPilotExpressRedirection BusySetting
        {
            get => _busySetting;
            set
            {
                BusySettingSpecified = true;
                _busySetting = value;
            }
        }

        [XmlIgnore]
        public bool BusySettingSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.CommPilotExpressRedirection _noAnswerSetting;

        [XmlElement(ElementName = "noAnswerSetting", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CommPilotExpressRedirection NoAnswerSetting
        {
            get => _noAnswerSetting;
            set
            {
                NoAnswerSettingSpecified = true;
                _noAnswerSetting = value;
            }
        }

        [XmlIgnore]
        public bool NoAnswerSettingSpecified { get; set; }
    }
}
