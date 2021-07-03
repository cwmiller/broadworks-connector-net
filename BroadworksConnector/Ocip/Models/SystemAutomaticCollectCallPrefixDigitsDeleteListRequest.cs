using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete an entry in system automatic collect call prefix table.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""af1b47d7cab3335a81456e64e42371b0:113""}]")]
    public class SystemAutomaticCollectCallPrefixDigitsDeleteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private List<BroadWorksConnector.Ocip.Models.AutomaticCollectCallPrefixDigitsEntry> _prefixDigitsEntry = new List<BroadWorksConnector.Ocip.Models.AutomaticCollectCallPrefixDigitsEntry>();

        [XmlElement(ElementName = "prefixDigitsEntry", IsNullable = false, Namespace = "")]
        [Group(@"af1b47d7cab3335a81456e64e42371b0:113")]
        public List<BroadWorksConnector.Ocip.Models.AutomaticCollectCallPrefixDigitsEntry> PrefixDigitsEntry
        {
            get => _prefixDigitsEntry;
            set
            {
                PrefixDigitsEntrySpecified = true;
                _prefixDigitsEntry = value;
            }
        }

        [XmlIgnore]
        protected bool PrefixDigitsEntrySpecified { get; set; }

    }
}
