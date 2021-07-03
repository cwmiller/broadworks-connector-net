using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupCallCenterGetDistinctiveRingingRequest.
    /// <see cref="GroupCallCenterGetDistinctiveRingingRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:4294""}]")]
    public class GroupCallCenterGetDistinctiveRingingResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _distinctiveRingingCallCenterCalls;

        [XmlElement(ElementName = "distinctiveRingingCallCenterCalls", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4294")]
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

        private BroadWorksConnector.Ocip.Models.RingPattern _distinctiveRingingRingPatternForCallCenter;

        [XmlElement(ElementName = "distinctiveRingingRingPatternForCallCenter", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4294")]
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

        private BroadWorksConnector.Ocip.Models.RingPattern _distinctiveRingingForceDeliveryRingPattern;

        [XmlElement(ElementName = "distinctiveRingingForceDeliveryRingPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:4294")]
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
