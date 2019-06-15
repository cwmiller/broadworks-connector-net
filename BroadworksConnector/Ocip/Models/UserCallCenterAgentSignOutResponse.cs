using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallCenterAgentSignOutRequest.
    /// It contains a list of call centers for which the agent is the last signed-in agent.
    /// Contains a table with column headings: "Service User Id" and "Call Center Name".
        /// <see cref="UserCallCenterAgentSignOutRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserCallCenterAgentSignOutResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _callCenterTable;

        [XmlElement(ElementName = "callCenterTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CallCenterTable {
            get => _callCenterTable;
            set {
                CallCenterTableSpecified = true;
                _callCenterTable = value;
            }
        }

        [XmlIgnore]
        public bool CallCenterTableSpecified { get; set; }
        
    }
}
