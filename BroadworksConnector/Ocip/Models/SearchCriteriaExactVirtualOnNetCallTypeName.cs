using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Criteria for searching for a particular fully specified Virtual On-Net Call Type Name.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f0ada2681ca347fa83b464734259b304:1375""}]")]
    public class SearchCriteriaExactVirtualOnNetCallTypeName : BroadWorksConnector.Ocip.Models.SearchCriteria
    {

        private string _virtualOnNetCallTypeName;

        [XmlElement(ElementName = "virtualOnNetCallTypeName", IsNullable = false, Namespace = "")]
        [Group(@"f0ada2681ca347fa83b464734259b304:1375")]
        [MinLength(1)]
        [MaxLength(40)]
        public string VirtualOnNetCallTypeName
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
