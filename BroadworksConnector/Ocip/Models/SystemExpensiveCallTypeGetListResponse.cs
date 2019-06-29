using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemExpensiveCallTypeGetListRequest.
    /// Replaced by: SystemExpensiveCallTypeGetListResponse16sp1
    /// <see cref="SystemExpensiveCallTypeGetListRequest"/>
    /// <see cref="SystemExpensiveCallTypeGetListResponse16sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:15328""}]")]
    public class SystemExpensiveCallTypeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _alternateCallIndicator = new List<string>();

        [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:15328")]
        [MinLength(1)]
        [MaxLength(64)]
        public List<string> AlternateCallIndicator
        {
            get => _alternateCallIndicator;
            set
            {
                AlternateCallIndicatorSpecified = true;
                _alternateCallIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool AlternateCallIndicatorSpecified { get; set; }

    }
}
