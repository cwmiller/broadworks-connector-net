using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the TutorialFlagGetRequest.
    /// <see cref="TutorialFlagGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ef3c4f453d01f7ce750331de83ebc765:489""}]")]
    public class TutorialFlagGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enableTutorial;

        [XmlElement(ElementName = "enableTutorial", IsNullable = false, Namespace = "")]
        [Group(@"ef3c4f453d01f7ce750331de83ebc765:489")]
        public bool EnableTutorial
        {
            get => _enableTutorial;
            set
            {
                EnableTutorialSpecified = true;
                _enableTutorial = value;
            }
        }

        [XmlIgnore]
        protected bool EnableTutorialSpecified { get; set; }

    }
}
