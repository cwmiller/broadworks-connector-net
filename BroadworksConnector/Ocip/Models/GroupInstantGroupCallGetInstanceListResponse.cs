using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the GroupInstantGroupCallGetInstanceListRequest.
    /// Contains a 6 column table with column headings:
    /// "Service User Id", "Name", "Phone Number", "Extension", "Department", "Is Active".
    /// The column values for Is Active can either be true, or false.
        /// <see cref="GroupInstantGroupCallGetInstanceListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupInstantGroupCallGetInstanceListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _instantGroupCallTable;

        [XmlElement(ElementName = "instantGroupCallTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable InstantGroupCallTable {
            get => _instantGroupCallTable;
            set {
                InstantGroupCallTableSpecified = true;
                _instantGroupCallTable = value;
            }
        }

        [XmlIgnore]
        public bool InstantGroupCallTableSpecified { get; set; }
        
    }
}
