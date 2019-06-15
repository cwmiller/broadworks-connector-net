using System;
using System.Xml.Serialization;
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
     
    public class SystemAdviceOfChargeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private int _delayBetweenNotificationSeconds;

        [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false, Namespace = "")]
        public int DelayBetweenNotificationSeconds {
            get => _delayBetweenNotificationSeconds;
            set {
                DelayBetweenNotificationSecondsSpecified = true;
                _delayBetweenNotificationSeconds = value;
            }
        }

        [XmlIgnore]
        public bool DelayBetweenNotificationSecondsSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.AdviceOfChargeIncomingAocHandling _incomingAocHandling;

        [XmlElement(ElementName = "incomingAocHandling", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.AdviceOfChargeIncomingAocHandling IncomingAocHandling {
            get => _incomingAocHandling;
            set {
                IncomingAocHandlingSpecified = true;
                _incomingAocHandling = value;
            }
        }

        [XmlIgnore]
        public bool IncomingAocHandlingSpecified { get; set; }
        
        private string _costInformationSource;

        [XmlElement(ElementName = "costInformationSource", IsNullable = true, Namespace = "")]
        public string CostInformationSource {
            get => _costInformationSource;
            set {
                CostInformationSourceSpecified = true;
                _costInformationSource = value;
            }
        }

        [XmlIgnore]
        public bool CostInformationSourceSpecified { get; set; }
        
    }
}
