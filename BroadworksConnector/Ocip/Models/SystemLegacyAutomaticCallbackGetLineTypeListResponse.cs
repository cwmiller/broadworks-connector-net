using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLegacyAutomaticCallbackGetLineTypeListRequest. Returns a 3 column
    /// table with column headings: "Line Type", "Match" and "No Match". The possible values
    /// for the "Match" and "No Match" columns are "Accept" and "Deny".
        /// <see cref="SystemLegacyAutomaticCallbackGetLineTypeListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLegacyAutomaticCallbackGetLineTypeListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _lineTypeTable;

        [XmlElement(ElementName = "lineTypeTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable LineTypeTable {
            get => _lineTypeTable;
            set {
                LineTypeTableSpecified = true;
                _lineTypeTable = value;
            }
        }

        [XmlIgnore]
        public bool LineTypeTableSpecified { get; set; }
        
    }
}
