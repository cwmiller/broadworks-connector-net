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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:37816""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19GreetingOnlyForwardingDestinationMenuKeys
    {

        private string _greetingOnlyForwardingDestination;

        [XmlElement(ElementName = "greetingOnlyForwardingDestination", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:37816")]
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
