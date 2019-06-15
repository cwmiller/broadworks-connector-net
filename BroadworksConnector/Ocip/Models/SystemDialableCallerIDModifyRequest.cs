using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level Dialable Caller ID criteria list.
    /// The response is either a SuccessResponse or an ErrorResponse.
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemDialableCallerIDModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private List<BroadWorksConnector.Ocip.Models.DialableCallerIDCriteriaPriorityOrder> _criteriaPriorityOrder;

        [XmlElement(ElementName = "criteriaPriorityOrder", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.DialableCallerIDCriteriaPriorityOrder> CriteriaPriorityOrder {
            get => _criteriaPriorityOrder;
            set {
                CriteriaPriorityOrderSpecified = true;
                _criteriaPriorityOrder = value;
            }
        }

        [XmlIgnore]
        public bool CriteriaPriorityOrderSpecified { get; set; }
        
    }
}
