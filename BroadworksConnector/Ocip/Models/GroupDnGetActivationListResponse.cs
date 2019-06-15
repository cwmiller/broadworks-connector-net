using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupDnGetActivationListRequest.
    /// The response contains a table with columns: "Phone Numbers", and "Activated".  ".  Phone Numbers are only returned if assigned to a user.
    /// The "Phone Numbers" column contains either a single DN or a range of DNs.
    /// The "Activated" column indicates if the phone number(s) are activated or not.
        /// <see cref="GroupDnGetActivationListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupDnGetActivationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _dnTable;

        [XmlElement(ElementName = "dnTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DnTable {
            get => _dnTable;
            set {
                DnTableSpecified = true;
                _dnTable = value;
            }
        }

        [XmlIgnore]
        public bool DnTableSpecified { get; set; }
        
    }
}
