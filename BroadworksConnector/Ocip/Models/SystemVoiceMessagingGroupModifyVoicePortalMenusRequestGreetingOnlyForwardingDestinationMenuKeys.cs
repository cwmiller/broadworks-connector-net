using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:28693""}]")]
    public class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestGreetingOnlyForwardingDestinationMenuKeys
    {

        private string _greetingOnlyForwardingDestination;

        [XmlElement(ElementName = "greetingOnlyForwardingDestination", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28693")]
        [Length(1)]
        [RegularExpression(@"\*|#")]
        public string GreetingOnlyForwardingDestination
        {
            get => _greetingOnlyForwardingDestination;
            set
            {
                GreetingOnlyForwardingDestinationSpecified = true;
                _greetingOnlyForwardingDestination = value;
            }
        }

        [XmlIgnore]
        protected bool GreetingOnlyForwardingDestinationSpecified { get; set; }

    }
}
