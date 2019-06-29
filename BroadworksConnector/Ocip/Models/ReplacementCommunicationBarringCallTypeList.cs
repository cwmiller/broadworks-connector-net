using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Communication Barring Call Types that replaces a previously
    /// configured list. By convention, an element of this type may be set
    /// nill to clear the list.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3219""}]")]
    public class ReplacementCommunicationBarringCallTypeList
    {

        private List<string> _callType = new List<string>();

        [XmlElement(ElementName = "callType", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3219")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> CallType
        {
            get => _callType;
            set
            {
                CallTypeSpecified = true;
                _callType = value;
            }
        }

        [XmlIgnore]
        protected bool CallTypeSpecified { get; set; }

    }
}
