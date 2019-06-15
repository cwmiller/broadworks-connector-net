using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the
    /// SystemCallProcessingPolicyProfileGetAssignedNCOSListRequest.
    /// The response contains a table of all Network Classes of Service that
    /// contain the specific CAllP Policy Profile. The column headings
    /// are "Name" and "Description".
        /// <see cref="SystemCallProcessingPolicyProfileGetAssignedNCOSListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallProcessingPolicyProfileGetAssignedNCOSListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _networkClassOfServiceTable;

        [XmlElement(ElementName = "networkClassOfServiceTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable NetworkClassOfServiceTable {
            get => _networkClassOfServiceTable;
            set {
                NetworkClassOfServiceTableSpecified = true;
                _networkClassOfServiceTable = value;
            }
        }

        [XmlIgnore]
        public bool NetworkClassOfServiceTableSpecified { get; set; }
        
    }
}
