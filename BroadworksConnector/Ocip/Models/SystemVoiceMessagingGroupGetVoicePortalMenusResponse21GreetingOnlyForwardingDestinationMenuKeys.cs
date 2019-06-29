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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1099""}]")]
    public class SystemVoiceMessagingGroupGetVoicePortalMenusResponse21GreetingOnlyForwardingDestinationMenuKeys
    {

        private string _greetingOnlyForwardingDestination;

        [XmlElement(ElementName = "greetingOnlyForwardingDestination", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1099")]
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
