using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupRoutePointDistinctiveRingingGetRequest.
    /// <see cref="GroupRoutePointDistinctiveRingingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a27224a048c30ff69eab9209dec841cc:248""}]")]
    public class GroupRoutePointDistinctiveRingingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableDistinctiveRinging;

        [XmlElement(ElementName = "enableDistinctiveRinging", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:248")]
        public bool EnableDistinctiveRinging
        {
            get => _enableDistinctiveRinging;
            set
            {
                EnableDistinctiveRingingSpecified = true;
                _enableDistinctiveRinging = value;
            }
        }

        [XmlIgnore]
        protected bool EnableDistinctiveRingingSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.RingPattern _distinctiveRingingRingPattern;

        [XmlElement(ElementName = "distinctiveRingingRingPattern", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:248")]
        public BroadWorksConnector.Ocip.Models.RingPattern DistinctiveRingingRingPattern
        {
            get => _distinctiveRingingRingPattern;
            set
            {
                DistinctiveRingingRingPatternSpecified = true;
                _distinctiveRingingRingPattern = value;
            }
        }

        [XmlIgnore]
        protected bool DistinctiveRingingRingPatternSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.RingPattern _distinctiveRingingForceDeliveryRingPattern;

        [XmlElement(ElementName = "distinctiveRingingForceDeliveryRingPattern", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:248")]
        public BroadWorksConnector.Ocip.Models.RingPattern DistinctiveRingingForceDeliveryRingPattern
        {
            get => _distinctiveRingingForceDeliveryRingPattern;
            set
            {
                DistinctiveRingingForceDeliveryRingPatternSpecified = true;
                _distinctiveRingingForceDeliveryRingPattern = value;
            }
        }

        [XmlIgnore]
        protected bool DistinctiveRingingForceDeliveryRingPatternSpecified { get; set; }

    }
}
