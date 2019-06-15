using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupOutgoingCallingPlanPinholeDigitPatternGetListRequest.
    /// Contains a table with column headings: "Name", "Digit Pattern".
        /// <see cref="GroupOutgoingCallingPlanPinholeDigitPatternGetListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _digitPatternTable;

        [XmlElement(ElementName = "digitPatternTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable DigitPatternTable {
            get => _digitPatternTable;
            set {
                DigitPatternTableSpecified = true;
                _digitPatternTable = value;
            }
        }

        [XmlIgnore]
        public bool DigitPatternTableSpecified { get; set; }
        
    }
}
