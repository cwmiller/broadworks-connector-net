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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:552""}]")]
    public class TutorialFlagGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableTutorial;

        [XmlElement(ElementName = "enableTutorial", IsNullable = false, Namespace = "")]
        [Group(@"6b27fcc79475236456fc113a42b75543:552")]
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
