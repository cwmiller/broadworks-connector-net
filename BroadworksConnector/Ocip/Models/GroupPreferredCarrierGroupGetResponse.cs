using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a GroupPreferredCarrierGroupGetRequest.
        /// <see cref="GroupPreferredCarrierGroupGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupPreferredCarrierGroupGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.GroupPreferredCarrierName _intraLataCarrier;

        [XmlElement(ElementName = "intraLataCarrier", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupPreferredCarrierName IntraLataCarrier {
            get => _intraLataCarrier;
            set {
                IntraLataCarrierSpecified = true;
                _intraLataCarrier = value;
            }
        }

        [XmlIgnore]
        public bool IntraLataCarrierSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GroupPreferredCarrierName _interLataCarrier;

        [XmlElement(ElementName = "interLataCarrier", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupPreferredCarrierName InterLataCarrier {
            get => _interLataCarrier;
            set {
                InterLataCarrierSpecified = true;
                _interLataCarrier = value;
            }
        }

        [XmlIgnore]
        public bool InterLataCarrierSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GroupPreferredCarrierName _internationalCarrier;

        [XmlElement(ElementName = "internationalCarrier", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupPreferredCarrierName InternationalCarrier {
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
