using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserPrimaryEndpointAdvancedSettingGetRequest.
    /// <see cref="UserPrimaryEndpointAdvancedSettingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""53d18cc797d03d802cbc411ad821f1d4:3338""}]")]
    public class UserPrimaryEndpointAdvancedSettingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _allowOrigination;

        [XmlElement(ElementName = "allowOrigination", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3338")]
        public bool AllowOrigination
        {
            get => _allowOrigination;
            set
            {
                AllowOriginationSpecified = true;
                _allowOrigination = value;
            }
        }

        [XmlIgnore]
        public bool AllowOriginationSpecified { get; set; }

        private bool _allowTermination;

        [XmlElement(ElementName = "allowTermination", IsNullable = false, Namespace = "")]
        [Group(@"53d18cc797d03d802cbc411ad821f1d4:3338")]
        public bool AllowTermination
        {
            get => _allowTermination;
            set
            {
                AllowTerminationSpecified = true;
                _allowTermination = value;
            }
        }

        [XmlIgnore]
        public bool AllowTerminationSpecified { get; set; }

    }
}
