using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserShInterfaceGetUserIdDataRequest21sp1.
    /// The response contains the Sh non-transparent data for the specified userId.
    /// The data also includes a userType, publicUserIdentity and endpointType.
    /// The value Mobility in Endpoint Type is only applicable in AS data mode.
        /// <see cref="UserShInterfaceGetUserIdDataRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserShInterfaceGetUserIdDataResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.ShInterfaceUserIdDataEntry21sp1> _entry;

        [XmlElement(ElementName = "entry", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.ShInterfaceUserIdDataEntry21sp1> Entry {
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
