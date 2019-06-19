using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Indicates whether originating calls using specified Pinhole digit patterns are permitted.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:2306""}]")]
    public class OutgoingPinholeDigitPlanDigitPatternOriginatingPermission
    {

        private string _digitPatternName;

        [XmlElement(ElementName = "digitPatternName", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2306")]
        [MinLength(1)]
        [MaxLength(30)]
        public string DigitPatternName
        {
            get => _digitPatternName;
            set
            {
                DigitPatternNameSpecified = true;
                _digitPatternName = value;
            }
        }

        [XmlIgnore]
        public bool DigitPatternNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanOriginatingPermission _permission;

        [XmlElement(ElementName = "permission", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:2306")]
        public BroadWorksConnector.Ocip.Models.OutgoingPinholeDigitPlanOriginatingPermission Permission
        {
            get => _permission;
            set
            {
                PermissionSpecified = true;
                _permission = value;
            }
        }

        [XmlIgnore]
        public bool PermissionSpecified { get; set; }

    }
}
