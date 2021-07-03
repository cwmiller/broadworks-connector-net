using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of userIds and/or Virtual On-Net user DNs that replaces a previously configured list.
    /// By convention, an element of this type may be set nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:9036""}]")]
    public class ReplacementCustomContactDirectoryEntryList
    {

        private List<BroadWorksConnector.Ocip.Models.CustomContactDirectoryEntry> _entry = new List<BroadWorksConnector.Ocip.Models.CustomContactDirectoryEntry>();

        [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:9036")]
        public List<BroadWorksConnector.Ocip.Models.CustomContactDirectoryEntry> Entry
        {
            get => _entry;
            set
            {
                EntrySpecified = true;
                _entry = value;
            }
        }

        [XmlIgnore]
        protected bool EntrySpecified { get; set; }

    }
}
