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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e474d11df9a1d1d1041e589793e40de8:254""}]")]
    public class GroupRoutePointDistinctiveRingingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableDistinctiveRinging;

        [XmlElement(ElementName = "enableDistinctiveRinging", IsNullable = false, Namespace = "")]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:254")]
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

        protected BroadWorksConnector.Ocip.Models.RingPattern _distinctiveRingingRingPattern;

        [XmlElement(ElementName = "distinctiveRingingRingPattern", IsNullable = false, Namespace = "")]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:254")]
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

        protected BroadWorksConnector.Ocip.Models.RingPattern _distinctiveRingingForceDeliveryRingPattern;

        [XmlElement(ElementName = "distinctiveRingingForceDeliveryRingPattern", IsNullable = false, Namespace = "")]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:254")]
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
