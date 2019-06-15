using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemCommunicationBarringProfileGetCriteriaUsageListRequest.
    /// The response contains a table of system Communication Barring Profiles that
    /// use the specific Communication Barring Criteria. The column headings
    /// are "Name" and "Description"
        /// <see cref="SystemCommunicationBarringProfileGetCriteriaUsageListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringProfileGetCriteriaUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _profileTable;

        [XmlElement(ElementName = "profileTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ProfileTable {
            get => _profileTable;
            set {
                ProfileTableSpecified = true;
                _profileTable = value;
            }
        }

        [XmlIgnore]
        public bool ProfileTableSpecified { get; set; }
        
    }
}
