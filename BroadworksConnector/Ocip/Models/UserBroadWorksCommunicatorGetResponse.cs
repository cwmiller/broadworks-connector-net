using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserBroadWorksCommunicatorGetRequest.
    /// <see cref="UserBroadWorksCommunicatorGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ba512c9f02a5f24a24d49cc945f1524d:104""}]")]
    public class UserBroadWorksCommunicatorGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _configurationServerURL;

        [XmlElement(ElementName = "configurationServerURL", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ba512c9f02a5f24a24d49cc945f1524d:104")]
        [MinLength(1)]
        [MaxLength(256)]
        public string ConfigurationServerURL
        {
            get => _configurationServerURL;
            set
            {
                ConfigurationServerURLSpecified = true;
                _configurationServerURL = value;
            }
        }

        [XmlIgnore]
        protected bool ConfigurationServerURLSpecified { get; set; }

    }
}
