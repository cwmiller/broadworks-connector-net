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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:17180""}]")]
    public class UserCallRecordingGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.RecordingOption _recordingOption;

        [XmlElement(ElementName = "recordingOption", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:17180")]
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
