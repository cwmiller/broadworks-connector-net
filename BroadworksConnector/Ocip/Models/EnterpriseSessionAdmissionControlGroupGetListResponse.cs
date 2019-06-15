using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseSessionAdmissionControlGroupGetListRequest.
    /// Contains a table of session admission control group configured in the enterprise.
    /// The column headings are: "Name", "Is Default", "Maximum Sessions", "Maximum Originating Sessions", "Maximum Terminating Sessions"..
        /// <see cref="EnterpriseSessionAdmissionControlGroupGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class EnterpriseSessionAdmissionControlGroupGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _sessionAdmissionControlGroupTable;

        [XmlElement(ElementName = "sessionAdmissionControlGroupTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SessionAdmissionControlGroupTable {
            get => _sessionAdmissionControlGroupTable;
            set {
                SessionAdmissionControlGroupTableSpecified = true;
                _sessionAdmissionControlGroupTable = value;
            }
        }

        [XmlIgnore]
        public bool SessionAdmissionControlGroupTableSpecified { get; set; }
        
    }
}
