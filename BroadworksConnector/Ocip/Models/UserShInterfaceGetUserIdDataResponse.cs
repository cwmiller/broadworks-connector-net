using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserShInterfaceGetUserIdDataRequest.
    /// The response contains the Sh non-transparent data for the specified userId.
    /// The data also includes a userType, publicUserIdentity and endpointType.
    /// 
    /// Replaced by: UserShInterfaceGetUserIdDataResponse21sp1 in AS data mode.
        /// <see cref="UserShInterfaceGetUserIdDataRequest"/>
        /// <see cref="UserShInterfaceGetUserIdDataResponse21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserShInterfaceGetUserIdDataResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.ShInterfaceUserIdDataEntry> _entry;

        [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.ShInterfaceUserIdDataEntry> Entry {
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
