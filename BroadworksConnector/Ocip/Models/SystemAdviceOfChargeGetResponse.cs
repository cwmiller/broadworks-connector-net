using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAdviceOfChargeGetRequest.
    /// Contains a list of system Advice of Charge parameters.
    /// 
    /// Replaced by: SystemAdviceOfChargeGetResponse19sp1
        /// <see cref="SystemAdviceOfChargeGetRequest"/>
        /// <see cref="SystemAdviceOfChargeGetResponse19sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAdviceOfChargeGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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

        [XmlElement(ElementName = "costInformationSource", IsNullable = false, Namespace = "")]
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
