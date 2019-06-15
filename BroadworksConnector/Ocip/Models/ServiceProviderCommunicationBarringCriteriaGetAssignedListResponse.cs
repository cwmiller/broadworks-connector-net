using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderCommunicationBarringCriteriaGetAssignedListRequest.
    /// Contains a table of all Communication Barring Criteria assigned to the
    /// service provider. The column headings are: "Name" and "Description".
        /// <see cref="ServiceProviderCommunicationBarringCriteriaGetAssignedListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderCommunicationBarringCriteriaGetAssignedListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _criteriaTable;

        [XmlElement(ElementName = "criteriaTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CriteriaTable {
            get => _criteriaTable;
            set {
                CriteriaTableSpecified = true;
                _criteriaTable = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaTableSpecified { get; set; }
        
    }
}
