using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A list of Virtual On-Net Call Types that replaces a previously
    /// configured list. By convention, an element of this type may be set
    /// to nill to clear the list.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ReplacementVirtualOnNetCallTypeNameList 
    {

        
        private List<string> _virtualOnNetCallTypeName;

        [XmlElement(ElementName = "virtualOnNetCallTypeName", IsNullable = false, Namespace = "")]
        public List<string> VirtualOnNetCallTypeName {
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
