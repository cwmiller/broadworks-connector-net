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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19876""}]")]
    public class SystemXsiPolicyProfileGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:19876")]
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

        protected int _maxTargetSubscription;

        [XmlElement(ElementName = "maxTargetSubscription", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19876")]
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

        protected bool _default;

        [XmlElement(ElementName = "default", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19876")]
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
