using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderDialPlanPolicyGetAccessCodeListRequest.
    /// Contains a table with column headings: "Access Code",
    /// "Enable Secondary Dial Tone", "Description".
        /// <see cref="ServiceProviderDialPlanPolicyGetAccessCodeListRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderDialPlanPolicyGetAccessCodeListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.C.OCITable _accessCodeTable;

        [XmlElement(ElementName = "accessCodeTable", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AccessCodeTable {
            get => _accessCodeTable;
            set {
                AccessCodeTableSpecified = true;
                _accessCodeTable = value;
            }
        }

        [XmlIgnore]
        public bool AccessCodeTableSpecified { get; set; }
        
    }
}
