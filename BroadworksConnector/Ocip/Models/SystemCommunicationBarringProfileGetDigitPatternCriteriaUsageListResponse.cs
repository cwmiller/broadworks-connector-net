using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequest.
    /// The response contains a table of all Profiles that use the specific Digit Pattern Criteria. The column headings are "Name" and "Description"
        /// <see cref="SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCommunicationBarringProfileGetDigitPatternCriteriaUsageListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _profileTable;

        [XmlElement(ElementName = "profileTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ProfileTable {
            get => _profileTable;
            set {
                ProfileTableSpecified = true;
                _profileTable = value;
            }
        }

        [XmlIgnore]
        public bool ProfileTableSpecified { get; set; }
        
    }
}
