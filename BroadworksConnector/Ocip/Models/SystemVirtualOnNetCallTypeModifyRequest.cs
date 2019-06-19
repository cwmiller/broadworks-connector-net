using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a Virtual On-Net Call Type.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""179b744b0183abe614e8c32c17c96b7e:311""}]")]
    public class SystemVirtualOnNetCallTypeModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _virtualOnNetCallTypeName;

        [XmlElement(ElementName = "virtualOnNetCallTypeName", IsNullable = false, Namespace = "")]
        [Group(@"179b744b0183abe614e8c32c17c96b7e:311")]
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
        public bool VirtualOnNetCallTypeNameSpecified { get; set; }

        private string _virtualOnNetCallTypeCdrValue;

        [XmlElement(ElementName = "virtualOnNetCallTypeCdrValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"179b744b0183abe614e8c32c17c96b7e:311")]
        [MinLength(1)]
        [MaxLength(6)]
        public string VirtualOnNetCallTypeCdrValue
        {
            get => _virtualOnNetCallTypeCdrValue;
            set
            {
                VirtualOnNetCallTypeCdrValueSpecified = true;
                _virtualOnNetCallTypeCdrValue = value;
            }
        }

        [XmlIgnore]
        public bool VirtualOnNetCallTypeCdrValueSpecified { get; set; }

    }
}
