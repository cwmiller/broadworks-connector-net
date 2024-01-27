using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of CallProcessingPolicyProfileSubscriberType21. The list replaces a previously configured list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4203""}]")]
    public class ReplacementCallProcessingPolicyProfileSubscriberTypeList21
    {

        protected List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType21> _subscriberType = new List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType21>();

        [XmlElement(ElementName = "subscriberType", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4203")]
        public List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType21> SubscriberType
        {
            get => _subscriberType;
            set
            {
                SubscriberTypeSpecified = true;
                _subscriberType = value;
            }
        }

        [XmlIgnore]
        protected bool SubscriberTypeSpecified { get; set; }

    }
}
