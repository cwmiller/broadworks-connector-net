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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3099""}]")]
    public class ReplacementCallProcessingPolicyProfileSubscriberTypeList21
    {

        private List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType21> _subscriberType = new List<BroadWorksConnector.Ocip.Models.CallProcessingPolicyProfileSubscriberType21>();

        [XmlElement(ElementName = "subscriberType", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3099")]
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
