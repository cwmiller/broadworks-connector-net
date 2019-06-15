using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserPersonalAssistantExclusionNumberGetListRequest.
    /// Contains a table with column headings:
    /// "Number", "Description".
        /// <see cref="UserPersonalAssistantExclusionNumberGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class UserPersonalAssistantExclusionNumberGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _exclusionNumberTable;

        [XmlElement(ElementName = "exclusionNumberTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ExclusionNumberTable {
            get => _exclusionNumberTable;
            set {
                ExclusionNumberTableSpecified = true;
                _exclusionNumberTable = value;
            }
        }

        [XmlIgnore]
        public bool ExclusionNumberTableSpecified { get; set; }
        
    }
}
