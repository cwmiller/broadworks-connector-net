using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemXsiPolicyProfileGetRequest.
    /// The response contains the Xsi policy profile.
    /// <see cref="SystemXsiPolicyProfileGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:19557""}]")]
    public class SystemXsiPolicyProfileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19557")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        private int _maxTargetSubscription;

        [XmlElement(ElementName = "maxTargetSubscription", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19557")]
        [MinInclusive(1)]
        [MaxInclusive(2147483647)]
        public int MaxTargetSubscription
        {
            get => _maxTargetSubscription;
            set
            {
                MaxTargetSubscriptionSpecified = true;
                _maxTargetSubscription = value;
            }
        }

        [XmlIgnore]
        protected bool MaxTargetSubscriptionSpecified { get; set; }

        private bool _default;

        [XmlElement(ElementName = "default", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19557")]
        public bool Default
        {
            get => _default;
            set
            {
                DefaultSpecified = true;
                _default = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultSpecified { get; set; }

    }
}
