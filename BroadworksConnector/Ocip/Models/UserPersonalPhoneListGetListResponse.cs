using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserPersonalPhoneListGetListRequest.
    /// The response contains a user's personal phone list.
        /// <see cref="UserPersonalPhoneListGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserPersonalPhoneListGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.PhoneListEntry> _entry;

        [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.PhoneListEntry> Entry {
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
