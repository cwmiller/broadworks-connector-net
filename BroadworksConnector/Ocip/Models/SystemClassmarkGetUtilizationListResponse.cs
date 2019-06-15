using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemClassmarkGetUtilizationListRequest.
    /// Contains a table with the column headings: "User Id", "Group Id", "Service Provider Id",
    /// "Last Name", "First Name", and "Phone Number", "Extension", "Department", "Email Address".
        /// <see cref="SystemClassmarkGetUtilizationListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemClassmarkGetUtilizationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _classmarkUserTable;

        [XmlElement(ElementName = "classmarkUserTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ClassmarkUserTable {
            get => _classmarkUserTable;
            set {
                ClassmarkUserTableSpecified = true;
                _classmarkUserTable = value;
            }
        }

        [XmlIgnore]
        public bool ClassmarkUserTableSpecified { get; set; }
        
    }
}
