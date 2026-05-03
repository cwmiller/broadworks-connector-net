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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9849""}]")]
    public class SystemEmergencyCallDDoSProtectionModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool? _enabled;

        [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9849")]
        public bool? Enabled
        {
            get => _enabled;
            set
            {
                EnabledSpecified = (value != null);
                _enabled = value;
            }
        }

        [XmlIgnore]
        protected bool EnabledSpecified { get; set; }

        protected int? _sampleIntervalSeconds;

        [XmlElement(ElementName = "sampleIntervalSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9849")]
        [MinInclusive(1)]
        [MaxInclusive(30)]
        public int? SampleIntervalSeconds
        {
            get => _sampleIntervalSeconds;
            set
            {
                SampleIntervalSecondsSpecified = (value != null);
                _sampleIntervalSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool SampleIntervalSecondsSpecified { get; set; }

        protected int? _protectionRate;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "protectionRate", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9849")]
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
        protected bool ProtectionRateSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ProtectionAction? _protectionAction;

        [XmlElement(ElementName = "protectionAction", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:9849")]
        public BroadWorksConnector.Ocip.Models.ProtectionAction? ProtectionAction
        {
            get => _protectionAction;
            set
            {
                ProtectionActionSpecified = (value != null);
                _protectionAction = value;
            }
        }

        [XmlIgnore]
        protected bool ProtectionActionSpecified { get; set; }

    }
}
