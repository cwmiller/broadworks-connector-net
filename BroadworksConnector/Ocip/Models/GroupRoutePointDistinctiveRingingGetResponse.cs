using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupRoutePointDistinctiveRingingGetRequest.
        /// <see cref="GroupRoutePointDistinctiveRingingGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupRoutePointDistinctiveRingingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private bool _enableDistinctiveRinging;

        [XmlElement(ElementName = "enableDistinctiveRinging", IsNullable = false, Namespace = "")]
        public bool EnableDistinctiveRinging {
            get => _enableDistinctiveRinging;
            set {
                EnableDistinctiveRingingSpecified = true;
                _enableDistinctiveRinging = value;
            }
        }

        [XmlIgnore]
        public bool EnableDistinctiveRingingSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.RingPattern _distinctiveRingingRingPattern;

        [XmlElement(ElementName = "distinctiveRingingRingPattern", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.RingPattern DistinctiveRingingRingPattern {
            get => _distinctiveRingingRingPattern;
            set {
                DistinctiveRingingRingPatternSpecified = true;
                _distinctiveRingingRingPattern = value;
            }
        }

        [XmlIgnore]
        public bool DistinctiveRingingRingPatternSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.RingPattern _distinctiveRingingForceDeliveryRingPattern;

        [XmlElement(ElementName = "distinctiveRingingForceDeliveryRingPattern", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.RingPattern DistinctiveRingingForceDeliveryRingPattern {
            get => _distinctiveRingingForceDeliveryRingPattern;
            set {
                DistinctiveRingingForceDeliveryRingPatternSpecified = true;
                _distinctiveRingingForceDeliveryRingPattern = value;
            }
        }

        [XmlIgnore]
        public bool DistinctiveRingingForceDeliveryRingPatternSpecified { get; set; }
        
    }
}
