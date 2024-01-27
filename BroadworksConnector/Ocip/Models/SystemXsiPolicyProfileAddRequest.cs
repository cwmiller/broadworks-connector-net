using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add the system Xsi policy profile entry.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19755""}]")]
    public class SystemXsiPolicyProfileAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19755")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.XsiPolicyProfileLevel _level;

        [XmlElement(ElementName = "level", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19755")]
        public BroadWorksConnector.Ocip.Models.XsiPolicyProfileLevel Level
        {
            get => _level;
            set
            {
                LevelSpecified = true;
                _level = value;
            }
        }

        [XmlIgnore]
        protected bool LevelSpecified { get; set; }

        protected string _description;

        [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:19755")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:19755")]
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

    }
}
