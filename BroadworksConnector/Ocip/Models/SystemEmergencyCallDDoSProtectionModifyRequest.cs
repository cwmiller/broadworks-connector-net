using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the Emergency Call DDos Protection settings.
    /// The response is either SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8647""}]")]
    public class SystemEmergencyCallDDoSProtectionModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8647")]
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
        public bool EnabledSpecified { get; set; }

        private int _sampleIntervalSeconds;

        [XmlElement(ElementName = "sampleIntervalSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8647")]
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
        public bool SampleIntervalSecondsSpecified { get; set; }

        private int? _protectionRate;

        [XmlElement(ElementName = "protectionRate", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8647")]
        [MinInclusive(1)]
        [MaxInclusive(10000)]
        public int? ProtectionRate
        {
            get => _protectionRate;
            set
            {
                ProtectionRateSpecified = true;
                _protectionRate = value;
            }
        }

        [XmlIgnore]
        public bool ProtectionRateSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ProtectionAction _protectionAction;

        [XmlElement(ElementName = "protectionAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8647")]
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
        public bool ProtectionActionSpecified { get; set; }

    }
}
