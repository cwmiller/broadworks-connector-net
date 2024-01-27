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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a63afa661ee5c74f4700e562e88c66d0:1696""}]")]
    public class UserOutgoingCallingPlanTransferNumbersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useCustomSettings;

        [XmlElement(ElementName = "useCustomSettings", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1696")]
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
        protected bool UseCustomSettingsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.OutgoingCallingPlanTransferNumbers _userNumbers;

        [XmlElement(ElementName = "userNumbers", IsNullable = false, Namespace = "")]
        [Group(@"a63afa661ee5c74f4700e562e88c66d0:1696")]
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
        protected bool UserNumbersSpecified { get; set; }

    }
}
