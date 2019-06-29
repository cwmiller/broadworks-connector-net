using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3403""}]")]
    public class ReplacementVirtualOnNetCallTypeNameList
    {

        private List<string> _virtualOnNetCallTypeName = new List<string>();

        [XmlElement(ElementName = "virtualOnNetCallTypeName", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3403")]
        [MinLength(1)]
        [MaxLength(40)]
        public List<string> VirtualOnNetCallTypeName
        {
            get => _virtualOnNetCallTypeName;
            set
            {
                VirtualOnNetCallTypeNameSpecified = true;
                _virtualOnNetCallTypeName = value;
            }
        }

        [XmlIgnore]
        protected bool VirtualOnNetCallTypeNameSpecified { get; set; }

    }
}
