using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderCommunicationBarringProfileGetAssignedGroupListRequest.
    /// Contains a table of groups that have the Communication Barring Profile
    /// assigned. The column headings are: "Group Id" and "Group Name".
        /// <see cref="ServiceProviderCommunicationBarringProfileGetAssignedGroupListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderCommunicationBarringProfileGetAssignedGroupListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _groupTable;

        [XmlElement(ElementName = "groupTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupTable {
            get => _groupTable;
            set {
                GroupTableSpecified = true;
                _groupTable = value;
            }
        }

        [XmlIgnore]
        public bool GroupTableSpecified { get; set; }
        
    }
}
