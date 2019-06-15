using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a UserPreferredCarrierUserGetRequest.
        /// <see cref="UserPreferredCarrierUserGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserPreferredCarrierUserGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.UserPreferredCarrierName _intraLataCarrier;

        [XmlElement(ElementName = "intraLataCarrier", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UserPreferredCarrierName IntraLataCarrier {
            get => _intraLataCarrier;
            set {
                IntraLataCarrierSpecified = true;
                _intraLataCarrier = value;
            }
        }

        [XmlIgnore]
        public bool IntraLataCarrierSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.UserPreferredCarrierName _interLataCarrier;

        [XmlElement(ElementName = "interLataCarrier", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UserPreferredCarrierName InterLataCarrier {
            get => _interLataCarrier;
            set {
                InterLataCarrierSpecified = true;
                _interLataCarrier = value;
            }
        }

        [XmlIgnore]
        public bool InterLataCarrierSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.UserPreferredCarrierName _internationalCarrier;

        [XmlElement(ElementName = "internationalCarrier", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.UserPreferredCarrierName InternationalCarrier {
            get => _internationalCarrier;
            set {
                InternationalCarrierSpecified = true;
                _internationalCarrier = value;
            }
        }

        [XmlIgnore]
        public bool InternationalCarrierSpecified { get; set; }
        
    }
}
