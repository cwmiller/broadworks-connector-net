using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallRecordingGetRequest.
    /// The response contains the user's Call Recording option information.
    /// <see cref="UserCallRecordingGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:32472""}]")]
    public class UserCallRecordingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.RecordingOption _recordingOption;

        [XmlElement(ElementName = "recordingOption", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:32472")]
        public BroadWorksConnector.Ocip.Models.RecordingOption RecordingOption
        {
            get => _recordingOption;
            set
            {
                RecordingOptionSpecified = true;
                _recordingOption = value;
            }
        }

        [XmlIgnore]
        protected bool RecordingOptionSpecified { get; set; }

    }
}
