using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify Advice of Charge system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// Replaced by: SystemAdviceOfChargeModifyRequest19sp1
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemAdviceOfChargeModifyRequest19sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:34141""}]")]
    public class SystemAdviceOfChargeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _delayBetweenNotificationSeconds;

        [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34141")]
        [MinInclusive(5)]
        [MaxInclusive(1800)]
        public int DelayBetweenNotificationSeconds
        {
            get => _delayBetweenNotificationSeconds;
            set
            {
                DelayBetweenNotificationSecondsSpecified = true;
                _delayBetweenNotificationSeconds = value;
            }
        }

        [XmlIgnore]
        public bool DelayBetweenNotificationSecondsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AdviceOfChargeIncomingAocHandling _incomingAocHandling;

        [XmlElement(ElementName = "incomingAocHandling", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34141")]
        public BroadWorksConnector.Ocip.Models.AdviceOfChargeIncomingAocHandling IncomingAocHandling
        {
            get => _incomingAocHandling;
            set
            {
                IncomingAocHandlingSpecified = true;
                _incomingAocHandling = value;
            }
        }

        [XmlIgnore]
        public bool IncomingAocHandlingSpecified { get; set; }

        private string _costInformationSource;

        [XmlElement(ElementName = "costInformationSource", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:34141")]
        [MinLength(1)]
        [MaxLength(80)]
        public string CostInformationSource
        {
            get => _costInformationSource;
            set
            {
                CostInformationSourceSpecified = true;
                _costInformationSource = value;
            }
        }

        [XmlIgnore]
        public bool CostInformationSourceSpecified { get; set; }

    }
}
