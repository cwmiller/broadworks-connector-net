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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:20506""}]")]
    public class SystemAdviceOfChargeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _delayBetweenNotificationSeconds;

        [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:20506")]
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
        protected bool DelayBetweenNotificationSecondsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AdviceOfChargeIncomingAocHandling _incomingAocHandling;

        [XmlElement(ElementName = "incomingAocHandling", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:20506")]
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
        protected bool IncomingAocHandlingSpecified { get; set; }

        protected string _costInformationSource;

        [XmlElement(ElementName = "costInformationSource", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:20506")]
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
        protected bool CostInformationSourceSpecified { get; set; }

    }
}
