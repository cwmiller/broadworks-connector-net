using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular fully specified Virtual On-Net Call Type Name.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SearchCriteriaExactVirtualOnNetCallTypeName : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        
        private string _virtualOnNetCallTypeName;

        [XmlElement(ElementName = "virtualOnNetCallTypeName", IsNullable = false, Namespace = "")]
        public string VirtualOnNetCallTypeName {
            get => _virtualOnNetCallTypeName;
            set {
                VirtualOnNetCallTypeNameSpecified = true;
                _virtualOnNetCallTypeName = value;
            }
        }

        [XmlIgnore]
        public bool VirtualOnNetCallTypeNameSpecified { get; set; }
        
    }
}
