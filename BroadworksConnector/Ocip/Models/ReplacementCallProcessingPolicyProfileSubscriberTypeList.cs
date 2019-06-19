using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of CallProcessingPolicyProfileSubscriberType. The list replaces a previously configured list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:44763""}]")]
    public class ReplacementCallProcessingPolicyProfileSubscriberTypeList
    {

        private List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType> _subscriberType = new List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType>();

        [XmlElement(ElementName = "subscriberType", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:44763")]
        public List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType> SubscriberType
        {
            get => _subscriberType;
            set
            {
                SubscriberTypeSpecified = true;
                _subscriberType = value;
            }
        }

        [XmlIgnore]
        public bool SubscriberTypeSpecified { get; set; }

    }
}
