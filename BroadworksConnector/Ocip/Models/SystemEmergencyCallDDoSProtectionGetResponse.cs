using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemEmergencyCallDDoSProtectionGetRequest.
    /// <see cref="SystemEmergencyCallDDoSProtectionGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:9657""}]")]
    public class SystemEmergencyCallDDoSProtectionGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9657")]
        public bool Enabled
        {
            get => _enabled;
            set
            {
                EnabledSpecified = true;
                _enabled = value;
            }
        }

        [XmlIgnore]
        protected bool EnabledSpecified { get; set; }

        protected int _sampleIntervalSeconds;

        [XmlElement(ElementName = "sampleIntervalSeconds", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9657")]
        [MinInclusive(1)]
        [MaxInclusive(30)]
        public int SampleIntervalSeconds
        {
            get => _sampleIntervalSeconds;
            set
            {
                SampleIntervalSecondsSpecified = true;
                _sampleIntervalSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool SampleIntervalSecondsSpecified { get; set; }

        protected int _protectionRate;

        [XmlElement(ElementName = "protectionRate", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9657")]
        [MinInclusive(1)]
        [MaxInclusive(10000)]
        public int ProtectionRate
        {
            get => _protectionRate;
            set
            {
                ProtectionRateSpecified = true;
                _protectionRate = value;
            }
        }

        [XmlIgnore]
        protected bool ProtectionRateSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ProtectionAction _protectionAction;

        [XmlElement(ElementName = "protectionAction", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:9657")]
        public BroadWorksConnector.Ocip.Models.ProtectionAction ProtectionAction
        {
            get => _protectionAction;
            set
            {
                ProtectionActionSpecified = true;
                _protectionAction = value;
            }
        }

        [XmlIgnore]
        protected bool ProtectionActionSpecified { get; set; }

    }
}
