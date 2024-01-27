using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal change call forwarding destination menu keys.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:2373""}]")]
    public class ChangeCallForwardingDestinationMenuKeysReadEntry
    {

        protected string _finishEnteringNewDestinationNumber;

        [XmlElement(ElementName = "finishEnteringNewDestinationNumber", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2373")]
        [Length(1)]
        [RegularExpression(@"\*|#")]
        public string FinishEnteringNewDestinationNumber
        {
            get => _finishEnteringNewDestinationNumber;
            set
            {
                FinishEnteringNewDestinationNumberSpecified = true;
                _finishEnteringNewDestinationNumber = value;
            }
        }

        [XmlIgnore]
        protected bool FinishEnteringNewDestinationNumberSpecified { get; set; }

    }
}
