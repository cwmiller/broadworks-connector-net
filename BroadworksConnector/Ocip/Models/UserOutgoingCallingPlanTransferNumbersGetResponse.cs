using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserOutgoingCallingPlanTransferNumbersGetRequest.
    /// <see cref="UserOutgoingCallingPlanTransferNumbersGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6f793dfca9bd3d121bb35e0f9cf1cb2e:1696""}]")]
    public class UserOutgoingCallingPlanTransferNumbersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useCustomSettings;

        [XmlElement(ElementName = "useCustomSettings", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1696")]
        public bool UseCustomSettings
        {
            get => _useCustomSettings;
            set
            {
                UseCustomSettingsSpecified = true;
                _useCustomSettings = value;
            }
        }

        [XmlIgnore]
        public bool UseCustomSettingsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbers _userNumbers;

        [XmlElement(ElementName = "userNumbers", IsNullable = false, Namespace = "")]
        [Group(@"6f793dfca9bd3d121bb35e0f9cf1cb2e:1696")]
        public BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbers UserNumbers
        {
            get => _userNumbers;
            set
            {
                UserNumbersSpecified = true;
                _userNumbers = value;
            }
        }

        [XmlIgnore]
        public bool UserNumbersSpecified { get; set; }

    }
}
