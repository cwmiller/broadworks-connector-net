using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupEndpointGetListRequest.
    /// The column headings for the endpointTable are:
    /// "Line/Port", "Last Name", "First Name",  "User Id", "User Type", "Phone Number", "Extension", "Device Type", "Device Name", "Net Address", "MAC Address", "Department", "Email Address".
    /// Possible values for User Type are "User", "CCBasic", "CCStandard", "CCPremium", "RP", "MOH", "MOHVideo".
        /// <see cref="GroupEndpointGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupEndpointGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _endpointTable;

        [XmlElement(ElementName = "endpointTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable EndpointTable {
            get => _endpointTable;
            set {
                EndpointTableSpecified = true;
                _endpointTable = value;
            }
        }

        [XmlIgnore]
        public bool EndpointTableSpecified { get; set; }
        
    }
}
