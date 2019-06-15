using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupShInterfaceGetUserListRequest21sp1.
    /// The response contains the Sh Non Transparent data and associated Public User Identity
    /// information for every Public User Identity in the group.
        /// <see cref="GroupShInterfaceGetUserListRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupShInterfaceGetUserListResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.ShInterfaceUserListEntry21sp1> _entry;

        [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.ShInterfaceUserListEntry21sp1> Entry {
            get => _entry;
            set {
                EntrySpecified = true;
                _entry = value;
            }
        }

        [XmlIgnore]
        public bool EntrySpecified { get; set; }
        
    }
}
