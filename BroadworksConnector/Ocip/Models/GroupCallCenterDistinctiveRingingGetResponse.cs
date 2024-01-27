using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterDistinctiveRingingGetRequest.
    /// 
    /// The following element is only used in AS data mode and not returned in XS data mode:
    /// distinctiveRingingForceDeliveryRingPattern
    /// <see cref="GroupCallCenterDistinctiveRingingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:3237""}]")]
    public class GroupCallCenterDistinctiveRingingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _distinctiveRingingCallCenterCalls;

        [XmlElement(ElementName = "distinctiveRingingCallCenterCalls", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:3237")]
        public bool DistinctiveRingingCallCenterCalls
        {
            get => _distinctiveRingingCallCenterCalls;
            set
            {
                DistinctiveRingingCallCenterCallsSpecified = true;
                _distinctiveRingingCallCenterCalls = value;
            }
        }

        [XmlIgnore]
        protected bool DistinctiveRingingCallCenterCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.RingPattern _distinctiveRingingRingPatternForCallCenter;

        [XmlElement(ElementName = "distinctiveRingingRingPatternForCallCenter", IsNullable = false, Namespace = "")]
        [Group(@"4d65d3449061c568639c8cc1e2492285:3237")]
        public BroadWorksConnector.Ocip.Models.RingPattern DistinctiveRingingRingPatternForCallCenter
        {
            get => _distinctiveRingingRingPatternForCallCenter;
            set
            {
                DistinctiveRingingRingPatternForCallCenterSpecified = true;
                _distinctiveRingingRingPatternForCallCenter = value;
            }
        }

        [XmlIgnore]
        protected bool DistinctiveRingingRingPatternForCallCenterSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.RingPattern _distinctiveRingingForceDeliveryRingPattern;

        [XmlElement(ElementName = "distinctiveRingingForceDeliveryRingPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:3237")]
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
